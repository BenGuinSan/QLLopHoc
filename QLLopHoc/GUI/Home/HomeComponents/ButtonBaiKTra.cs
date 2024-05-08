using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc.KiemTra;

namespace QLLopHoc.GUI.Home.HomeComponents
{
    public partial class ButtonBaiKTra : UserControl
    {
        PanelChuongDropDown pnlChuongDropDown;
        DeKiemTraDTO dekiemtra;
        DeKiemTraBUS dktBUS;
        BaiLamKiemTraBUS blktBUS;
        public ButtonBaiKTra(PanelChuongDropDown pnlChuongDropDown, DeKiemTraDTO dekiemtra)
        {
            InitializeComponent();
            this.pnlChuongDropDown = pnlChuongDropDown;
            this.dekiemtra = dekiemtra;
            dktBUS = new DeKiemTraBUS();
            blktBUS = new BaiLamKiemTraBUS();

            this.lblTieuDeBKT.Text = dekiemtra.Tieude;
            this.timerCapNhatTrangThai.Start();

            if (pnlChuongDropDown.Khfrm.Lophoc.Daxoa == 1)
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xóa đề kiểm tra?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                if (dktBUS.XoaDeKiemTra(this.dekiemtra))
                {
                    pnlChuongDropDown.XoaChuongComponent(this);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public string XacDinhTrangThaiDeKiemTra(DateTime startTime, DateTime endTime)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime < startTime)
            {
                this.lblChiTietBKT.StateCommon.ShortText.Color1 = Color.Gray;
                this.btnXoa.Visible = true;
                this.btnSua.Visible = true;
                return "Chưa mở";
            }
            else if (currentTime >= startTime && currentTime <= endTime)
            {
                this.lblChiTietBKT.StateCommon.ShortText.Color1 = Color.Green;
                this.btnXoa.Visible = false;
                this.btnSua.Visible = true;
                return "Đang diễn ra";
            }
            else
            {
                this.lblChiTietBKT.StateCommon.ShortText.Color1 = Color.Red;
                this.btnXoa.Visible = true;
                this.btnSua.Visible = false;
                return "Đã kết thúc";
            }
        }

        private void timerCapNhatTrangThai_Tick(object sender, EventArgs e)
        {
            string trangthai = XacDinhTrangThaiDeKiemTra(this.dekiemtra.Thoigianbatdau, this.dekiemtra.Thoigianketthuc);
            this.lblChiTietBKT.Text = "Bài kiểm tra (" + dekiemtra.Thoigianbatdau.ToString("dd/MM/yy HH:mm:ss") + " - " + dekiemtra.Thoigianketthuc.ToString("dd/MM/yy HH:mm:ss") + ") | " + trangthai;
            if (this.pnlChuongDropDown.Khfrm.Taikhoan.Mataikhoan.Equals(this.pnlChuongDropDown.Khfrm.Lophoc.Magiangvien) && pnlChuongDropDown.Khfrm.Lophoc.Daxoa == 0)
            {
                if (this.dekiemtra.Thoigianbatdau.AddMinutes(-15) <= DateTime.Now)
                    this.btnSua.Visible = false;
            }
            else
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
            if (trangthai == "Đã kết thúc")
                this.timerCapNhatTrangThai.Stop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new KiemTrafrm(this.dekiemtra).ShowDialog();
        }

        private void btnBaiKiemTra_Click(object sender, EventArgs e)
        {
            if (!pnlChuongDropDown.Khfrm.Lophoc.Magiangvien.Equals(pnlChuongDropDown.Khfrm.Taikhoan.Mataikhoan))
            {
                // Not start yet
                if (DateTime.Now < this.dekiemtra.Thoigianbatdau)
                {
                    MessageBox.Show("Bài kiểm tra chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited
                if (blktBUS.isSubmited(this.pnlChuongDropDown.Khfrm.Taikhoan.Mataikhoan, this.dekiemtra.Madekiemtra) == 1)
                {
                    // TODO: mở form xem bài đã làm
                    DialogResult isConfirmSubmited = MessageBox.Show("Bạn đã hoàn thành bài kiểm tra !\nXem lại bài đã nộp ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isConfirmSubmited == DialogResult.No) return;

                    XemBaiLamHocSinhfrm frmBailam = new XemBaiLamHocSinhfrm(this.pnlChuongDropDown.Khfrm.Taikhoan, dekiemtra, false);
                    frmBailam.Show();
                    return;
                }
                if (this.dekiemtra.Thoigianketthuc < DateTime.Now)
                {
                    MessageBox.Show("Bài kiểm tra đã kết thúc !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Xác nhận tiến hành làm bài kiểm tra ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;

                LamKiemTrafrm bailamkiemtra = new LamKiemTrafrm(this.dekiemtra, pnlChuongDropDown.Khfrm.Taikhoan, this.blktBUS);
                bailamkiemtra.ShowDialog();
            }
            else
            {
                XemTienDoBaiKTfrm checkingFrm = new XemTienDoBaiKTfrm(this.pnlChuongDropDown.Khfrm.Taikhoan, this.dekiemtra, this.pnlChuongDropDown.Khfrm.Lophoc, this.pnlChuongDropDown.Chuong);
                checkingFrm.Show();
            }
        }
    }
}

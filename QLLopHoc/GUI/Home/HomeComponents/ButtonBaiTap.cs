using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien;
using QLLopHoc.GUI.KhoaHoc.BaiTap.SinhVien;

namespace QLLopHoc.GUI.Home.HomeComponents
{
    public partial class ButtonBaiTap : UserControl
    {
        PanelChuongDropDown panelChuong;
        private BaiTapDTO baitap;
        private BaiLamBaiTapBUS blbtBUS;
        private BaiTapBUS baitapBUS;

        public ButtonBaiTap(PanelChuongDropDown panelChuong, BaiTapDTO baitap)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.baitap = baitap;
            this.lblTieuDeBT.Text = baitap.Tieude;
            timerCapNhatTrangThai.Start();
            if (panelChuong.Khfrm.Lophoc.Daxoa == 1)
            {
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
            this.blbtBUS = new BaiLamBaiTapBUS();
            this.baitapBUS = new BaiTapBUS();
        }

        private void btnBaitap_Click(object sender, EventArgs e)
        {
            if (!panelChuong.Khfrm.Lophoc.Magiangvien.Equals(panelChuong.Khfrm.Taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.baitap.Thoigianbatdau)
                {
                    MessageBox.Show("Bài tập chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited

                int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.panelChuong.Khfrm.Taikhoan.Mataikhoan, this.baitap.Mabaitap);
                if (index >= 0)
                {
                    DialogResult isConfirmSubmited = MessageBox.Show("Bạn đã hoàn thành bài tập !\nXem lại bài đã nộp ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (isConfirmSubmited == DialogResult.No) return;

                    XemBaiLamfrm blbtFrm = new XemBaiLamfrm(this.panelChuong.Khfrm.Taikhoan, this.baitap, (BaiLamBaiTapDTO)this.blbtBUS.List[index]);
                    blbtFrm.Show();
                    return;
                }
                if (this.baitap.Thoigianketthuc < DateTime.Now)
                {
                    if (this.baitap.Nopbu == 1)
                    {
                        DialogResult confirmLamBu = MessageBox.Show("Tiến hành làm bài tập bù ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmLamBu == DialogResult.No) return;
                        LamBaiTapfrm lambaitapbuFrm = new LamBaiTapfrm(this.panelChuong.Khfrm.Taikhoan, this.baitap, this.blbtBUS);
                        lambaitapbuFrm.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bài tập đã kết thúc ! Không chấp nhận nộp bù !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // do exam
                DialogResult isConfirmDoExam = MessageBox.Show("Tiến hành làm bài tập ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isConfirmDoExam == DialogResult.No) return;
                LamBaiTapfrm lambaitapFrm = new LamBaiTapfrm(this.panelChuong.Khfrm.Taikhoan, this.baitap, this.blbtBUS);
                lambaitapFrm.Show();
                return;
            }
            else // teacher
            {
                XemTienDoBaiTap xemtiendoFrm = new XemTienDoBaiTap(this.baitap, this.panelChuong.Khfrm.Lophoc, this.panelChuong.Chuong);
                xemtiendoFrm.Show();
            }
            return;
        }

        private void timerCapNhatTrangThai_Tick(object sender, EventArgs e)
        {
            string trangthai = XacDinhTrangThaiDeKiemTra(this.baitap.Thoigianbatdau, this.baitap.Thoigianketthuc);
            this.lblChiTietBT.Text = "Bài tập (" + baitap.Thoigianbatdau.ToString("dd/MM/yy HH:mm:ss") + " - " + baitap.Thoigianketthuc.ToString("dd/MM/yy HH:mm:ss") + ") | " + trangthai;
            if (this.panelChuong.Khfrm.Taikhoan.Mataikhoan.Equals(this.panelChuong.Khfrm.Lophoc.Magiangvien) && panelChuong.Khfrm.Lophoc.Daxoa == 0)
            {
                if (this.baitap.Thoigianbatdau.AddMinutes(-15) <= DateTime.Now)
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

        private void ButtonBaiTap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận xóa bài tập ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            this.baitapBUS.DeleteBaitapByChangeState(this.baitap.Mabaitap);
            panelChuong.XoaChuongComponent(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.AddMinutes(15) > this.baitap.Thoigianbatdau)
            {
                MessageBox.Show("Chỉ chỉnh sửa trước thời gian bắt đầu 15 phút !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ChinhSuaBaiTapfrm editBtFrm = new ChinhSuaBaiTapfrm(this.panelChuong, this.panelChuong.Khfrm.Taikhoan, this.panelChuong.Khfrm.Lophoc, this.panelChuong.Chuong, this.baitap, this.baitapBUS);
            editBtFrm.FormClosing += EditBtFrm_FormClosing;
            editBtFrm.Show();
        }

        private void EditBtFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.baitapBUS.loadList();
            this.lblTieuDeBT.Text = this.baitap.Tieude;
        }
        public string XacDinhTrangThaiDeKiemTra(DateTime startTime, DateTime endTime)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime < startTime)
            {
                this.lblChiTietBT.StateCommon.ShortText.Color1 = Color.Gray;
                this.btnXoa.Visible = true;
                this.btnSua.Visible = true;
                return "Chưa mở";
            }
            else if (currentTime >= startTime && currentTime <= endTime)
            {
                this.lblChiTietBT.StateCommon.ShortText.Color1 = Color.Green;
                this.btnXoa.Visible = false;
                this.btnSua.Visible = true;
                return "Đang diễn ra";
            }
            else
            {
                this.lblChiTietBT.StateCommon.ShortText.Color1 = Color.Red;
                this.btnXoa.Visible = true;
                this.btnSua.Visible = false;
                return "Đã kết thúc";
            }
        }
    }
}

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
using QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien;
using QLLopHoc.GUI.KhoaHoc.BaiTap.SinhVien;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.GUI.Todo
{
    public partial class TaskHomeWork : UserControl
    {
        private BaiTapDTO baitap;
        private BaiLamBaiTapBUS blbtBUS;
        private TaiKhoanDTO taikhoan;
        private LopHocDTO lh;
        private ChuongDTO chuong;

        public TaiKhoanDTO Taikhoan { get => taikhoan; set => taikhoan = value; }
        public LopHocDTO Lh { get => lh; set => lh = value; }
        public ChuongDTO Chuong { get => chuong; set => chuong = value; }

        public TaskHomeWork()
        {
            InitializeComponent();
        }

        public TaskHomeWork(TaiKhoanDTO taikhoan, BaiTapDTO baitap, LopHocDTO lh, ChuongDTO chuong, BaiLamBaiTapBUS blbtBUS)
        {
            InitializeComponent();
            this.baitap = baitap;
            this.Taikhoan = taikhoan;
            this.Lh = lh;
            this.Chuong = chuong;
            this.blbtBUS = blbtBUS;
            loadBaitap();
        }

        private void loadBaitap()
        {
            this.lblTitle.Text = baitap.Tieude;
            this.lblDeadline.Text = "Từ" + baitap.Thoigianbatdau.ToString() + "đến:" + baitap.Thoigianketthuc.ToString();
            this.btnDoHomework.Text = (this.lh.Magiangvien.Equals(this.taikhoan.Mataikhoan)) ? "Xem tiến độ" : "Làm bài tập";
            int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.Taikhoan.Mataikhoan, this.baitap.Mabaitap);
            if (index >= 0)
                this.btnDoHomework.Text = "Xem bài làm";
            this.lophoc.Text = "Lớp học:" + lh.Tenlop;
        }

        private void btnDoHomework_Click(object sender, EventArgs e)
        {
            if (!this.Lh.Magiangvien.Equals(this.Taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.baitap.Thoigianbatdau)
                {
                    MessageBox.Show("Bài tập chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited

                int index = blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(this.Taikhoan.Mataikhoan, this.baitap.Mabaitap);
                if (index >= 0)
                {
                    XemBaiLamfrm blbtFrm = new XemBaiLamfrm(this.Taikhoan, this.baitap, (BaiLamBaiTapDTO)this.blbtBUS.List[index]);
                    blbtFrm.Show();
                    return;
                }
                if (this.baitap.Thoigianketthuc < DateTime.Now)
                {
                    if (this.baitap.Nopbu == 1)
                    {
                        DialogResult confirmLamBu = MessageBox.Show("Tiến hành làm bài tập bù ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmLamBu == DialogResult.No) return;
                        LamBaiTapfrm lambaitapbuFrm = new LamBaiTapfrm(this.Taikhoan, this.baitap, this.blbtBUS);
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
                LamBaiTapfrm lambaitapFrm = new LamBaiTapfrm(this.Taikhoan, this.baitap, this.blbtBUS);
                lambaitapFrm.Show();
                return;
            }
            else // teacher
            {
                XemTienDoBaiTap xemtiendoFrm = new XemTienDoBaiTap(this.baitap, this.Lh, this.Chuong);
                xemtiendoFrm.Show();
            }
            return;
        }
    }
}

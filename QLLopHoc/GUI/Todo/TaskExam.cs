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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.GUI.Todo
{
    public partial class TaskExam : UserControl
    {
        private DeKiemTraDTO dkt;
        private BaiLamKiemTraBUS blktBUS;
        private TaiKhoanDTO taikhoan;
        private LopHocDTO lh;
        private ChuongDTO chuong;

        public TaskExam()
        {
            InitializeComponent();
        }

        public DeKiemTraDTO Dkt { get => dkt; set => dkt = value; }
        public BaiLamKiemTraBUS BlktBUS { get => blktBUS; set => blktBUS = value; }
        public TaiKhoanDTO Taikhoan { get => taikhoan; set => taikhoan = value; }
        public LopHocDTO Lh { get => lh; set => lh = value; }
        public ChuongDTO Chuong { get => chuong; set => chuong = value; }

        public TaskExam(TaiKhoanDTO taikhoan, DeKiemTraDTO dkt, LopHocDTO lh, ChuongDTO chuong, BaiLamKiemTraBUS blktBUS)
        {
            InitializeComponent();
            this.Dkt = dkt;
            this.Taikhoan = taikhoan;
            this.Lh = lh;
            this.Chuong = chuong;
            BlktBUS = blktBUS;
            loadTaskExam();
        }

        public void loadTaskExam()
        {
            this.lblExamTitle.Text = this.Dkt.Tieude;
            this.lblStart.Text = "Bắt đầu:" + Dkt.Thoigianbatdau.ToString();
            this.lblEnd.Text = "Kết thúc:" + Dkt.Thoigianketthuc.ToString();
            if (Dkt.Daxoa == 1)
                this.btnDoExam.Visible = false;
            else
                this.btnDoExam.Visible = true;

            if (this.lh.Magiangvien.Equals(this.taikhoan.Mataikhoan))
            {
                this.btnDoExam.Text = "Xem tiến độ";
            }
            else if (BlktBUS.isSubmited(this.Taikhoan.Mataikhoan, this.Dkt.Madekiemtra) == 1)
            {
                this.btnDoExam.Text = "Xem bài làm";
            }
            else
            {
                this.btnDoExam.Text = "Làm kiểm tra";
            }

        }

        public Label getLabelClass()
        {
            return this.lblClass;
        }

        private void lblExamTitle_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnDoExam_Click(object sender, EventArgs e)
        {
            if (!this.Lh.Magiangvien.Equals(this.Taikhoan.Mataikhoan))// student
            {
                // Not start yet
                if (DateTime.Now < this.Dkt.Thoigianbatdau)
                {
                    MessageBox.Show("Bài kiểm tra chưa bắt đầu !", "Thông báo!", MessageBoxButtons.OK);
                    return;
                }
                // already submited
                if (BlktBUS.isSubmited(this.Taikhoan.Mataikhoan, this.Dkt.Madekiemtra) == 1)
                {
                    XemBaiLamHocSinhfrm frmBailam = new XemBaiLamHocSinhfrm(this.Taikhoan, this.Dkt, false);
                    frmBailam.Show();
                    return;
                }
                LamKiemTrafrm bailamkiemtra = new LamKiemTrafrm(this.Dkt, this.Taikhoan, this.BlktBUS);
                bailamkiemtra.Show();
            }
            else
            {
                XemTienDoBaiKTfrm checkingFrm = new XemTienDoBaiKTfrm(this.Taikhoan, this.Dkt, this.Lh, this.Chuong);
                checkingFrm.Show();
            }
        }
    }
}

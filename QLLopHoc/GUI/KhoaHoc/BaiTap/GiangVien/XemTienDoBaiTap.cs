using System;
using System.Collections;
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
using QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien
{
    public partial class XemTienDoBaiTap : Form
    {
        private BaiTapDTO baitap;
        private LopHocDTO lophoc;
        private TaiKhoanBUS taikhoanBUS;
        private ThamGiaBUS thamgiaBUS;
        private BaiLamBaiTapBUS blbtBUS;
        private ArrayList listSubmited;
        private ArrayList listNotSubmited;
        private int whichIsClick = 1; // 1=chưa nộp ; 2=chưa đánh giá ; 3=đã đánh giá
        public XemTienDoBaiTap()
        {
            InitializeComponent();
        }
        public XemTienDoBaiTap(BaiTapDTO bt, LopHocDTO lophoc, ChuongDTO chuong)
        {
            InitializeComponent();
            this.baitap = bt;
            this.lophoc = lophoc;
            this.lblChuong.Text = chuong.Tenchuong;
        }

        private void XemTienDoBaiTap_Load(object sender, EventArgs e)
        {
            listSubmited = new ArrayList();
            listNotSubmited = new ArrayList();
            taikhoanBUS = new TaiKhoanBUS();
            thamgiaBUS = new ThamGiaBUS();
            blbtBUS = new BaiLamBaiTapBUS();
            this.lblTitle.Text = this.baitap.Tieude;
            this.lblLop.Text = this.lophoc.Tenlop;
            this.createAt.Text = this.baitap.Thoigiantao.ToString("dd/MM/yyyy HH:mm:ss");
            this.startAt.Text = this.baitap.Thoigianbatdau.ToString("dd/MM/yyyy HH:mm:ss");
            this.endAt.Text = this.baitap.Thoigianketthuc.ToString("dd/MM/yyyy HH:mm:ss");

            if ((DateTime.Now > this.baitap.Thoigianketthuc))
            {
                this.state.Text = "Đã kết thúc";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.state.Text = "Đang tiến hành";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Green;
            }
            loadListSubmitedAndNotSubmited(this.lophoc);
            this.notSubmit.PerformClick();
        }
        private void loadListSubmitedAndNotSubmited(LopHocDTO lophoc)
        {
            try
            {
                this.listNotSubmited.Clear();
                this.listSubmited.Clear();
                blbtBUS.loadList();
                double highestScore = -1;
                double totalScore = 0;
                double numberOfStudentSubmit = 0;
                ArrayList danhsachlop = new ArrayList();
                ArrayList listTmp = thamgiaBUS.getDanhSachLopWithMaLopHoc(lophoc.Malop);
                foreach (string mataikhoan in listTmp)
                {
                    int index_taikhoan = taikhoanBUS.GetTaiKhoanByMaTaiKhoan(mataikhoan);
                    if (index_taikhoan < 0) throw new Exception("Mã tài khoản tham gia lớp học không đúng");
                    danhsachlop.Add(taikhoanBUS.List[index_taikhoan]);// use for load submit/notsubmit btn
                    int index_blbt = this.blbtBUS.GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(mataikhoan, this.baitap.Mabaitap);
                    if (index_blbt >= 0)
                    {
                        this.listSubmited.Add(blbtBUS.List[index_blbt]);
                        double diem_bai_lam = (blbtBUS.List[index_blbt] as BaiLamBaiTapDTO).Diem;
                        if (diem_bai_lam != -1 && diem_bai_lam > highestScore)
                            highestScore = diem_bai_lam;
                        if (diem_bai_lam != -1)
                        {
                            totalScore += diem_bai_lam;
                            numberOfStudentSubmit++;
                        }
                    }
                    else
                    {
                        this.listNotSubmited.Add(taikhoanBUS.List[index_taikhoan]);
                    }
                }

                if (highestScore == -1)
                {
                    this.highestScore.Text = "--";
                }
                else
                {
                    this.highestScore.Text = highestScore.ToString();
                }

                this.lblAvaregeScore.Text = (numberOfStudentSubmit == 0) ? "--" : Math.Round((totalScore / numberOfStudentSubmit), 2).ToString();
                this.lblSubmitRadio.Text = (danhsachlop.Count == 0) ? "0%" : Math.Round(((float)this.listSubmited.Count / (danhsachlop.Count)) * 100, 2).ToString() + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString()); ;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lblTimKiem.Hide();
            if (txtTimKiem.Text.Length == 0)
                lblTimKiem.Show();
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void notSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                whichIsClick = 1;
                this.flowHocSinhPnl.Controls.Clear();
                if (this.listNotSubmited.Count == 0)
                {
                    EmptypnlBT emptPnl = new EmptypnlBT("Không có học sinh chưa nộp bài");
                    flowHocSinhPnl.Controls.Add(emptPnl);
                    return;
                }

                foreach (TaiKhoanDTO hocsinh in this.listNotSubmited)
                {
                    NopTre hsPnl = new NopTre(hocsinh);
                    this.flowHocSinhPnl.Controls.Add(hsPnl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi phát sinh, vui lòng thử lại sau !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void btnHomeworkDetail_Click(object sender, EventArgs e)
        {
            XemChiTietBaiTapfrm ctbtFrm = new XemChiTietBaiTapfrm(this.baitap);
            ctbtFrm.Show();
        }
    }
}

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
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien;
using QLLopHoc.GUI.KhoaHoc.BaiTap.SinhVien;

namespace QLLopHoc.GUI.KhoaHoc.BaiTap
{
    public partial class NopTre : UserControl
    {
        private TaiKhoanDTO taikhoan;
        private BaiTapDTO baitap;
        private BaiLamBaiTapDTO blbt;
        public NopTre()
        {
            InitializeComponent();
        }
        public NopTre(TaiKhoanDTO hocsinh)
        {
            InitializeComponent();
            this.taikhoan = hocsinh;
            this.lblHoten.Text = taikhoan.Hoten;
            this.btnChamDiem.Visible = false;
            this.lblState.Text = "Chưa nộp";
            System.Resources.ResourceManager rm = global::QLLopHoc.Properties.Resources.ResourceManager;
            this.avatar.BackgroundImage = (Image)rm.GetObject(this.taikhoan.Anhdaidien);
        }

        public NopTre(TaiKhoanDTO hocsinh, bool dacham, BaiTapDTO bt, BaiLamBaiTapDTO blbt)
        {
            InitializeComponent();
            this.taikhoan = hocsinh;
            this.blbt = blbt;
            this.baitap = bt;
            this.lblHoten.Text = hocsinh.Hoten;
            System.Resources.ResourceManager rm = global::QLLopHoc.Properties.Resources.ResourceManager;
            this.avatar.BackgroundImage = (Image)rm.GetObject(this.taikhoan.Anhdaidien);
            this.lblState.Text = "Nộp vào " + blbt.Thoigiannopbai.ToString("dd/MM/yyyy HH:mm:ss");
            this.btnChamDiem.Visible = !dacham;
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            if (blbt == null)
            {
                MessageBox.Show("Học sinh chưa nộp bài tập !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else if (blbt.Diem != -1)
            {
                XemBaiLamfrm xembailamFrm = new XemBaiLamfrm(this.taikhoan, this.baitap, this.blbt);
                xembailamFrm.Show();
            }
        }

        private void btnChamDiem_Click(object sender, EventArgs e)
        {

            ChamDiemfrm chamdiemFrm = new ChamDiemfrm(this.taikhoan, this.baitap, this.blbt);
            chamdiemFrm.Show();
        }
    }
}

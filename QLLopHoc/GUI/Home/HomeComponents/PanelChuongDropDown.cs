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
using ComponentFactory.Krypton.Toolkit;
using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc;
using QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien;
using QLLopHoc.GUI.KhoaHoc.KiemTra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.GUI.Home.HomeComponents
{
    public partial class PanelChuongDropDown : UserControl
    {
        private bool isExpanded = false;
        private int demTaiLieuChuong;
        ChuongDTO chuong;
        KhoaHocfrm khfrm;
        ChuongBUS chuongBUS = new ChuongBUS();
        DeKiemTraBUS dekiemtraBUS = new DeKiemTraBUS();
        HocLieuBUS hoclieuBUS = new HocLieuBUS();
        BaiTapBUS baitapBUS = new BaiTapBUS();

        public bool IsExpanded { get => isExpanded; set => isExpanded = value; }
        public int DemTaiLieuChuong { get => demTaiLieuChuong; set => demTaiLieuChuong = value; }
        public ChuongDTO Chuong { get => chuong; set => chuong = value; }
        public KhoaHocfrm Khfrm { get => khfrm; set => khfrm = value; }
       
       
        public PanelChuongDropDown(KhoaHocfrm khfrm, ChuongDTO chuong, int loaihoatdong = 0, string tukhoa = "")
        {
            InitializeComponent();
            this.chuong = chuong;
            this.khfrm = khfrm;
            if (!this.khfrm.Lophoc.Magiangvien.Equals(this.khfrm.Taikhoan.Mataikhoan) || khfrm.Lophoc.Daxoa == 1)
            {
                this.btnThem.Visible = false;
                this.btnSua.Visible = false;
                this.btnXoa.Visible = false;
            }
            this.kryptonContextMenuItem1.Click += ThemTaiLieuChuong;
            this.kryptonContextMenuItem2.Click += ThemTaiLieuChuong;
            this.kryptonContextMenuItem3.Click += ThemTaiLieuChuong;
            this.lblTenChuong.Text = chuong.Tenchuong;
            demTaiLieuChuong = 0;
            lblDemTaiLieuChuong.Text = "(0)";
            if (loaihoatdong == 0)
            {
                bool flagbaitap = HienThiDanhSachBaiTap(chuong.Machuong, tukhoa),
                     flagbaikiemtra = HienThiDanhSachBaiKT(chuong.Machuong, tukhoa),
                     flaghoclieu = HienThiDanhSachHocLieu(chuong.Machuong, tukhoa);
                if (tukhoa != "" && !flagbaitap)
                    this.Visible = false;
                else
                    this.Visible = true;
            }
            else if (loaihoatdong == 1)
            {
                if (!HienThiDanhSachBaiTap(chuong.Machuong, tukhoa))
                    this.Visible = false;
            }
            else if (loaihoatdong == 2)
            {
                if (!HienThiDanhSachBaiKT(chuong.Machuong, tukhoa))
                    this.Visible = false;
            }
            else if (loaihoatdong == 3)
            {
                if (!HienThiDanhSachHocLieu(chuong.Machuong, tukhoa))
                    this.Visible = false;
            }
        }

        public bool HienThiDanhSachBaiTap(string machuong, string tukhoa = "")
        {
            ArrayList listbt = baitapBUS.GetDanhSachBaiTapTheoMaChuong(machuong, tukhoa);
            if (baitapBUS.GetDanhSachBaiTapTheoMaChuong(machuong, tukhoa).Count == 0)
            {
                return false;
            }
            foreach (BaiTapDTO bt in listbt)
            {
                if (bt.Daxoa == 0)
                {
                    ButtonBaiTap btn = new ButtonBaiTap(this, bt);
                    this.pnlChuongComponent.Controls.Add(btn);
                    this.lblDemTaiLieuChuong.Text = "(" + ++demTaiLieuChuong + ")";
                }
            }
            return true;
        }
        public bool HienThiDanhSachHocLieu(string machuong, string tukhoa = "")
        {
            ArrayList listhl = hoclieuBUS.GetDanhSachHocLieuTheoMaChuong(machuong, tukhoa);
            if (hoclieuBUS.GetDanhSachHocLieuTheoMaChuong(machuong, tukhoa).Count == 0)
            {
                return false;
            }
            foreach (HocLieuDTO hl in listhl)
            {
                if (hl.Daxoa == 0)
                {
                    ButtonHocLieu btn = new ButtonHocLieu(this, hl);
                    this.pnlChuongComponent.Controls.Add(btn);
                    this.lblDemTaiLieuChuong.Text = "(" + ++demTaiLieuChuong + ")";
                }
            }
            return true;
        }
        public bool HienThiDanhSachBaiKT(string machuong, string tukhoa = "")
        {
            ArrayList listbkt = dekiemtraBUS.GetDanhSachDeKiemTraTheoMaChuong(machuong, tukhoa);
            if (dekiemtraBUS.GetDanhSachDeKiemTraTheoMaChuong(machuong, tukhoa).Count == 0)
            {
                return false;
            }
            foreach (DeKiemTraDTO dkt in listbkt)
            {
                if (dkt.Daxoa == 0)
                {
                    ButtonBaiKTra btn = new ButtonBaiKTra(this, dkt);
                    this.pnlChuongComponent.Controls.Add(btn);
                    this.lblDemTaiLieuChuong.Text = "(" + ++demTaiLieuChuong + ")";
                }
            }
            return true;
        }

        private void ThemTaiLieuChuong(object sender, System.EventArgs e)
        {
            switch ((sender as KryptonContextMenuItem).Text)
            {
                case "Bài tập":
                    TaoBaiTapfrm taobtFrm = new TaoBaiTapfrm(this, this.khfrm.Taikhoan, this.khfrm.Lophoc, this.chuong);
                    taobtFrm.ShowDialog();
                    break;
                case "Bài kiểm tra":
                    KiemTrafrm ktfrm = new KiemTrafrm(this);
                    ktfrm.ShowDialog();
                    break;
                case "Học liệu":
                    TaoTaiLieufrm tlfrm = new TaoTaiLieufrm(this);
                    tlfrm.ShowDialog();
                    break;
            }
            /*isExpanded = false;
            btnMoRong_Click(this, EventArgs.Empty);
            demTaiLieuChuong++;
            this.lblDemTaiLieuChuong.Text = "(" + demTaiLieuChuong + ")";*/
        }

        public void XoaChuongComponent(UserControl button)
        {
            if (this.pnlChuongComponent.Controls.Count <= 1)
            {
                isExpanded = true;
                btnMoRong_Click(this, EventArgs.Empty);
            }
            this.pnlChuongComponent.Controls.Remove(button);
            demTaiLieuChuong--;
            this.lblDemTaiLieuChuong.Text = "(" + demTaiLieuChuong + ")";
        }

        public void btnMoRong_Click(object sender, EventArgs e)
        {
            timerHieuUngDropDown.Start();
        }

        public void btnThem_Click(object sender, EventArgs e)
        {
            menuThem.Show(btnThem);
        }

        private void timerHieuUngDropDown_Tick(object sender, EventArgs e)
        {
            if (this.pnlChuongComponent.Controls.Count <= 0) return;
            if (isExpanded)
            {
                while (this.Height != 65)
                    this.Height -= 5;
                isExpanded = false;
                btnMoRong.Text = "▼";
                timerHieuUngDropDown.Stop();
            }
            else
            {
                while (this.Height != 250)
                    this.Height += 5;
                isExpanded = true;
                btnMoRong.Text = "▲";
                timerHieuUngDropDown.Stop();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Xác nhận xóa chương?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ds == DialogResult.Yes)
            {
                if (chuongBUS.XoaChuong(chuong))
                {
                    this.Khfrm.PnlChuongContainer.Controls.Remove(this);
                    MessageBox.Show("Xóa chương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa chương thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new ThemChuongfrm(chuong, this.khfrm).ShowDialog();
        }
    }
}

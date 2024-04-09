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
using QLLopHoc.GUI.Home.HomeComponents;
using QLLopHoc.GUI.KhoaHoc;

namespace QLLopHoc.GUI.Home
{
    public partial class ThongTinLopHocfrm : Form
    {
        DataTable dt = new DataTable();
        LopHocDTO lophoc;
        TaiKhoanDTO taiKhoan;
        PanelGiaoDienLopHoc pnlgdlh;
        string tenlop;
        string mota;

        ThamGiaBUS tgBUS = new ThamGiaBUS();
        TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
        LopHocBUS lophocBUS = new LopHocBUS();
        public static string tenhinh = null;

        public ThongTinLopHocfrm(TaiKhoanDTO taikhoan, PanelGiaoDienLopHoc panel)
        {
            InitializeComponent();
            this.pnlgdlh = panel;
            this.lophoc = panel.Lophoc;
            this.taiKhoan = taikhoan;

            // Hien thi len giao dien
            this.txtTenLop.Text = lophoc.Tenlop;
            this.tenlop = lophoc.Tenlop;
            this.mota = lophoc.Mota;
            this.txtMaLop.Text = lophoc.Malop;
            this.rtbNoiDung.Text = lophoc.Mota;
            this.btnRoiLop.Visible = false;
            this.btnXoaLop.Visible = true;
            this.lblTenGiaoVien.Text = taikhoanBUS.List[taikhoanBUS.GetTaiKhoanByMaTaiKhoan(lophoc.Magiangvien)].Hoten;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaLop.Text);
            MessageBox.Show("Đã chép vào bộ nhớ tạm thời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            new HienThiMaLopHocfrm(lophoc.Malop).ShowDialog();
        }
    }
}

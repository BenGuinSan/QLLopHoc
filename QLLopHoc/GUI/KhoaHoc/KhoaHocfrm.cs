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

namespace QLLopHoc.GUI.KhoaHoc
{
    public partial class KhoaHocfrm : Form
    {
        LopHocDTO lophoc;
        TaiKhoanDTO taikhoan;
        ChuongBUS chuongBUS = new ChuongBUS();


        public LopHocDTO Lophoc { get => lophoc; set => lophoc = value; }
        //public ChuongBUS ChuongBUS { get => chuongBUS; set => chuongBUS = value; }
        public TaiKhoanDTO Taikhoan { get => taikhoan; set => taikhoan = value; }

        public KhoaHocfrm(LopHocDTO lophoc, TaiKhoanDTO taikhoan)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.taikhoan = taikhoan;
            hienThiDanhSachChuong();

            // neu la giang vien thi hien nut tao chuong
            if (!lophoc.Magiangvien.Equals(taikhoan.Mataikhoan))
                btnTaoMuc.Visible = false;
            if (lophoc.Daxoa == 1)
                this.btnTaoMuc.Visible = false;
        }

        public void hienThiDanhSachChuong()
        {
            this.pnlChuongContainer.Controls.Clear();
            foreach (ChuongDTO chuong in chuongBUS.getChuongWithMaLop(lophoc.Malop).Cast<ChuongDTO>().OrderBy(item => item.Thoigiantao))
            {
                if (chuong.Daxoa == 0)
                {
                    PanelChuongDropDown pnlChuong = new PanelChuongDropDown(this, chuong);
                    this.pnlChuongContainer.Controls.Add(pnlChuong);
                }
            }
        }

        private void btnTaoMuc_Click(object sender, EventArgs e)
        {
            ThemChuongfrm newForm = new ThemChuongfrm(this);
            newForm.ShowDialog();
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm theo tiêu đề hoạt động")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm theo tiêu đề hoạt động";
                txtTimKiem.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm theo tiêu đề hoạt động";
            cbLoaiHoatDong.SelectedIndex = 0;
            hienThiDanhSachChuong();
        }

    }
}

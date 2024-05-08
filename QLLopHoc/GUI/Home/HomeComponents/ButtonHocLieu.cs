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
using QLLopHoc.GUI.KhoaHoc.TaiLieu;


namespace QLLopHoc.GUI.Home.HomeComponents
{
    public partial class ButtonHocLieu : UserControl
    {
        PanelChuongDropDown panelChuong;
        HocLieuDTO hoclieu;
        HocLieuBUS hoclieuBUS = new HocLieuBUS();


        public PanelChuongDropDown PanelChuong { get => panelChuong; set => panelChuong = value; }
        public HocLieuDTO Hoclieu { get => hoclieu; set => hoclieu = value; }

        public ButtonHocLieu(PanelChuongDropDown panelChuong, HocLieuDTO hoclieu)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.hoclieu = hoclieu;
            this.lblTieuDeHocLieu.Text = hoclieu.Tieude;
            this.lblChiTietHocLieu.Text = hoclieu.Thoigiantao.ToString();
        }

        private void btnHocLieu_Click(object sender, EventArgs e)
        {
            HienThiTaiLieufrm htfrm = new HienThiTaiLieufrm(this);
            htfrm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận xóa tài liệu ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            this.hoclieuBUS.DeleteHocLieuByChangeState(this.hoclieu.Mahoclieu);
            panelChuong.XoaChuongComponent(this);
        }
    }
}

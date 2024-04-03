using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Chatbox;
using QLLopHoc.GUI.KhoaHoc;

namespace QLLopHoc.GUI.Home.HomeComponents
{
    public partial class PanelGiaoDienLopHoc : UserControl
    {
        LopHocDTO lophoc;
        Homefrm homefrm;
        TaiKhoanDTO taikhoan;

        public Homefrm Homefrm { get => homefrm; set => homefrm = value; }
        public LopHocDTO Lophoc { get => lophoc; set => lophoc = value; }

        public PanelGiaoDienLopHoc(LopHocDTO lophoc, Homefrm homefrm)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.homefrm = homefrm;
            this.taikhoan = homefrm.Tk;
            this.lblTenLop.Text = lophoc.Tenlop;
            this.homefrm = homefrm;
            if (lophoc.Daxoa == 1)
                this.btnChinhSuaLopHoc.Visible = false;
            btnChat_Click(this, EventArgs.Empty);
        }

        private void addFormtoPanelHomeContainer(object Form)
        {
            if (this.pnlHomeContainer.Controls.Count > 0)
            {
                //Form frm = this.pnlHomeContainer.Controls[0] as Form;
                //frm.Close();
                this.pnlHomeContainer.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlHomeContainer.Controls.Add(f);
            this.pnlHomeContainer.Tag = f;
            f.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new Chatboxfrm(this, this.lophoc, this.taikhoan));
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            addFormtoPanelHomeContainer(new KhoaHocfrm(this.lophoc, taikhoan));
        }

        private void btnThanhTich_Click(object sender, EventArgs e)
        {

        }

        private void btnChinhSuaLopHoc_Click(object sender, EventArgs e)
        {
            ThongTinLopHocfrm thongtinfrm = new ThongTinLopHocfrm(taikhoan, this);
            thongtinfrm.ShowDialog();
        }
    }
}

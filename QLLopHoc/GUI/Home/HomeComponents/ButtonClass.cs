using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Home;
using QLLopHoc.GUI.Home.HomeComponents;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLLopHoc.GUI.Home
{ 
    public partial class ButtonClass : UserControl
    {
        LopHocDTO lophoc;
        //DropDownGiangDay giangday; 
        Homefrm homefrm;
        //Chucnang cn = new Chucnang();
        //TinNhanNhomChatBUS tnncBUS = new TinNhanNhomChatBUS();
        public ButtonClass(LopHocDTO lophoc, Homefrm homefrm)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            //this.giangday = giangday;
            this.homefrm = homefrm;
            this.lblTenLop.Text = lophoc.Tenlop;
            System.Resources.ResourceManager rm = QLLopHoc.Properties.Resources.ResourceManager;
            pictureBox1.Image = (Image)rm.GetObject(this.lophoc.Avatar);
            if (lophoc.Daxoa == 1)
            {
                this.btnLopHoc.StateCommon.Back.Color1 = Color.LightGray;
                this.btnLopHoc.StateCommon.Back.Color2 = Color.LightGray;
                this.btnLopHoc.OverrideDefault.Back.Color1 = Color.LightGray;
                this.btnLopHoc.OverrideDefault.Back.Color2 = Color.LightGray;
                this.lblTenLop.BackColor = Color.LightGray;
                this.lblChiTiet.BackColor = Color.LightGray;
                this.lblChiTiet.Text = "Lớp học đã giải tán";
            }

            /*if (tnncBUS.getLatest(lophoc.Malop.ToUpper()) != null)
            {
                TinNhanNhomChat tmp = tnncBUS.getLatest(lophoc.Malop.ToUpper());
                lblChiTiet.Text = tmp.Noidung;
                lbl_time_latest.Text = tmp.Thoigiangui.ToString("HH:mm");
            }*/
            else
            {
                lblChiTiet.Text = "";
                lbl_time_latest.Text = "";
            }

        }


        public LopHocDTO Lophoc { get => lophoc; set => lophoc = value; }

        public void btnLopHocClick()
        {
            if (this.homefrm.PnlGiaoDienLopHocContainer.Controls.Count > 0)
                this.homefrm.PnlGiaoDienLopHocContainer.Controls.RemoveAt(0);
            PanelGiaoDienLopHoc panelGDLH = new PanelGiaoDienLopHoc(this.lophoc, homefrm);
            this.homefrm.PnlGiaoDienLopHocContainer.Controls.Add(panelGDLH);
            panelGDLH.Dock = DockStyle.Fill;
            
        }

        public void setLatestMess(string mess, string time)
        {
            lblChiTiet.Text = mess;
            lbl_time_latest.Text = time;
        }

        public string getButtonClassMaLop()
        {
            return this.lophoc.Malop;
        }

        private void btnLopHoc_Click_1(object sender, EventArgs e)
        {
            btnLopHocClick();
        }

        private void lblTenLop_Click_1(object sender, EventArgs e)
        {
            btnLopHocClick();
        }

        private void lblChiTiet_Click_1(object sender, EventArgs e)
        {
            btnLopHocClick();
        }
    }
}

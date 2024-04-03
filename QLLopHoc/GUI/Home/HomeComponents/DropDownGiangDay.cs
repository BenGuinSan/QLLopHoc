using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;

namespace QLLopHoc.GUI.Home.HomeComponents
{
    public partial class DropDownGiangDay : UserControl
    {
        private Form1 form;   
        private TaiKhoanDTO tk;
        private LopHocBUS lophocBUS = new LopHocBUS();

        public TaiKhoanDTO Tk { get => tk; set => tk = value; }
        public LopHocBUS LophocBUS { get => lophocBUS; set => lophocBUS = value; }

        private bool isExpanded = false;

        public DropDownGiangDay(Form1 frm)
        {
            InitializeComponent();
            this.form = frm;
            this.tk = frm.Tk;
            //HienThiDanhSachLopHocGiangDay(lophocBUS.GetDanhSachLopHocGiangDayByMaTaiKhoan(tk.Mataikhoan));
            
        }

        private void timerHieuUngDropDown_Tick(object sender, EventArgs e)
        {
            if (this.pnlGiangDayComponent.Controls.Count <= 0) return;
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

        /*public bool HienThiDanhSachLopHocGiangDay(ArrayList list)
        {
            foreach (LopHoc lophoc in list)
            {
                
                ButtonClass btnClass = new ButtonClass(lophoc, this);
                this.pnlGiangDayComponent.Controls.Add(btnClass);
                
            }
            return true;
        }*/

        private void btnMoRong_Click_2(object sender, EventArgs e)
        {
            timerHieuUngDropDown.Start();
        }
    }
}

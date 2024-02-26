using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using QLLopHoc.GUI.Home;
using QLLopHoc.GUI.Todo;

namespace QLLopHoc
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
  

        public Form1()
        {
            InitializeComponent();

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Controls.Add(this.btnExit);
            f.Controls.Add(this.btnMinimize);
            this.btnExit.BringToFront();
            this.btnMinimize.BringToFront();
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Homefrm(this));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Todofrm(this));
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}

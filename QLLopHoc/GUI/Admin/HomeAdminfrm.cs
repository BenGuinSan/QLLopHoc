using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc.GUI.Admin
{
    public partial class HomeAdminfrm : Form
    {
        bool sidebarExpand;
        public HomeAdminfrm()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.adminpanel.Controls.Count > 0)
                this.adminpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Controls.Add(this.btnExit);
            f.Controls.Add(this.btnMinimize);
            this.btnExit.BringToFront();
            this.btnMinimize.BringToFront();
            this.adminpanel.Controls.Add(f);
            this.adminpanel.Tag = f;
            f.Show();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Accountfrm(this));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Classfrm(this));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

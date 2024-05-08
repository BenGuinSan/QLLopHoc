using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QLLopHoc.GUI.Admin
{
    public partial class HomeAdminfrm : Form
    {
        private IconButton currentBtn;
        bool sidebarExpand;
        public HomeAdminfrm()
        {
            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(253, 138, 114);
        }


        // ham xu ly khi click btn tren menu
        private void activeButton(object sender, Color color)
        {

            if(sender != null)
            {
                disableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
             
                currentBtn.IconColor = color;
            }

        }

        private void disableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(58, 59, 69);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }

        public void loadform(object Form)
        {
            if (this.adminpanel.Controls.Count > 0)
                this.adminpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            //f.Controls.Add(this.btnExit);
            //f.Controls.Add(this.btnMinimize);
            //this.btnExit.BringToFront();
            //this.btnMinimize.BringToFront();
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


        private void iconButton1_Click(object sender, EventArgs e)
        {
            activeButton(sender, RGBColors.color1);
            loadform(new Accountfrm(this));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            activeButton(sender, RGBColors.color2);
            loadform(new Classfrm(this));
        }

        private void HomeAdminfrm_Load(object sender, EventArgs e)
        {
            btnAccount.PerformClick();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
     
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

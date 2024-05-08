using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLLopHoc.GUI.Home;
using QLLopHoc.GUI.Todo;
using QLLopHoc.DTO;
using QLLopHoc.BUS;

namespace QLLopHoc
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        private IconButton currentBtn;
        private LopHocBUS lopBUS;
        private TaiKhoanDTO tk;
        private BaiTapBUS btBUS;
        private DeKiemTraBUS dktBUS;
        private BaiLamBaiTapBUS blbtBUS;
        private BaiLamKiemTraBUS blktBUS;
        private ChuongBUS chuongBUS;
        TaiKhoanBUS taikhoanBUS;
        ChucnangBUS cn = new ChucnangBUS();

        public TaiKhoanDTO Tk { get => tk; set => tk = value; }


        public Form1(TaiKhoanDTO tk)
        {
            InitializeComponent();
            this.tk = tk;
            lopBUS = new LopHocBUS();
            dktBUS = new DeKiemTraBUS();
            btBUS = new BaiTapBUS();
            taikhoanBUS = new TaiKhoanBUS();
            blbtBUS = new BaiLamBaiTapBUS();
            blktBUS = new BaiLamKiemTraBUS();




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

            if (sender != null)
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
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(58, 59, 69);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }


        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            //f.Controls.Add(this.btnExit);
            //f.Controls.Add(this.btnMinimize);
            //this.btnExit.BringToFront();
            //this.btnMinimize.BringToFront();
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            cn.loadggdrive();
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

        public void addFormtoPanelContainer(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }


        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            activeButton(sender, RGBColors.color1);
            loadform(new Homefrm(this));
        }

        private void btnTodo_Click_1(object sender, EventArgs e)
        {
            activeButton(sender, RGBColors.color2);
            loadform(new Todofrm(this.tk, this.btBUS, this.lopBUS, this.dktBUS, this.chuongBUS, this.blbtBUS, this.blktBUS));
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

     
        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc.GUI.DangNhap
{
    public partial class Signinfrm : Form
    {
        public Signinfrm()
        {
            InitializeComponent();
        }

        private void Signinfrm_Load(object sender, EventArgs e)
        {

        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = string.Empty;
            }
            txt_email.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void txt_matkhau_Enter(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "Mật khẩu")
            {
                txt_matkhau.Text = string.Empty;
            }
            txt_matkhau.ForeColor = System.Drawing.Color.Black;
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                txt_matkhau.Text = "Mật khẩu";
                txt_matkhau.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void btnHideMK_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            btnShowMK.Visible = true;
            btnHideMK.Visible = false;
        }

        private void btnShowMK_Click(object sender, EventArgs e)
        {
            if (txt_matkhau.Text != "Mật khẩu")
            {
                txt_matkhau.PasswordChar = '\0';
                btnShowMK.Visible = false;
                btnHideMK.Visible = true;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using QLLopHoc.DAO;

namespace QLLopHoc.GUI.DangNhap
{
    public partial class Signupfrm : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public Signupfrm()
        {
            InitializeComponent();
        }
        private void Signupfrm_Load(object sender, EventArgs e)
        {

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

        private void btnHideMK_Click(object sender, EventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
            btnShowMK.Visible = true;
            btnHideMK.Visible = false;
        }

        private void btnShowMK2_Click(object sender, EventArgs e)
        {
            if (txt_nhaplaimk.Text != "Xác nhận mật khẩu")
            {
                txt_nhaplaimk.PasswordChar = '\0';
                btnShowMK2.Visible = false;
                btnHideMK2.Visible = true;
            }
        }

        private void btnHideMK2_Click(object sender, EventArgs e)
        {
            txt_nhaplaimk.PasswordChar = '*';
            btnShowMK2.Visible = true;
            btnHideMK2.Visible = false;
        }

        private void btn_qldangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signinfrm signinfrm = new Signinfrm();
            signinfrm.ShowDialog();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if(txt_email.Text == "Email")
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
            if(txt_matkhau.Text == "Mật khẩu")
            {
                txt_matkhau.Text = string.Empty;
                txt_matkhau.PasswordChar = '*';
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
        private void txt_nhaplaimk_Enter(object sender, EventArgs e)
        {
            if (txt_nhaplaimk.Text == "Xác nhận mật khẩu")
            {
                txt_nhaplaimk.Text = string.Empty;
                txt_nhaplaimk.PasswordChar = '*';
            }
            txt_nhaplaimk.ForeColor = System.Drawing.Color.Black;
        }
        private void txt_nhaplaimk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nhaplaimk.Text))
            {
                txt_nhaplaimk.Text = "Xác nhận mật khẩu";
                txt_nhaplaimk.ForeColor = System.Drawing.Color.Silver;
            }
        }
        private void btn_xndangky_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_matkhau.Text;
            string repassword = txt_nhaplaimk.Text;

            if (email.Length == 0 || password.Length == 0 || repassword.Length == 0)
            {
                MessageBox.Show("Không được bỏ trống bất kì trường thông tin nào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (tkBUS.kt_email(email))
                {
                    if(tkBUS.check_matkhau(password) || tkBUS.check_matkhau(repassword)) 
                    {
                        if(password == repassword)
                        {
                            if(tkBUS.kt_taikhoan_tontai(email))
                            {
                                MessageBox.Show("Email bạn đăng ký đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else
                            {
                                tkBUS.tao_taikhoan(email, password);
                                email = "Email";
                                txt_email.ForeColor = System.Drawing.Color.Silver;
                                password = "Mật khẩu";
                                txt_matkhau.ForeColor = System.Drawing.Color.Silver;
                                repassword = "Xác nhận mật khẩu";
                                txt_nhaplaimk.ForeColor = System.Drawing.Color.Silver;

                                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else
                    {
                        MessageBox.Show("Định dạng mật khẩu hoặc xác nhận mật khẩu không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Định dạng email không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

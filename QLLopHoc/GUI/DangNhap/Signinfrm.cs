using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using QLLopHoc.BUS;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Admin;

namespace QLLopHoc.GUI.DangNhap
{
    public partial class Signinfrm : Form
    {
        TaiKhoanDAO taikhoanDAO = new TaiKhoanDAO();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
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
            string email = txt_email.Text;
            string password = txt_matkhau.Text;
            if(email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Email hoặc mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (taiKhoanBUS.kt_email(email))
                {
                    if (taiKhoanBUS.kt_taikhoan_tontai(email))
                    {
                        if (taiKhoanBUS.kt_daxoa_taikhoan(email) == 0)
                        {
                            if(taikhoanDAO.check_taikhoan(email, password))
                            {
                                if (taiKhoanBUS.kt_quyenhan_taikhoan(email) == 1)
                                {
                                    this.Hide();
                                    HomeAdminfrm homefrm = new HomeAdminfrm();
                                    homefrm.ShowDialog();
                                } else
                                {
                                    TaiKhoanDTO tk1 = taiKhoanBUS.GetTaiKhoanByEmail(email);
                                    this.Hide();
                                    Form1 mainfr = new Form1(tk1);
                                    mainfr.Show();
                                }
                            } else
                            {
                                MessageBox.Show("Sai mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }   
                        } else
                        {
                            MessageBox.Show("Email đã bị ban khỏi phần mềm Hybrid do bị quá nhiều report từ các người dùng khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }else
                    {
                        MessageBox.Show("Email này chưa được đăng ký trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }   
                }else
                {
                    MessageBox.Show("Email không hợp lệ hoặc không đúng định dạng cơ bản\nVD:abc@gmail.com", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signupfrm signupfrm = new Signupfrm();
            signupfrm.ShowDialog();
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using QLLopHoc.DTO;

namespace QLLopHoc.GUI.Home
{
    public partial class TaoLopfrm : Form
    {
        private Homefrm homefrm;
        private LopHocBUS lophocBUS;
        private NhomChatBUS nhomchatBUS;
        public static string tenhinh = "imglop1";


        public TaoLopfrm(Homefrm homefrm)
        {
            InitializeComponent();
            this.homefrm = homefrm;
            lophocBUS = new LopHocBUS();
            nhomchatBUS = new NhomChatBUS();
        }

        private void txtTenLop_Enter(object sender, EventArgs e)
        {
            if(txtTenLop.Text == "Vui lòng điền tên lớp(trong vòng 50 ký tự)")
            {
                txtTenLop.Text = "";
                txtTenLop.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtTenLop_Leave(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "")
            {
                txtTenLop.Text = "Vui lòng điền tên lớp(trong vòng 50 ký tự)";
                txtTenLop.ForeColor = SystemColors.Control;
            }
        }

        private void btnTaoLop_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng lớp học mới khi mà bấm tạo lớp
            LopHocDTO lophoc = new LopHocDTO(Guid.NewGuid().ToString(), txtTenLop.Text, "",tenhinh, homefrm.Tk.Mataikhoan, 0);
            // Tạo nhóm chát mới dựa vào lớp học mới tạo
            NhomChatDTO nhomchat = new NhomChatDTO(Guid.NewGuid().ToString(), txtTenLop.Text, lophoc.Malop);
            if(txtTenLop.Text.Length == 0 || txtTenLop.Text == "Vui lòng điền tên lớp(trong vòng 50 ký tự)")
            {
                MessageBox.Show("Tên Lớp Học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }
            if (lophocBUS.themlop(lophoc) && nhomchatBUS.ThemNhomChat(nhomchat))
            {
                // Nếu tạo lớp thành công thì tạo mới 1 đối tượng buttonclass
                ButtonClass buttonClass = new ButtonClass(lophoc, this.homefrm);
                this.homefrm.PnlLopHocContainer.Controls.Add(buttonClass);
                MessageBox.Show("Tạo Lớp Học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo Lớp Học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

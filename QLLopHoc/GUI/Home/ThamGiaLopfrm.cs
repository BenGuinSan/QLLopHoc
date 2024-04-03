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
using QLLopHoc.GUI.Home.HomeComponents;

namespace QLLopHoc.GUI.Home
{
    public partial class ThamGiaLopfrm : Form
    {
        Homefrm homefrm;
        LopHocBUS lophocBUS = new LopHocBUS();
        ThamGiaBUS thamgiaBUS = new ThamGiaBUS();

        public ThamGiaLopfrm(Homefrm homefrm)
        {
            InitializeComponent();
            this.homefrm = homefrm;
        }

        private void txtMaLop_Enter(object sender, EventArgs e)
        {
            if(txtMaLop.Text == "Vui lòng điền mã lớp học")
            {
                txtMaLop.Text = "";
                txtMaLop.ForeColor = SystemColors.Control;
            }
        }

        private void txtMaLop_Leave(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                txtMaLop.Text = "Vui lòng điền mã lớp học";
                txtMaLop.ForeColor = SystemColors.Control;
            }
        }

        private void btnThamGiaLop_Click(object sender, EventArgs e)
        {
            if(txtMaLop.Text.Length == 0 || txtMaLop.Text == "Vui lòng điền mã lớp học")
            {
                MessageBox.Show("Mã Lớp Học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            // Lấy ra lophocthamgia trùng với mã lớp học được nhập vào
            LopHocDTO lophocthamgia = lophocBUS.getLopHocByMaLop(txtMaLop.Text);

            // Kiểm tra nếu không có lớp học trùng với mã lớp học nhập vào
            if(lophocthamgia == null)
            {
                MessageBox.Show("Lớp học không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            // Kiểm tra lớp học muốn tham gia có mã giảng viên trùng với tài khoản đang tham gia hay không
            if (lophocthamgia.Magiangvien.Equals(this.homefrm.Tk.Mataikhoan))
            {
                MessageBox.Show("Bạn đang là giảng viên của lớp này rồi!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            // Tạo một đối tượng tham gia mới với 2 tham số mã lớp học nhập vào, mã tài khoản đang đăng nhập ở form
            ThamGiaDTO thamgia = new ThamGiaDTO(txtMaLop.Text, this.homefrm.Tk.Mataikhoan);
            // Kiểm tra đã tham gia lớp học đó chưa
            if (thamgiaBUS.KtraDaThamGia(thamgia))
            {
                if (this.homefrm.PnlGiaoDienLopHocContainer.Controls.Count > 0)
                    this.homefrm.PnlGiaoDienLopHocContainer.Controls.RemoveAt(0);
                PanelGiaoDienLopHoc panelGDLH = new PanelGiaoDienLopHoc(lophocthamgia, homefrm);
                this.homefrm.PnlGiaoDienLopHocContainer.Controls.Add(panelGDLH);
                panelGDLH.Dock = DockStyle.Fill;
                this.Close();
                return;
            }
            // Thêm tham gia lớp học
            if (thamgiaBUS.ThemThamGia(thamgia))
            {
                if (this.homefrm.PnlGiaoDienLopHocContainer.Controls.Count > 0)
                    this.homefrm.PnlGiaoDienLopHocContainer.Controls.RemoveAt(0);
                PanelGiaoDienLopHoc panelGDLH = new PanelGiaoDienLopHoc(lophocthamgia, homefrm);
                this.homefrm.PnlGiaoDienLopHocContainer.Controls.Add(panelGDLH);
                panelGDLH.Dock = DockStyle.Fill;

                ButtonClass btn = new ButtonClass(lophocthamgia, this.homefrm);
                this.homefrm.PnlLopHocContainer.Controls.Add(btn);
                MessageBox.Show("Tham gia lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Tham gia lớp học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections;
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
using QLLopHoc.GUI.Home;
using QLLopHoc.GUI.Home.HomeComponents;

namespace QLLopHoc.GUI.Home
{
    public partial class Homefrm : Form
    {
        private Form1 form;
        private TaiKhoanDTO tk;
        private LopHocBUS lophocBUS = new LopHocBUS();

        public TaiKhoanDTO Tk { get => tk; set => tk = value; }
        public LopHocBUS LophocBUS { get => lophocBUS; set => lophocBUS = value; }
        public Form1 Form { get => form; set => form = value; }

        
  

        public Homefrm(Form1 frm)
        {
            InitializeComponent();
            this.form = frm;
            this.tk = frm.Tk;

            HienThiDanhSachLopHoc(lophocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(tk.Mataikhoan));
     
            //HienThiDanhSachLopHocThamGia(lophocBUS.GetDanhSachLopHocGiangDayByMaTaiKhoan(tk.Mataikhoan));

        }

        private void btnThamGia_Click(object sender, EventArgs e)
        {
            ThamGiaLopfrm thamgia = new ThamGiaLopfrm(this);
            thamgia.ShowDialog();
        }

        private void btnTaoLop_Click(object sender, EventArgs e)
        {
            TaoLopfrm taolop = new TaoLopfrm(this);
            taolop.ShowDialog();
        }

        public void HienThiDanhSachLopHoc(ArrayList list)
        {
            pnlLopHocContainer.Controls.Clear();
            foreach (LopHocDTO lophoc in list)
            {
                ButtonClass btnClass = new ButtonClass(lophoc, this);
                pnlLopHocContainer.Controls.Add(btnClass);
            }

        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "Tìm kiếm tên lớp học")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm tên lớp học";
                txtTimKiem.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ArrayList searchList = new ArrayList();
            if (txtTimKiem.Text == "Tìm kiếm tên lớp học") return;
            if (txtTimKiem.Text.Trim() == " ") return;
            // Loc qua toan bo danh sach lop hoc ma tai khoan co ma tai khoan dang dang nhap tham gia
            foreach(LopHocDTO lophoc in lophocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(tk.Mataikhoan))
            {
                // Neu co lop nhap vao trung voi thuoc tinh "Tenlop" thi bo cac lop do vao 1 danh sach 
                if (lophoc.Tenlop.ToLower().Contains(txtTimKiem.Text.Trim().ToLower()))
                {
                    searchList.Add(lophoc);
                }   
            }
            HienThiDanhSachLopHoc(searchList);
        }

        /*public void HienThiDanhSachLopHocGiangDay(ArrayList list)
        {
     
            pnlLopHocContainer.Controls.Clear();
            DropDownGiangDay giangday = new DropDownGiangDay(form);
            pnlLopHocContainer.Controls.Add(giangday);
           
        }*/

        /*public void HienThiDanhSachLopHocThamGia(ArrayList list)
        {
            pnlLopHocContainer.Controls.Clear();
            DropDownThamGia thamgia = new DropDownThamGia(form);
            pnlLopHocContainer.Controls.Add(thamgia);
        }*/

    }
}

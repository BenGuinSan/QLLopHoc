using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Home.HomeComponents;

namespace QLLopHoc.GUI.KhoaHoc
{
    public partial class KhoaHocfrm : Form
    {
        LopHocDTO lophoc;
        TaiKhoanDTO taikhoan;


        public LopHocDTO Lophoc { get => lophoc; set => lophoc = value; }
        //public ChuongBUS ChuongBUS { get => chuongBUS; set => chuongBUS = value; }
        public TaiKhoanDTO Taikhoan { get => taikhoan; set => taikhoan = value; }

        public KhoaHocfrm(LopHocDTO lophoc, TaiKhoanDTO taikhoan)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            this.taikhoan = taikhoan;


            //if (!lophoc.Magiangvien.Equals(taikhoan.Mataikhoan))
                //btnTaoMuc.Visible = false;
            //if (lophoc.Daxoa == 1)
                //this.btnTaoMuc.Visible = false;

        }
    }
}

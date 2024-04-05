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

namespace QLLopHoc.GUI.KhoaHoc
{
    public partial class ThanhTichSVfrm : Form
    {
        TaiKhoanDTO taikhoan;
        LopHocDTO lophoc;
        public ThanhTichSVfrm(LopHocDTO lophoc, TaiKhoanDTO taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.lophoc = lophoc;
        }
    }
}

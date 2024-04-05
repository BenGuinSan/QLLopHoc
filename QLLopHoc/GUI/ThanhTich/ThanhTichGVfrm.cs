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
    public partial class ThanhTichGVfrm : Form
    {
        LopHocDTO lophoc;
        public ThanhTichGVfrm(LopHocDTO lophoc)
        {
            InitializeComponent();
            this.lophoc = lophoc;
            if (lophoc.Daxoa == 1)
                this.btnXuatExcel.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

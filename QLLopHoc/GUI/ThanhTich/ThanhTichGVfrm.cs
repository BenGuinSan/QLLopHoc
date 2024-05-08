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

namespace QLLopHoc.GUI.KhoaHoc
{
    public partial class ThanhTichGVfrm : Form
    {
        LopHocDTO lophoc;
        DeKiemTraBUS dktBUS = new DeKiemTraBUS();
        BaiTapBUS btBUS = new BaiTapBUS();
        ChuongBUS chuongBUS = new ChuongBUS();
        BaiLamKiemTraBUS blktBUS = new BaiLamKiemTraBUS();
        BaiLamBaiTapBUS blbtBUS = new BaiLamBaiTapBUS();
        ThamGiaBUS tgbus = new ThamGiaBUS();
        TaiKhoanBUS tkbus = new TaiKhoanBUS();
        Dictionary<string, string> chuongDict = new Dictionary<string, string>();
        Dictionary<string, string> dekiemtraDict;
        Dictionary<string, string> baitapDict;
        DataTable dt = new DataTable();

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

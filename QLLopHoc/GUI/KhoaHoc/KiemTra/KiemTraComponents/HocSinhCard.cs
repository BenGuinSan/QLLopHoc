using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    public partial class HocSinhCard : UserControl
    {
        private TaiKhoanDTO hocsinh;
        private DeKiemTraDTO dekiemtra;
        private bool daNop;
        public HocSinhCard()
        {
            InitializeComponent();
        }
        public HocSinhCard(TaiKhoanDTO hs, DeKiemTraDTO dkt, bool daNop, BaiLamKiemTraBUS blktBUS)
        {
            InitializeComponent();
            this.hocsinh = hs;
            this.dekiemtra = dkt;
            this.daNop = daNop;
            if (daNop)
            {
                int indexBaiLam = blktBUS.getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(this.hocsinh.Mataikhoan, dekiemtra.Madekiemtra);
                this.lblSubmitAt.Text = "Nộp vào " + (blktBUS.List[indexBaiLam] as BaiLamKiemTra).Thoigiannop.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
                this.lblSubmitAt.Text = "Chưa nộp";
            loadDataIntoForm();
        }

        private void loadDataIntoForm()
        {
            this.Name.Text = this.hocsinh.Hoten;
            System.Resources.ResourceManager rm = global::QLLopHoc.Properties.Resources.ResourceManager;
            this.avatar.BackgroundImage = (Image)rm.GetObject(this.hocsinh.Anhdaidien);
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (daNop)
                {
                    XemBaiLamHocSinhfrm bailamhocsinhFrm = new XemBaiLamHocSinhfrm(this.hocsinh, this.dekiemtra, true);
                    bailamhocsinhFrm.Show();
                }
                else
                {
                    MessageBox.Show("Học sinh chưa nộp bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString()); ;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using QLLopHoc.BUS;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Home.HomeComponents;

namespace QLLopHoc.GUI.KhoaHoc
{
    public partial class TaoTaiLieufrm : Form
    {
        private string magiaovien, malop, machuong;
        PanelChuongDropDown panelchuong;
        TaiKhoanDAO taikhoanDAO = new TaiKhoanDAO();
        private DriveService service;

  
        HocLieuBUS tailieuBUS = new HocLieuBUS();
        FileHocLieuBUS filehlBUS = new FileHocLieuBUS();

        public TaoTaiLieufrm(PanelChuongDropDown panelchuong)
        {
            InitializeComponent();
            this.panelchuong = panelchuong;
            this.magiaovien = panelchuong.Khfrm.Lophoc.Magiangvien;
            this.malop = panelchuong.Khfrm.Lophoc.Malop;
            this.machuong = panelchuong.Chuong.Machuong;
        }

        private void TaoTaiLieufrm_Load(object sender, EventArgs e)
        {
            txt_tenlop.Text = taikhoanDAO.get_tenlop_malop(this.malop);
            txt_tenchuong.Text = taikhoanDAO.get_tenchuong_machuong(this.machuong);
            txt_tengiangvien.Text = taikhoanDAO.get_tengiangvien_magiangvien(this.magiaovien);
            UserCredential credential;
            using (var stream = new FileStream(@"..\..\bin\Debug\ggdrivelink.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.Drive },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true)).Result;
            }

            // Tạo dịch vụ Google Drive
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "hybrid"
            });
        }

        private void text_noidungtailieu_TextChanged(object sender, EventArgs e)
        {
            if (text_noidungtailieu.Text.Length > 300)
            {
                text_noidungtailieu.Text = text_noidungtailieu.Text.Substring(0, 300);
                text_noidungtailieu.SelectionStart = text_noidungtailieu.Text.Length;
            }
            else
                lab_demkitu_noidungtailieu.Text = text_noidungtailieu.Text.Length.ToString() + "/300 kí tự";
        }

        private void but_taotailieu_Click(object sender, EventArgs e)
        {
            if (text_tentailieu.Text.Length == 0 || text_noidungtailieu.Text.Length == 0)
                MessageBox.Show("Vui long nhập đầy đủ nội dung", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                HocLieuDTO hl = filehlBUS.insert_hoclieu_and_filehoclieu(panel_luufile, machuong, text_tentailieu.Text, text_noidungtailieu.Text, service);
                MessageBox.Show("Tạo tài liệu thành công", "Thông báo");
                this.Close();
                ButtonHocLieu btn = new ButtonHocLieu(this.panelchuong, hl);
                this.panelchuong.PnlChuongComponent.Controls.Add(btn);
                this.Close();
                this.panelchuong.IsExpanded = false;
                this.panelchuong.btnMoRong_Click(this, EventArgs.Empty);
                this.panelchuong.DemTaiLieuChuong++;
                this.panelchuong.LblDemTaiLieuChuong.Text = "(" + this.panelchuong.DemTaiLieuChuong + ")";
            }
        }

        private void but_layfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|Word documents (*.doc;*.docx)|*.doc;*.docx|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 5; // Thiết lập mặc định là All files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                    filetmp file_temp = new filetmp(fileIcon, openFileDialog.FileName);
                    panel_luufile.Controls.Add(file_temp);
                }
            }
        }

        private void text_tentailieu_TextChanged(object sender, EventArgs e)
        {
            if (text_tentailieu.Text.Length > 50)
            {
                text_tentailieu.Text = text_tentailieu.Text.Substring(0, 50);
                text_tentailieu.SelectionStart = text_tentailieu.Text.Length;
            }
            else
                lab_demkitu_tentailieu.Text = text_tentailieu.Text.Length.ToString() + "/50 kí tự";
        }

        private void TaoTaiLieufrm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

    }
}

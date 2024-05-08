using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien;

namespace QLLopHoc.GUI.KhoaHoc.BaiTap.SinhVien
{
    public partial class XemBaiLamfrm : Form
    {
        private TaiKhoanDTO taikhoanhienhanh;
        private BaiTapDTO baitap;
        private BaiLamBaiTapDTO blbt;
        private FileBaiLamBaiTapBUS fileblbtBUS;
        public XemBaiLamfrm()
        {
            InitializeComponent();

        }
        public XemBaiLamfrm(TaiKhoanDTO taikhoanhienhanh, BaiTapDTO bt, BaiLamBaiTapDTO blbt)
        {
            InitializeComponent();
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.baitap = bt;
            this.blbt = blbt;
            fileblbtBUS = new FileBaiLamBaiTapBUS();
        }

        private void XemBaiLamfrm_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = this.baitap.Tieude;
            this.lblStudent.Text = this.taikhoanhienhanh.Hoten;
            this.lblSubmitTime.Text = this.blbt.Thoigiannopbai.ToString("dd/MM/yyyy HH:mm:ss");
            this.txtContent.Text = this.blbt.Noidung;
            if (this.blbt.Diem != -1 && baitap.Congkhaidapan == 0)
            {
                this.lblTitle.Width = this.lblTitle.MaximumSize.Width;
                this.lblTitle.Height = this.lblTitle.MaximumSize.Height;
                this.btnViewAnswer.Visible = false;
            }
            //load file
            this.flowFilePanel.Controls.Clear();
            foreach (FileBaiLamBaiTap file in fileblbtBUS.List)
            {
                if (file.Mabailam.Equals(this.blbt.Mabailam))
                {
                    CloudFile tmp = new CloudFile(Path.GetFileName(file.Path), file.Id_file);
                    int index = Path.GetFileName(file.Path).IndexOf('.') + 1; // Lấy vị trí của dấu chấm và cộng thêm 1 để lấy chuỗi sau nó
                    string result = Path.GetFileName(file.Path).Substring(index);
                    switch (result)
                    {
                        case "txt":
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_txt_40;
                            tmp.FileExtension = "txt";
                            break;
                        case "pdf":
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_pdf_40;
                            tmp.FileExtension = "pdf";
                            break;
                        case "xlsx":
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_excel_40;
                            tmp.FileExtension = "xlsx";
                            break;
                        case "pptx":
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_powerpoint_40;
                            tmp.FileExtension = "pptx";
                            break;
                        case "docx":
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_word_40;
                            tmp.FileExtension = "docx";
                            break;
                        case "doc":
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_word_40;
                            tmp.FileExtension = "docx";
                            break;
                        default:
                            tmp.getIcon().Image = QLLopHoc.Properties.Resources.icons8_file_40;
                            tmp.FileExtension = "txt";
                            break;
                    }
                    this.flowFilePanel.Controls.Add(tmp);
                }
            }
            // align center scoreTxtbox
            score.SelectAll();
            score.SelectionAlignment = HorizontalAlignment.Center;
            if (this.blbt.Diem == -1)
            {
                score.Enabled = false;
                teacherComment.Text = "Chưa đánh giá";
            }
            else
            {
                score.Text = blbt.Diem.ToString();
                teacherComment.Text = (this.blbt.Nhanxet == null || this.blbt.Nhanxet == string.Empty) ? "Không có nhận xét." : this.blbt.Nhanxet;
                if (this.blbt.Diem > 5)
                    score.StateCommon.Content.Color1 = System.Drawing.Color.Green;
                else
                    score.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            }


            if (this.blbt.Noptre == 1)
            {
                this.state.Text = "Nộp trễ";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.state.Text = "Nộp đúng hạn";
                this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
                this.state.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnViewAnswer_Click(object sender, EventArgs e)
        {
            XemChiTietBaiTapfrm xemchitietFrm = new XemChiTietBaiTapfrm(this.baitap);
            xemchitietFrm.Show();
        }
    }
}

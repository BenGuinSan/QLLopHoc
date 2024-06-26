﻿using System;
using System.Collections;
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
using QLLopHoc.GUI.Home.HomeComponents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien
{
    public partial class TaoBaiTapfrm : Form
    {
        private PanelChuongDropDown panelChuong;
        private TaiKhoanDTO taikhoangiangvien;
        private LopHocDTO lophoc;
        private ChuongDTO chuong;
        private ThemDapAnfrm answerPanel;
        private BaiTapBUS btBUS;
        private FileBaiTapBUS fileBaiTapBUS;
        public TaoBaiTapfrm(PanelChuongDropDown panelChuong, TaiKhoanDTO taikhoangiangvien, LopHocDTO lophoc, ChuongDTO chuong)
        {
            InitializeComponent();
            this.panelChuong = panelChuong;
            this.taikhoangiangvien = taikhoangiangvien;
            this.lophoc = lophoc;
            this.chuong = chuong;
            answerPanel = new ThemDapAnfrm();
        }

        private void TaoBaiTapfrm_Load(object sender, EventArgs e)
        {
            this.lblClass.Text = lophoc.Tenlop;
            this.lblChuong.Text = chuong.Tenchuong;
            this.lblTeacher.Text = taikhoangiangvien.Hoten;
            this.dtpThoiGianBatDau.MinDate = DateTime.Now;
            this.dtpThoiGianBatDau.Value = DateTime.Now.AddMinutes(5);
            this.dtpThoiGianKetThuc.Value = DateTime.Now.AddMinutes(30);
            btBUS = new BaiTapBUS();
            fileBaiTapBUS = new FileBaiTapBUS();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTitle.Text.Length > 0)
                this.lblPlaceholderTitle.Hide();
            else
                this.lblPlaceholderTitle.Show();
            lblCharCountTitle.Text = txtTitle.Text.Length.ToString() + "/200";
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (this.txtContent.Text.Length > 0)
                this.lblPlaceholderContent.Hide();
            else
                this.lblPlaceholderContent.Show();
            lblCharCountContent.Text = txtContent.Text.Length.ToString() + "/4000";
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            this.answerPanel.ShowDialog();
        }

        private void dtpThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (!isValidTime()) return;
        }

        private void dtpThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (!isValidTime()) return;
        }

        private bool isValidTime()
        {
            if (this.dtpThoiGianBatDau.Value > this.dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không vượt quá thời gian kết thúc !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if ((this.dtpThoiGianBatDau.Value.AddMinutes(15)) > this.dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải cách thời gian bắt đầu ít nhất 15 phút !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word documents (*.doc;*.docx)|*.doc;*.docx|Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|PDF files (*.pdf)|*.pdf|PowerPoint presentations (*.ppt;*.pptx)|*.ppt;*.pptx|Text files (*.txt)|*.txt";


                openFileDialog.FilterIndex = 1; // Thiết lập mặc định là All files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                    LocalFile file_temp = new LocalFile(openFileDialog.FileName, fileIcon);
                    flowFilePanel.Controls.Add(file_temp);
                }
            }
        }

        private void createHomework_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tiêu đề bài tập không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTitle.Text = string.Empty;
                txtTitle.Focus();
                return;
            }

            if (txtContent.Text.Trim().Length == 0 && flowFilePanel.Controls.Count == 0)
            {
                MessageBox.Show("Phải có nội dung bài tập hoặc file bài tập !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContent.Text = string.Empty;
                txtContent.Focus();
                return;
            }

            if (this.answerPanel.HomeworkContent.Length == 0)
            {
                DialogResult confirm = MessageBox.Show("Bài tập không có đáp án. Xác nhận ?", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
            }
            DialogResult isConfirm = MessageBox.Show("Xác nhận tạo bài tập ? ", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isConfirm == DialogResult.No) return;
            if (!isValidTime()) return;

            Guid mabaitap = Guid.NewGuid();
            BaiTapDTO bt = new BaiTapDTO()
            {
                Mabaitap = mabaitap.ToString(),
                Machuong = this.chuong.Machuong,
                Tieude = this.txtTitle.Text,
                Noidungbaitap = this.txtContent.Text,
                Noidungdapan = this.answerPanel.HomeworkContent,
                Thoigiantao = DateTime.Now,
                Thoigianbatdau = DateTime.Parse(this.dtpThoiGianBatDau.Value.ToString()),
                Thoigianketthuc = DateTime.Parse(this.dtpThoiGianKetThuc.Value.ToString()),
                Congkhaidapan = (this.answerPanel.Congkhaidapan) ? 1 : 0,
                Daxoa = 0,
                Nopbu = (cbkLateSubmit.Checked ? 1 : 0),
            };

            ArrayList fileBTvaDA = new ArrayList();
            FileBaiTap fileTemp;

            if (flowFilePanel.Controls.Count >= 0)
            {
                foreach (Control file in flowFilePanel.Controls)
                {
                    fileTemp = new FileBaiTap()
                    {
                        Mabaitap = mabaitap.ToString(),
                        Lafiledapan = 0,
                        Path = (file as LocalFile).Path,
                    };
                    fileBTvaDA.Add(fileTemp);
                }
            }

            if (this.answerPanel.FilePanel.Controls.Count >= 0)
            {
                // get file dap an
                foreach (Control file in this.answerPanel.FilePanel.Controls)
                {
                    fileTemp = new FileBaiTap()
                    {
                        Mabaitap = mabaitap.ToString(),
                        Lafiledapan = 1,
                        Path = (file as LocalFile).Path
                    };
                    fileBTvaDA.Add(fileTemp);
                }
            }

            try
            {
                if (btBUS.createBaitap(bt))
                {
                    if (fileBTvaDA.Count >= 0)
                    {
                        if (fileBaiTapBUS.createFile(fileBTvaDA))
                        {
                         
                            MessageBox.Show("Tạo bài tập thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ButtonBaiTap btn = new ButtonBaiTap(this.panelChuong, bt);
                            this.panelChuong.PnlChuongComponent.Controls.Add(btn);
                            this.panelChuong.IsExpanded = false;
                            this.panelChuong.btnMoRong_Click(this, EventArgs.Empty);
                            this.panelChuong.DemTaiLieuChuong++;
                            this.panelChuong.LblDemTaiLieuChuong.Text = "(" + this.panelChuong.DemTaiLieuChuong + ")";
                            this.Dispose();
                            return;
                        }
                        else
                        {
                            fileBaiTapBUS.deleteFile(mabaitap.ToString());
                            btBUS.deleteBaitap(mabaitap.ToString());
                            MessageBox.Show("Upload file thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        
                        MessageBox.Show("Tạo bài tập thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonBaiTap btn = new ButtonBaiTap(this.panelChuong, bt);
                        this.panelChuong.PnlChuongComponent.Controls.Add(btn);
                        this.panelChuong.IsExpanded = false;
                        this.panelChuong.btnMoRong_Click(this, EventArgs.Empty);
                        this.panelChuong.DemTaiLieuChuong++;
                        this.panelChuong.LblDemTaiLieuChuong.Text = "(" + this.panelChuong.DemTaiLieuChuong + ")";
                        this.Dispose();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tạo bài tập thất bại !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                fileBaiTapBUS.deleteFile(mabaitap.ToString());
                btBUS.deleteBaitap(mabaitap.ToString());
                MessageBox.Show("Có lỗi đã xảy ra !\n Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private void lblPlaceholderTitle_Click(object sender, EventArgs e)
        {
            this.txtTitle.Focus();
        }

        private void lblPlaceholderContent_Click(object sender, EventArgs e)
        {
            this.txtContent.Focus();
        }
    }
}

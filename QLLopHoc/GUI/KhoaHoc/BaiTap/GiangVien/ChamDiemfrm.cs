﻿using System;
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

namespace QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien
{
    public partial class ChamDiemfrm : Form
    {
        private TaiKhoanDTO taikhoanhienhanh;
        private BaiTapDTO baitap;
        private BaiLamBaiTapDTO blbt;
        private FileBaiLamBaiTapBUS fileblbtBUS;
        public ChamDiemfrm()
        {
            InitializeComponent();
        }
        public ChamDiemfrm(TaiKhoanDTO taikhoanhienhanh, BaiTapDTO bt, BaiLamBaiTapDTO blbt)
        {
            InitializeComponent();
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.baitap = bt;
            this.blbt = blbt;
            fileblbtBUS = new FileBaiLamBaiTapBUS();
        }

        private void ChamDiemfrm_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = this.baitap.Tieude;
            this.lblStudent.Text = this.taikhoanhienhanh.Hoten;
            this.lblSubmitTime.Text = this.blbt.Thoigiannopbai.ToString("dd/MM/yyyy HH:mm:ss");
            this.txtContent.Text = this.blbt.Noidung;
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

        private void score_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9) and a single decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignore the keypress
            }
            if (e.KeyChar == '.' && score.Text.Contains("."))
            {
                e.Handled = true; // Ignore the keypress
            }
        }

        private void teacherComment_TextChanged(object sender, EventArgs e)
        {
            if (teacherComment.Text.Length == 0)
            {
                lblPlaceholder.Show();
            }
            else
            {
                lblPlaceholder.Hide();
            }
            lblCharCount.Text = teacherComment.Text.Length + "/300";
        }

        private void lblPlaceholder_Click(object sender, EventArgs e)
        {
            teacherComment.Focus();
        }

        private void score_KeyUp(object sender, KeyEventArgs e)
        {
            if (score.Text == string.Empty)
            {
                e.Handled = true;
                return;
            }
            //if (!double.TryParse(score.Text, out double result) || result > 9)
            //{
            //    score.Text = "10";
            //    score.SelectionStart = score.Text.Length;
            //}
            if (Convert.ToDouble(score.Text) > 10)
            {
                score.Text = "10";
                score.SelectionStart = score.Text.Length;
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            this.btnMark.Enabled = false;
            if (score.Text == string.Empty)
            {
                this.btnMark.Enabled = true;
                MessageBox.Show("Điểm không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult isConfirm = MessageBox.Show("LƯU Ý: Điểm sau khi chấm sẽ không thể chính sửa !\nXác nhận hoàn thành việc chấm điểm ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (isConfirm == DialogResult.No)
            {
                this.btnMark.Enabled = true;
                return;
            }
            try
            {
           
                this.blbt.Diem = Convert.ToInt16(score.Text);
                this.blbt.Nhanxet = teacherComment.Text;
                BaiLamBaiTapBUS blbtBUS = new BaiLamBaiTapBUS();
                if (blbtBUS.ChamDiemBaiLamBaiTap(this.blbt))
                {
                
                    MessageBox.Show("Đã lưu điểm vào bài làm !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    return;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra ! Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnMark.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                this.btnMark.Enabled = true;
                MessageBox.Show("Có lỗi xảy ra ! Vui lòng thử lại sau.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}

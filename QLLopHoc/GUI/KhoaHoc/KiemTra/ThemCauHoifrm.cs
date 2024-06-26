﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra
{
    public partial class ThemCauHoifrm : Form
    {
        KiemTrafrm kiemTrafrm;
        LopHocBUS lophocBUS = new LopHocBUS();
        CauHoiBUS cauhoiBUS = new CauHoiBUS();
        CauTraLoiBUS cautraloiBUS = new CauTraLoiBUS();
        ChiTietDeKiemTraBUS ctdktBUS = new ChiTietDeKiemTraBUS();

        CauHoiDTO cauhoi;
        // them
        public ThemCauHoifrm(KiemTrafrm kiemTrafrm)
        {
            InitializeComponent();
            InitPanelCauTraLoiContainer_ThemCauHoi();
            this.kiemTrafrm = kiemTrafrm;
            this.btnThemCauHoi.Visible = true;
            this.btnCapNhatCauHoi.Visible = false;
        }
        // sua
        public ThemCauHoifrm(KiemTrafrm kiemTraFrm, CauHoiDTO cauhoi)
        {
            InitializeComponent();
            this.kiemTrafrm = kiemTraFrm;
            this.cauhoi = cauhoi;
            this.rtbNoiDung.Text = cauhoi.Noidung;
            InitPanelCauTraLoiContainer_SuaCauHoi();
            this.btnThemCauHoi.Visible = false;
            this.btnCapNhatCauHoi.Visible = true;
            this.Text = "Sửa câu hỏi";
        }

        private void InitPanelCauTraLoiContainer_ThemCauHoi()
        {
            for (int i = 1; i <= 4; i++)
            {
                PanelChiTietCauTraLoi pnl = new PanelChiTietCauTraLoi();
                pnl.ChkLaDapAn.CheckedChanged += new EventHandler(this.ChkLaDapAnCheckedChanged);
                this.pnlCauTraLoiContainer.Controls.Add(pnl);
            }
        }

        private void InitPanelCauTraLoiContainer_SuaCauHoi()
        {
            foreach (CauTraLoiDTO ctl in cautraloiBUS.getList())
            {
                if (ctl.Macauhoi.Equals(cauhoi.Macauhoi))
                {
                    PanelChiTietCauTraLoi pnl = new PanelChiTietCauTraLoi(ctl);
                    pnl.ChkLaDapAn.CheckedChanged += new EventHandler(this.ChkLaDapAnCheckedChanged);
                    this.pnlCauTraLoiContainer.Controls.Add(pnl);
                }
            }
        }

        private void ChkLaDapAnCheckedChanged(object sender, EventArgs e)
        {
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.ChkLaDapAn != sender)
                {
                    pnl.ChkLaDapAn.Checked = false;
                }
            }
        }

        private void btnCapNhatCauHoi_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbNoiDung.Focus();
                return;
            }
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (pnl.RtbCauTraLoi.Text == "")
                {
                    MessageBox.Show("Nội dung câu trả lời không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnl.RtbCauTraLoi.Focus();
                    return;
                }
            }
            bool flagKiemTraChonDapAn = true;
            foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
            {
                if (!pnl.ChkLaDapAn.Checked)
                    flagKiemTraChonDapAn = false;
                else
                {
                    flagKiemTraChonDapAn = true;
                    break;
                }
            }
            if (!flagKiemTraChonDapAn)
            {
                MessageBox.Show("Vui lòng chọn một câu trả lời là đáp án đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CauHoiDTO cauhoinew = new CauHoiDTO(Guid.NewGuid().ToString(), rtbNoiDung.Text, lophocBUS.getLopHocByMaLop(kiemTrafrm.Chuong.Malop).Magiangvien, 0);
            if (cauhoiBUS.ThemCauHoi(cauhoinew))
            {
                int ladapan;
                foreach (PanelChiTietCauTraLoi pnl in this.pnlCauTraLoiContainer.Controls)
                {
                    if (!pnl.ChkLaDapAn.Checked)
                        ladapan = 0;
                    else
                        ladapan = 1;
                    CauTraLoiDTO cautraloi = new CauTraLoiDTO(Guid.NewGuid().ToString(), pnl.RtbCauTraLoi.Text, ladapan, cauhoinew.Macauhoi);
                    cautraloiBUS.ThemCauTraLoi(cautraloi);
                }
                ButtonCauHoi btnCauHoi = new ButtonCauHoi(cauhoinew, this.kiemTrafrm);
                kiemTrafrm.PnlCauHoiContainer.Controls.Add(btnCauHoi);
                MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm câu hỏi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void SaveWordFile()
        {
            try
            {
                string sourceFolderPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Filemau");
                // Tên tệp tin Word muốn lưu
                string fileName = "maucauhoi.txt";

                // Đường dẫn đầy đủ đến tệp tin nguồn
                string sourceFilePath = Path.Combine(sourceFolderPath, fileName);

                // Đưa ra lựa chọn để chọn vị trí lưu mới
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = fileName;
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đường dẫn đầy đủ đến vị trí lưu mới
                    string destinationFilePath = saveFileDialog.FileName;

                    // Sao chép tệp từ nguồn đến đích
                    File.Copy(sourceFilePath, destinationFilePath, true);

                    MessageBox.Show("Lưu file thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lưu file: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveWordFile();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ReadWordDocument(filePath);
            }
        }
        private void ReadWordDocument(string filePath)
        {
            try
            {
                ArrayList listcauhoi = new ArrayList();
                ArrayList listcautraloi = new ArrayList();
                CauHoiDTO ch = null;
                int countctl = 0;
                int countdapan = 0;
                bool flagdapan = false;

                // Kiểm tra tệp có rỗng không
                if (new FileInfo(filePath).Length == 0)
                {
                    MessageBox.Show("Lỗi: Tệp văn bản rỗng.", "Lỗi Tệp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Question:"))
                        {
                            ch = new CauHoiDTO(Guid.NewGuid().ToString(), line.Substring(10).Trim(), lophocBUS.getLopHocByMaLop(kiemTrafrm.Chuong.Malop).Magiangvien, 0);
                            listcauhoi.Add(ch);
                        }
                        else if (line.StartsWith("[*]"))
                        {
                            CauTraLoiDTO ctl = new CauTraLoiDTO(Guid.NewGuid().ToString(), line.Substring(3).Trim(), 1, ch.Macauhoi);
                            listcautraloi.Add(ctl);
                            countdapan++;
                            flagdapan = true;
                            countctl++;
                        }
                        else if (string.IsNullOrWhiteSpace(line))
                        {
                            if (countctl != 4)
                            {
                                MessageBox.Show("Tồn tại câu hỏi không đủ hoặc nhiều hơn 4 câu trả lời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (flagdapan == false)
                            {
                                MessageBox.Show("Tồn tại câu hỏi không có đáp án hoặc sai định dạng đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (countdapan > 1)
                            {
                                MessageBox.Show("Tồn tại câu hỏi nhiều hơn 2 đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            flagdapan = false;
                            countctl = 0;
                            countdapan = 0;
                            continue;
                        }
                        else
                        {
                            CauTraLoiDTO ctl = new CauTraLoiDTO(Guid.NewGuid().ToString(), line.Trim(), 0, ch.Macauhoi);
                            listcautraloi.Add(ctl);
                            countctl++;
                        }
                    }
                    //kiem tra cuoi file
                    if (countctl != 4)
                    {
                        MessageBox.Show("Tồn tại câu hỏi không đủ hoặc nhiều hơn 4 câu trả lời hoặc sai cấu trúc file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (flagdapan == false)
                    {
                        MessageBox.Show("Tồn tại câu hỏi không có đáp án hoặc sai định dạng đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (countdapan > 1)
                    {
                        MessageBox.Show("Tồn tại câu hỏi nhiều hơn 2 đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    /*MessageBox.Show(line + "\n" + 
                        "counctl: " + countctl + "\n" + 
                        "countdapan: " + countdapan + "\n" + 
                        "flagdapan: " + flagdapan);*/
                }
                foreach (CauHoiDTO cauhoi in listcauhoi)
                {
                    if (!cauhoiBUS.ThemCauHoi(cauhoi))
                    {
                        MessageBox.Show("Có lỗi khi thêm câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ButtonCauHoi btnCauHoi = new ButtonCauHoi(cauhoi, this.kiemTrafrm);
                    kiemTrafrm.PnlCauHoiContainer.Controls.Add(btnCauHoi);
                }
                foreach (CauTraLoiDTO cautraloi in listcautraloi)
                    if (!cautraloiBUS.ThemCauTraLoi(cautraloi))
                    {
                        MessageBox.Show("Có lỗi khi thêm câu trả lời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file text: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

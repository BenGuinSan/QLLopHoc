﻿using System;
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

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    public partial class ButtonCauHoi : UserControl
    {
      
        CauHoiDTO cauhoi;
        KiemTrafrm ktfrm;
        CauHoiBUS cauhoiBUS = new CauHoiBUS();

        public CauHoiDTO Cauhoi { get => cauhoi; set => cauhoi = value; }

        public ButtonCauHoi(CauHoiDTO cauhoi, KiemTrafrm ktfrm)
        {
            InitializeComponent();
            this.cauhoi = cauhoi;
            this.ktfrm = ktfrm;
            this.lblNoiDungCauHoi.Text = cauhoi.Noidung;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (this.btnChon.Checked == false) return;
            PanelChiTietCauHoi panel = new PanelChiTietCauHoi(cauhoi);
            panel.BtnXoaCauHoi.Click += new EventHandler((s, ev) => {
                DialogResult dr = MessageBox.Show("Xác nhận xóa câu hỏi khỏi đề kiểm tra?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.ktfrm.PnlChiTietCauHoiContainer.Controls.Remove(panel);
                    foreach (ButtonCauHoi btn in this.ktfrm.PnlCauHoiContainer.Controls)
                    {
                        if (btn.Cauhoi.Macauhoi.Equals(this.Cauhoi.Macauhoi))
                        {
                            btn.btnChon.Enabled = true;
                            btn.btnChon.Checked = false;
                            break;
                        }
                    }
                }
            });
            this.ktfrm.PnlChiTietCauHoiContainer.Controls.Add(panel);
            this.btnChon.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!this.btnChon.Enabled)
            {
                MessageBox.Show("Câu hỏi đang được chọn trong đề kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Xác nhận xóa câu hỏi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cauhoiBUS.XoaCauHoi(cauhoi);
                MessageBox.Show("Xóa câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ktfrm.PnlCauHoiContainer.Controls.Remove(this);
                this.Dispose();
            }
            this.ktfrm.HienThiDanhSachCauHoi(cauhoiBUS.GetDanhSachCauHoiByMaTaiKhoan(this.cauhoi.Mataikhoan));
        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            PanelChiTietCauHoi panel = new PanelChiTietCauHoi(cauhoi);
            ChiTietCauHoifrm frm = new ChiTietCauHoifrm();
            panel.BtnXoaCauHoi.Visible = false;
            panel.BtnDong.Visible = true;
            panel.BtnDong.Click += (s, ev) =>
            {
                frm.Close();
            };
            panel.Dock = DockStyle.Fill;
            frm.Controls.Add(panel);
            frm.ShowDialog();
        }

        private void lblNoiDungCauHoi_Click(object sender, EventArgs e)
        {
            btnCauHoi_Click(this, EventArgs.Empty);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!this.btnChon.Enabled)
            {
                MessageBox.Show("Câu hỏi đang được chọn trong đề kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new ThemCauHoifrm(this.ktfrm, cauhoi).ShowDialog();
            ktfrm.TaiLaiDanhSachCauHoi();
        }
    }
}

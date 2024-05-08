using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using QLLopHoc.BUS;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Home.HomeComponents;
using QLLopHoc.GUI.KhoaHoc;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.IO;
using System.Runtime.CompilerServices;

namespace QLLopHoc.GUI.Home
{
    public partial class ThongTinLopHocfrm : Form
    {
        DataTable dt = new DataTable();
        LopHocDTO lophoc;
        TaiKhoanDTO taiKhoan;
        PanelGiaoDienLopHoc pnlgdlh;
        string tenlop;
        string mota;

        ThamGiaBUS tgBUS = new ThamGiaBUS();
        TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
        LopHocBUS lophocBUS = new LopHocBUS();
        public static string tenhinh = null;

        public ThongTinLopHocfrm(TaiKhoanDTO taikhoan, PanelGiaoDienLopHoc panel)
        {
            InitializeComponent();
            this.pnlgdlh = panel;
            this.lophoc = panel.Lophoc;
            this.taiKhoan = taikhoan;

            // Hien thi len giao dien
            this.txtTenLop.Text = lophoc.Tenlop;
            this.tenlop = lophoc.Tenlop;
            this.mota = lophoc.Mota;
            this.txtMaLop.Text = lophoc.Malop;
            this.rtbNoiDung.Text = lophoc.Mota;
            this.btnRoiLop.Visible = false;
            this.btnXoaLop.Visible = true;
            this.lblTenGiaoVien.Text = taikhoanBUS.List[taikhoanBUS.GetTaiKhoanByMaTaiKhoan(lophoc.Magiangvien)].Hoten;

            dt = tgBUS.DanhSachHocSinhTheoMaLop(lophoc.Malop);
            this.dgvDanhSachHocSinh.DataSource = dt;
            this.dgvDanhSachHocSinh.DefaultCellStyle.Font = new Font("Times New Roman", 11);


            this.dgvDanhSachHocSinh.Columns[0].Visible = false;
            this.dgvDanhSachHocSinh.Columns[1].Width = 200;
            this.dgvDanhSachHocSinh.Columns[2].Width = 250;
            this.dgvDanhSachHocSinh.Columns[3].Width = 150;
            this.dgvDanhSachHocSinh.Columns[1].HeaderText = "Học sinh";
            this.dgvDanhSachHocSinh.Columns[2].HeaderText = "Email";
            this.dgvDanhSachHocSinh.Columns[3].HeaderText = "Số điện thoại";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Xóa";
            btn.Text = "Xóa";
            btn.Name = "btnXoaHocSinh";

            btn.UseColumnTextForButtonValue = true;
            btn.MinimumWidth = 6;
            btn.Width = 110;

            this.dgvDanhSachHocSinh.Columns.Insert(4, btn);
            this.dgvDanhSachHocSinh.Columns[4].Width = 115;
            if (!this.lophoc.Magiangvien.Equals(this.taiKhoan.Mataikhoan))
            {
                this.txtTenLop.Enabled = false;
                this.rtbNoiDung.Enabled = false;
                this.pnlMaLop.Visible = false;
                this.dgvDanhSachHocSinh.Columns[1].Width = 270;
                this.dgvDanhSachHocSinh.Columns[2].Width = 300;
                this.dgvDanhSachHocSinh.Columns[3].Width = 170;
                this.dgvDanhSachHocSinh.Columns[4].Visible = false;
                this.btnRoiLop.Visible = true;
                this.btnXoaLop.Visible = false;
                this.pictureBox1.Enabled = false;
                this.btnXuatExcel.Visible = false;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaLop.Text);
            MessageBox.Show("Đã chép vào bộ nhớ tạm thời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMoRong_Click(object sender, EventArgs e)
        {
            new HienThiMaLopHocfrm(lophoc.Malop).ShowDialog();
        }

        private void txtTenLop_Leave(object sender, EventArgs e)
        {
            if (this.tenlop.Equals(txtTenLop.Text.Trim())) return;
            this.lophoc.Tenlop = txtTenLop.Text;
            this.tenlop = txtTenLop.Text;
            pnlgdlh.LblTenLop.Text = txtTenLop.Text;
            foreach (ButtonClass btn in pnlgdlh.Homefrm.PnlLopHocContainer.Controls)
            {
                if (btn.Lophoc.Malop.Equals(this.lophoc.Malop))
                {
                    btn.LblTenLop.Text = txtTenLop.Text;
                    break;
                }
            }
            lophocBUS.SuaLopHoc(this.lophoc);
        }

        private void rtbNoiDung_Leave(object sender, EventArgs e)
        {
            if (this.mota.Equals(rtbNoiDung.Text.Trim())) return;
            this.lophoc.Mota = rtbNoiDung.Text;
            this.mota = rtbNoiDung.Text;
            lophocBUS.SuaLopHoc(this.lophoc);
        }

        private void ThongTinLopHocfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtTenLop_Leave(this, EventArgs.Empty);
            rtbNoiDung_Leave(this, EventArgs.Empty);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text;

            dgvDanhSachHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDanhSachHocSinh.Rows)
                {
                    //MessageBox.Show(row.Cells[2].Value.ToString());
                    if (row.Cells[2].Value.ToString().ToLower().Contains(searchValue.ToLower()) ||
                        row.Cells[3].Value.ToString().ToLower().Contains(searchValue.ToLower()) ||
                        row.Cells[4].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                    {
                        row.Selected = true;
                        dgvDanhSachHocSinh.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm theo họ tên hoặc email hoặc sđt";
                txtTimKiem.ForeColor = SystemColors.Control; // Đặt màu chữ thành màu xám
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm theo họ tên hoặc email hoặc sđt")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định của hệ thống
            }
        }

        private void dgvDanhSachHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                if (dgvDanhSachHocSinh.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvDanhSachHocSinh.SelectedRows[0];
                    DialogResult dr = MessageBox.Show("Xác nhận xóa học sinh khỏi lớp học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                        if (tgBUS.XoaThamGia(new ThamGiaDTO(this.lophoc.Malop, row.Cells[1].Value.ToString())))
                        {
                            this.dgvDanhSachHocSinh.Rows.Remove(row);
                            MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận giải tán lớp học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (lophocBUS.XoaLopHoc(this.lophoc.Malop))
                {
                    //this.panelgdlh.BtnChinhSuaLopHoc.Visible = false;
                    foreach (ButtonClass btn in this.pnlgdlh.Homefrm.PnlLopHocContainer.Controls)
                    {
                        if (btn.Lophoc.Malop.Equals(this.lophoc.Malop))
                        {
                            btn.LblChiTiet.Text = "Lớp học đã giải tán";
                            btn.BtnLopHoc.StateCommon.Back.Color1 = Color.LightGray;
                            btn.BtnLopHoc.StateCommon.Back.Color2 = Color.LightGray;
                            btn.BtnLopHoc.OverrideDefault.Back.Color1 = Color.LightGray;
                            btn.BtnLopHoc.OverrideDefault.Back.Color2 = Color.LightGray;
                            btn.LblTenLop.BackColor = Color.LightGray;
                            btn.LblChiTiet.BackColor = Color.LightGray;
                            btn.btnLopHocClick();
                            break;
                        }
                    }
                    this.pnlgdlh.Homefrm.Form.addFormtoPanelContainer(new Homefrm(this.pnlgdlh.Homefrm.Form));
                    this.Close();
                }
            }
        }

        private void btnRoiLop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận ròi khỏi lớp học?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (tgBUS.XoaThamGia(new ThamGiaDTO(this.lophoc.Malop, taiKhoan.Mataikhoan)))
                {
                    MessageBox.Show("Đã rời khỏi lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    pnlgdlh.Controls.Clear();
                    foreach (ButtonClass btn in pnlgdlh.Homefrm.PnlLopHocContainer.Controls)
                    {
                        if (btn.Lophoc.Malop.Equals(this.lophoc.Malop))
                        {
                            pnlgdlh.Homefrm.PnlLopHocContainer.Controls.Remove(btn);
                            break;
                        }
                    }
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

            if (dgvDanhSachHocSinh.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.Title = "Chọn nơi lưu file Excel";
                saveFileDialog.FileName = "DanhSachHocSinh.xlsx";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string excelFilePath = saveFileDialog.FileName;
                    // Gọi phương thức xuất Excel và truyền đường dẫn file Excel
                    ExportToExcel(dgvDanhSachHocSinh, excelFilePath);
                }
            }
        }
        private void ExportToExcel(DataGridView dataGridView, string excelFilePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                // Tạo một Sheet trong Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DanhSachHocSinh");

                // Đổ dữ liệu từ DataGridView vào Excel
                worksheet.Cells[2, 1].Value = "STT";
                worksheet.Cells[2, 1].Style.Font.Bold = true;
                worksheet.Cells[2, 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[2, 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                for (int col = 2; col <= dataGridView.Columns.Count - 1; col++)
                {
                    worksheet.Cells[2, col].Value = dataGridView.Columns[col].HeaderText;
                    worksheet.Cells[2, col].Style.Font.Bold = true;
                    worksheet.Cells[2, col].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }
                int stt = 1;
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    worksheet.Cells[row + 3, 1].Value = stt++;
                    worksheet.Cells[row + 3, 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    for (int col = 1; col < dataGridView.Columns.Count - 1; col++)
                    {
                        worksheet.Cells[row + 3, col + 1].Value = dataGridView.Rows[row].Cells[col + 1].Value;
                        worksheet.Cells[row + 3, col + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                }

                // Merge ô từ A1 đến C5
                using (var range = worksheet.Cells[1, 1, 1, 4])
                {
                    range.Merge = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    range.Style.Font.Bold = true;
                    range.Style.Font.Size = 14;
                    range.Value = "DANH SÁCH HỌC SINH LỚP " + this.lophoc.Tenlop.ToUpper();
                    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                // Sau khi ghi dữ liệu, thực hiện AutoFit cho các cột
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                // Lưu file Excel vào đường dẫn đã chọn
                File.WriteAllBytes(excelFilePath, package.GetAsByteArray());

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChonAnhLopHocfrm form = new ChonAnhLopHocfrm(2, pnlgdlh);
            form.sendImage = new ChonAnhLopHocfrm.SendImage(LoadHinh);
            form.ShowDialog();
            lophocBUS.capnhat_anhlop(this.lophoc.Malop, tenhinh);
    
        }

        private void LoadHinh(Image image)
        {
            pictureBox1.Image = Properties.Resources.imglop1;
            pictureBox1.Image = image;
        }

        private void ThongTinLopHocfrm_Load(object sender, EventArgs e)
        {
            System.Resources.ResourceManager rm = global::QLLopHoc.Properties.Resources.ResourceManager;
            pictureBox1.Image = (Image)rm.GetObject(this.lophoc.Avatar);
        }
    }
}

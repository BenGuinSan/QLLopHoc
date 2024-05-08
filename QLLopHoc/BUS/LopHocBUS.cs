using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using Google.Apis.Drive.v3;
using Unidecode.NET;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLLopHoc.BUS
{
    public class LopHocBUS
    {
        private ArrayList list;
        private LopHocDAO lopDAO;
        private LopHocDTO lopDTO;
        System.Data.DataTable dataTable = null;
        System.Data.DataTable dt = new System.Data.DataTable();

        public LopHocBUS()
        {
            lopDAO = new LopHocDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }

        public void loadList()
        {
            list = lopDAO.loadList();
            LopHocComparer comparer = new LopHocComparer();
            comparer.TypeToCompare = LopHocComparer.ComparisonType.malophoc;
            list.Sort(comparer);
        }

        public ArrayList GetDanhSachTatCaLopHocByMaTaiKhoan(string mataikhoan)
        {
            return lopDAO.GetDanhSachTatCaLopHocByMaTaiKhoan(mataikhoan);
        }

        public bool themlop(LopHocDTO lophoc)
        {

            if (lopDAO.ThemLopHoc(lophoc))
            {
                this.list.Add(lophoc);
                return true;
            }
            return false;
        }

        public bool SuaLopHoc(LopHocDTO lophoc)
        {
            if (lopDAO.SuaLopHoc(lophoc))
            {
                foreach (LopHocDTO l in this.list)
                {
                    if (l.Malop.Equals(lophoc.Malop))
                    {
                        l.Tenlop = lophoc.Tenlop;
                        l.Mota = lophoc.Mota;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool XoaLopHoc(string malop)
        {
            if (lopDAO.XoaLopHoc(malop))
            {
                foreach (LopHocDTO l in this.list)
                {
                    if (l.Malop.Equals(malop))
                    {
                        l.Daxoa = 1;
                        return true;
                    }
                }
            }
            return false;
        }
        public void dataview_lophoc(DataGridView dataGridView)
        {

            dataTable = lopDAO.LayDanhSachLopHoc();
            // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu
            // Gán dữ liệu cho DataGridView
            dataGridView.DataSource = dataTable;

            // Tạo cột checkbox cho cột "daxoa"
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "daxoa";
            checkBoxColumn.HeaderText = "Đã Xóa";
            checkBoxColumn.Name = "daxoa";
            dataGridView.Columns.Add(checkBoxColumn);
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Tên lớp học";
            dataGridView.Columns[2].HeaderText = "Mô tả";
            dataGridView.Columns[3].HeaderText = "Tên giảng viên";
            dataGridView.Columns[1].Width = 220;
            dataGridView.Columns[2].Width = 270;
            dataGridView.Columns[3].Width = 230;
            dataGridView.Columns[4].Visible = false;
        }
        public int count_class_ban(DataGridView dataGridView)
        {
            int soLuong_class_ban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "1")
                {
                    soLuong_class_ban++;
                }
            }

            return soLuong_class_ban;
        }
        public void timkiem_lop_tengiangvien(string searchTerm, DataGridView dataGridView)
        {
            dataTable = lopDAO.LayDanhSachLopHoc();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode().Trim(); // Loại bỏ khoảng trắng đầu và cuối

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let hoten = row.Field<string>("hoten").ToLower().Unidecode().Trim() // Loại bỏ khoảng trắng đầu và cuối
                                where hoten.Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                System.Data.DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }

        }
        public void timkiem_lop_tenlop(string searchTerm, DataGridView dataGridView)
        {
            dataTable = lopDAO.LayDanhSachLopHoc();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode().Trim(); // Loại bỏ khoảng trắng đầu và cuối

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let hoten = row.Field<string>("ten").ToLower().Unidecode().Trim() // Loại bỏ khoảng trắng đầu và cuối
                                where hoten.Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                System.Data.DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }

        }
        public void ban_class(string malop)
        {
            list = lopDAO.loadList();
            lopDAO.ban_lop(malop);
        }
        public void unban_class(string malop)
        {
            list = lopDAO.loadList();
            lopDAO.unban_lop(malop);
        }
        public void capnhat_anhlop(string malop, string ten)
        {

            list = lopDAO.loadList();
            lopDAO.update_anhlop(ten, malop);
        }

        public int count_class_unban(DataGridView dataGridView)
        {
            int soLuong_class_unban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "0")
                {
                    soLuong_class_unban++;
                }
            }

            return soLuong_class_unban;
        }

        public LopHocDTO getLophocWithMaLop(string malop)
        {
            LopHocComparer comparer = new LopHocComparer();
            comparer.TypeToCompare = LopHocComparer.ComparisonType.malophoc;
            LopHocDTO lopSearch = new LopHocDTO();
            lopSearch.Malop = malop;
            int index = list.BinarySearch(lopSearch, comparer);
            return (LopHocDTO)list[index];
        }

        public LopHocDTO getLopHocByMaLop(string malop)
        {
            foreach (LopHocDTO lop in list)
            {
                if (lop.Malop.ToLower().Equals(malop.ToLower()))
                    return lop;
            }
            return null;
        }

        public void xuat_excel(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "export.xlsx";
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            try
            {
                // Create a new Excel application
                excelApp = new Excel.Application();
                // Create a new workbook
                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = workbook.ActiveSheet;
                // Export column headers
                for (int i = 1; i < dataGridView1.Columns.Count - 1; i++)
                {
                    if (i == 4)
                        worksheet.Cells[1, i] = "Tình trạng hoạt động";
                    else
                        worksheet.Cells[1, i] = dataGridView1.Columns[i].HeaderText;

                }
                // Export data rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 4)
                            if (dataGridView1.Rows[i].Cells[j].Value?.ToString() == "1")
                                worksheet.Cells[i + 2, j] = "Đã bị xóa";
                            else
                                worksheet.Cells[i + 2, j] = "Vẫn đang hoạt động";
                        else
                            worksheet.Cells[i + 2, j] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                    }
                }
                // Autofit columns
                worksheet.Columns.AutoFit();
                // Save the workbook
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xuất Excel: " + ex.Message);
            }
            finally
            {
                // Cleanup COM objects to avoid memory leaks
                if (worksheet != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }
                if (workbook != null)
                {
                    workbook.Close();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }
                GC.Collect();
            }
        }
    }
}

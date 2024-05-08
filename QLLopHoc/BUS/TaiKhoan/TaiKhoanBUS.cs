using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using Unidecode.NET;
using Excel = Microsoft.Office.Interop.Excel;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using DataTable = System.Data.DataTable;

namespace QLLopHoc.BUS
{
    public class TaiKhoanBUS
    {
        private List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
        public TaiKhoanDAO dao = new TaiKhoanDAO();
        DataTable dt = new DataTable();
        DataTable dataTable = null;

        public List<TaiKhoanDTO> List { get => list; set => list = value; }

        // Gán mảng kiểu TaiKhoan được lấy lên ở DAO truyền vào 'list' ở lớp BUS
        public TaiKhoanBUS()
        {
            list = dao.get_danhSach();
        }

        public List<TaiKhoanDTO> get_list()
        {
            return list;
        }

        public bool kt_email(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
        public Boolean kt_taikhoan_tontai(string email)
        {
            foreach (TaiKhoanDTO t in list)
            {
                if (t.Email == email)
                    return true;
            }
            return false;
        }
        public int kt_quyenhan_taikhoan(string email)
        {
            foreach (TaiKhoanDTO t in list)
            {
                if (t.Email == email)
                    return t.Manhomquyen;
            }
            return 1;
        }
        public int kt_daxoa_taikhoan(string email)
        {
            foreach (TaiKhoanDTO t in list)
            {
                if (t.Email == email)
                    return t.Daxoa;
            }
            return 1;
        }
        public TaiKhoanDTO GetTaiKhoanByEmail(string email)
        {
            TaiKhoanDTO taikhoan = null;
            foreach (TaiKhoanDTO tk in this.list)
            {
                if (tk.Email.Equals(email))
                {
                    taikhoan = tk;
                    break;
                }
            }
            return taikhoan;
        }
        public int GetTaiKhoanByMaTaiKhoan(string mataikhoan)
        {
            TaiKhoanComparer comparer = new TaiKhoanComparer();
            comparer.TypeToCompare = TaiKhoanComparer.ComparisonType.mataikhoan;
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.Mataikhoan = mataikhoan;
            this.list.Sort();
            int index = list.BinarySearch(tk, comparer);
            return index;
        }

        public Boolean check_matkhau(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+.]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        public Boolean tao_taikhoan(string email, string password)
        {
            // Lấy email là họ và tên tạm thời
            TaiKhoanDTO tk = new TaiKhoanDTO(null, email, email, password, null, null, 2, 0);
            if (dao.insert_taikhoan(tk) == true)
            {
                list.Add(tk);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void dataview_taikhoan(DataGridView dataGridView)
        {
            DataTable dt = dao.getDSTaiKhoan();
            // Gan du lieu do dataGridView
            dataGridView.DataSource = dt;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "daxoa";
            checkBoxColumn.HeaderText = "Đã Xóa";
            checkBoxColumn.Name = "daxoa";
            dataGridView.Columns.Add(checkBoxColumn);
            dataGridView.Columns[0].HeaderText = "Họ tên";
            dataGridView.Columns[1].HeaderText = "Email";
            dataGridView.Columns[2].HeaderText = "Số điện thoại";
            dataGridView.Columns[0].Width = 220;
            dataGridView.Columns[1].Width = 270;
            dataGridView.Columns[2].Width = 230;
            dataGridView.Columns[3].Visible = false;
        }


        public int count_user_ban(DataGridView dataGridView)
        {
            int soLuong_user_ban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "1")
                {
                    soLuong_user_ban++;
                }
            }

            return soLuong_user_ban;
        }
        public int count_user_unban(DataGridView dataGridView)
        {
            int soLuong_user_unban = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Kiểm tra giá trị của cột "daxoa"
                object value = row.Cells["daxoa"].Value;

                // Kiểm tra xem giá trị có là chuỗi "1" không và không phải null
                if (value != null && value.ToString() == "0")
                {
                    soLuong_user_unban++;
                }
            }

            return soLuong_user_unban;
        }
        public void timkiem_taikhoan_ten(string searchTerm, DataGridView dataGridView)
        {
            dataTable = dao.LayDanhSachTaiKhoan();
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
                DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }

        }
        public void timkiem_taikhoan_email(string searchTerm, DataGridView dataGridView)
        {
            dataTable = dao.LayDanhSachTaiKhoan();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode().Trim(); // Loại bỏ khoảng trắng đầu và cuối

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let hoten = row.Field<string>("email").ToLower().Unidecode().Trim() // Loại bỏ khoảng trắng đầu và cuối
                                where hoten.Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }
        }
        public void timkiem_taikhoan_sdt(string searchTerm, DataGridView dataGridView)
        {
            dataTable = dao.LayDanhSachTaiKhoan();
            // Chuyển đổi tìm kiếm và dữ liệu về chữ thường và loại bỏ dấu Telex
            searchTerm = searchTerm.ToLower().Unidecode();

            // Lọc dữ liệu dựa trên họ tên với khả năng tìm kiếm gần đúng
            var searchResults = from row in dataTable.AsEnumerable()
                                let sodienthoai = row.Field<string>("sodienthoai")
                                where sodienthoai != null && sodienthoai.ToLower().Unidecode().Contains(searchTerm)
                                select row;

            // Kiểm tra xem tập hợp có chứa ít nhất một DataRow không
            if (searchResults.Any())
            {
                // Tạo DataTable mới từ kết quả tìm kiếm
                DataTable resultTable = searchResults.CopyToDataTable();

                // Gán dữ liệu cho DataGridView
                dataGridView.DataSource = resultTable;
            }
            else
            {
                // Nếu không có kết quả, có thể xử lý theo ý bạn, ví dụ hiển thị một thông báo
                MessageBox.Show("Không tìm thấy kết quả nào.");
            }
        }

        public void ban_user(string email)
        {
            dao.ban_taikhoan(email);
            list = dao.get_danhSach();
        }
        public void unban_user(string email)
        {
            dao.unban_taikhoan(email);
            list = dao.get_danhSach();
        }

        public PictureBox load_hinhdaidien(string ten)
        {
            PictureBox pictureBox = new PictureBox();

            // Sử dụng ResourceManager để lấy hình ảnh từ tài nguyên theo tên
            System.Resources.ResourceManager rm = global::QLLopHoc.Properties.Resources.ResourceManager;
            pictureBox.Image = (Image)rm.GetObject(ten);

            return pictureBox;
        }
        public void capnhap_hinhanhdaidien(string email, string tenhinh)
        {
            string luachon = null;
            switch (tenhinh)
            {
                case "pic1":
                    luachon = "canhan1";
                    break;
                case "pic2":
                    luachon = "canhan2";
                    break;
                case "pic3":
                    luachon = "canhan3";
                    break;
                case "pic4":
                    luachon = "canhan4";
                    break;
                case "pic5":
                    luachon = "canhan5";
                    break;
                case "pic6":
                    luachon = "canhan6";
                    break;

            }
            dao.update_anhcanhan(luachon, email);
            list = dao.get_danhSach();

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
                for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                {
                    if (i == 3)
                        worksheet.Cells[1, i + 1] = "Tình trạng hoạt động";
                    else
                        worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;

                }
                // Export data rows
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 3)
                            if (dataGridView1.Rows[i].Cells[j].Value?.ToString() == "1")
                                worksheet.Cells[i + 2, j + 1] = "Đã bị xóa";
                            else
                                worksheet.Cells[i + 2, j + 1] = "Vẫn đang hoạt động";
                        else
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
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

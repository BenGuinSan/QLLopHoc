using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;


namespace QLLopHoc.BUS
{
    public class TaiKhoanBUS
    {
        private List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
        public TaiKhoanDAO dao = new TaiKhoanDAO();

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
            else { 
                return false; 
            }
        }

        public void taiKhoan_GridView(DataGridView dataGridView)
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
            dataGridView.Columns[0].Width = 300;
            dataGridView.Columns[1].Width = 300;
            dataGridView.Columns[2].Width = 280;
            dataGridView.Columns[3].Visible = false;
        }
    }
}

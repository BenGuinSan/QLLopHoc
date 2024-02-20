using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QLLopHoc.DAO;
using QLLopHoc.DTO;


namespace QLLopHoc.BUS
{
    public class TaiKhoanBUS
    {
        private List<TaiKhoan> list = new List<TaiKhoan>();
        public TaiKhoanDAO dao = new TaiKhoanDAO();
        public List<TaiKhoan> List { get => list; set => list = value; }

        // Gán mảng kiểu TaiKhoan được lấy lên ở DAO truyền vào 'list' ở lớp BUS
        public TaiKhoanBUS()
        {
            list = dao.get_danhSach();
        }
        public List<TaiKhoan> get_list()
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
            foreach (TaiKhoan t in list)
            {
                if (t.Email == email)
                    return true;
            }
            return false;
        }
        public int kt_quyenhan_taikhoan(string email)
        {
            foreach (TaiKhoan t in list)
            {
                if (t.Email == email)
                    return t.Manhomquyen;
            }
            return 1;
        }
        public int kt_daxoa_taikhoan(string email)
        {
            foreach (TaiKhoan t in list)
            {
                if (t.Email == email)
                    return t.Daxoa;
            }
            return 1;
        }
        public TaiKhoan GetTaiKhoanByEmail(string email)
        {
            TaiKhoan taikhoan = null;
            foreach (TaiKhoan tk in this.list)
            {
                if (tk.Email.Equals(email))
                {
                    taikhoan = tk;
                    break;
                }
            }
            return taikhoan;
        }
        public Boolean check_matkhau(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+.]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        public Boolean tao_taikhoan(string email, string password)
        {
            // Lấy email là họ và tên tạm thời
            TaiKhoan tk = new TaiKhoan(null, email, email, password, null, null, 2, 0);
            if (dao.insert_taikhoan(tk) == true)
            {
                list.Add(tk);
                return true;
            }
            else { 
                return false; 
            }
        }
    }
}

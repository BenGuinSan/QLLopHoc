using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;

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

        public ArrayList GetDanhSachLopHocGiangDayByMaTaiKhoan(string mataikhoan)
        {
            return lopDAO.GetDanhSachLopHocGiangDayByMaTaiKhoan(mataikhoan);
        }

        public ArrayList GetDanhSachLopHocThamGiaByMaTaiKhoan(string mataikhoan)
        {
            return lopDAO.GetDanhSachLopHocThamGiaByMaTaiKhoan(mataikhoan);
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

      
    }
}

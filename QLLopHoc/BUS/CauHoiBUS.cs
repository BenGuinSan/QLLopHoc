using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.Comparer;

namespace QLLopHoc.BUS
{
    public class CauHoiBUS
    {
        private ArrayList list;
        private CauHoiDAO cauhoiDAO;
        public CauHoiBUS()
        {
            cauhoiDAO = new CauHoiDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = cauhoiDAO.loadList();
            list.Sort();
        }

        public ArrayList GetDanhSachCauHoiByMaTaiKhoan(string mataikhoan)
        {
            return cauhoiDAO.GetDanhSachCauHoiByMaTaiKhoan(mataikhoan);
        }
        public CauHoiDTO getCauhoiWithMaCauHoi(string macauhoi)
        {
            CauHoiComparer comparer = new CauHoiComparer();
            comparer.TypeToCompare = CauHoiComparer.ComparisonType.macauhoi;
            CauHoiDTO chSearch = new CauHoiDTO();
            chSearch.Macauhoi = macauhoi;
            int index = list.BinarySearch(chSearch, comparer);
            return (CauHoiDTO)list[index];
        }

        public bool ThemCauHoi(CauHoiDTO cauhoi)
        {
            if (cauhoiDAO.ThemCauHoi(cauhoi))
            {
                this.list.Add(cauhoi);
                return true;
            }
            return false;
        }

        public void XoaCauHoi(CauHoiDTO cauhoi)
        {
            foreach (CauHoiDTO ch in this.list)
            {
                if (ch.Macauhoi.Equals(cauhoi.Macauhoi))
                {
                    ch.Daxoa = 1;
                    break;
                }
            }
            cauhoiDAO.XoaCauHoi(cauhoi.Macauhoi);
        }

        public bool SuaCauHoi(CauHoiDTO cauhoi)
        {
            if (cauhoiDAO.SuaCauHoi(cauhoi))
            {
                foreach (CauHoiDTO ch in this.list)
                {
                    if (ch.Macauhoi.Equals(cauhoi.Macauhoi))
                    {
                        ch.Noidung = cauhoi.Noidung;
                        ch.Daxoa = cauhoi.Daxoa;
                        break;
                    }
                }
                return true;
            }
            else
                return false;
        }

        public ArrayList TimKiemCauHoiThuocTaiKhoan(string tukhoa, string mataikhoan)
        {
            ArrayList resultlist = new ArrayList();
            foreach (CauHoiDTO cauhoi in GetDanhSachCauHoiByMaTaiKhoan(mataikhoan))
            {
                if (cauhoi.Noidung.ToLower().Contains(tukhoa.ToLower()) && cauhoi.Mataikhoan.Equals(mataikhoan) && cauhoi.Daxoa == 0)
                {
                    resultlist.Add(cauhoi);
                }
            }
            return resultlist;
        }

        public CauHoiDTO GetCauHoiByMaCauHoi(string macauhoi)
        {
            CauHoiDTO cauhoi = null;
            foreach (CauHoiDTO ch in this.list)
            {
                if (ch.Macauhoi.Equals(macauhoi))
                    return ch;
            }
            return cauhoi;
        }
    }
}

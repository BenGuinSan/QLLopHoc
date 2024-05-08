using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DAO;
using QLLopHoc.DTO;

namespace QLLopHoc.BUS
{
    public class DeKiemTraBUS
    {
        private ArrayList list;
        private DeKiemTraDAO dektDAO;
        public DeKiemTraBUS()
        {
            dektDAO = new DeKiemTraDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }

        public void loadList()
        {
            list = dektDAO.loadList();
        }
        public ArrayList GetDanhSachDeKiemTraTheoMaChuong(string machuong, string tukhoa = "")
        {
            ArrayList rslist = new ArrayList();
            foreach (DeKiemTraDTO dkt in this.list)
            {
                if (dkt.Machuong.Equals(machuong) && dkt.Tieude.ToLower().Contains(tukhoa.ToLower()) && dkt.Daxoa == 0)
                    rslist.Add(dkt);
            }
            return rslist;
        }
        public DeKiemTraDTO GetDeKiemTraByMaDe(string made)
        {
            foreach (DeKiemTraDTO dkt in this.list)
            {
                if (dkt.Madekiemtra.Equals(made))
                    return dkt;
            }
            return null;
        }

        public bool ThemDeKiemTra(DeKiemTraDTO dekiemtra)
        {
            if (dekiemtra == null) return false;
            if (dektDAO.ThemDeKiemTra(dekiemtra))
            {
                this.list.Add(dekiemtra);
                return true;
            }
            return false;
        }

        public bool SuaDeKiemTra(DeKiemTraDTO dkt)
        {
            if (dektDAO.SuaDeKiemTra(dkt))
            {
                foreach (DeKiemTraDTO d in this.list)
                {
                    if (d.Madekiemtra.Equals(dkt.Madekiemtra))
                    {
                        d.Thoigianbatdau = dkt.Thoigianbatdau;
                        d.Thoigianketthuc = dkt.Thoigianketthuc;
                        break;
                    }
                }
                return true;
            }
            else
                return false;
        }
        public bool XoaDeKiemTra(DeKiemTraDTO dekiemtra)
        {
            if (dektDAO.XoaDeKiemTra(dekiemtra))
            {
                foreach (DeKiemTraDTO dkt in this.list)
                {
                    if (dkt.Madekiemtra.Equals(dekiemtra.Madekiemtra))
                    {
                        dkt.Daxoa = 1;
                        return true;
                    }

                }
                return false;
            }
            else
                return false;
        }

        public ArrayList GetTatCaBaiKiemTraDaNopByMaLopHoc(string malophoc, string mataikhoan)
        {
            return dektDAO.GetTatCaBaiKiemTraDaNopByMaLopHoc(malophoc, mataikhoan);
        }
        public ArrayList GetTatCaBaiKiemTraChuaNopByMaLopHoc(string malophoc)
        {
            return dektDAO.GetTatCaBaiKiemTraChuaNopByMaLopHoc(malophoc);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.Comparer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLLopHoc.BUS
{
    public class ChuongBUS
    {
        private ArrayList list;
        private ChuongDAO chuongDAO;

        public ChuongBUS()
        {
            chuongDAO = new ChuongDAO();
            loadList();
        }

        // lay toan bo danh sach chuong
        public void loadList()
        {
            list = chuongDAO.loadList();
            list.Sort();
        }
        public bool ThemChuong(ChuongDTO chuong)
        {
            if (chuongDAO.ThemChuong(chuong))
            {
                this.list.Add(chuong);
                return true;
            }
            return false;
        }
        public bool SuaChuong(ChuongDTO chuong)
        {
            if (chuongDAO.SuaChuong(chuong))
            {
                foreach (ChuongDTO c in this.list)
                {
                    if (c.Machuong.Equals(chuong.Machuong))
                    {
                        c.Tenchuong = chuong.Tenchuong;
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
        public bool XoaChuong(ChuongDTO chuong)
        {
            if (chuongDAO.XoaChuong(chuong.Machuong))
            {
                foreach (ChuongDTO c in this.list)
                {
                    if (c.Machuong.Equals(chuong.Machuong))
                    {
                        c.Daxoa = 1;
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        public ChuongDTO getChuongWithMaChuong(string machuong)
        {
            ChuongComparer comparer = new ChuongComparer();
            comparer.TypeToCompare = ChuongComparer.ComparisonType.machuong;
            ChuongDTO chuongSearch = new ChuongDTO();
            chuongSearch.Machuong = machuong.ToLower();
            int index = list.BinarySearch(chuongSearch, comparer);
            return (ChuongDTO)list[index];
        }

        public ArrayList getChuongWithMaLop(string malop)
        {
            ArrayList listchuong = new ArrayList();
            loadList();
            foreach (ChuongDTO ch in list)
            {
                if (ch.Malop.Equals(malop))
                    listchuong.Add(ch);
            }
            return listchuong;
        }

    }
}

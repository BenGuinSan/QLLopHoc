using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DAO;
using QLLopHoc.DTO;

namespace QLLopHoc.BUS
{
    public class ThamGiaBUS
    {
        private ArrayList list;
        private ThamGiaDAO thamgiaDAO;
        ThamGiaDAO thamgialophocDAO = new ThamGiaDAO();
        DataTable dt = new DataTable();

        public ThamGiaBUS()
        {
            thamgiaDAO = new ThamGiaDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = thamgiaDAO.loadList();
            //list.Sort();
        }

        public bool ThemThamGia(ThamGiaDTO thamgia)
        {
            if (thamgiaDAO.ThemThamGia(thamgia))
            {
                list.Add(thamgia);
                return true;
            }
            else
                return false;
        }

        public bool KtraDaThamGia(ThamGiaDTO thamgia)
        {
            foreach (ThamGiaDTO tg in this.list)
            {
                if (tg.Malop.Equals(thamgia.Malop) && tg.Mataikhoan.Equals(thamgia.Mataikhoan))
                    return true;
            }
            return false;
        }

    }
}

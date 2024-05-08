using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;

namespace QLLopHoc.BUS
{
    public class BaiTapBUS
    {
        private ArrayList list;
        private BaiTapDAO btDAO;
        public BaiTapBUS()
        {
            btDAO = new BaiTapDAO();
            loadList();
        }

        public void loadList()
        {
            list = btDAO.loadList();
            BaiTapComparer comparer = new BaiTapComparer();
            comparer.TypeToCompare = BaiTapComparer.ComparisonType.mabaitap;
            list.Sort(comparer);
        }

        public ArrayList GetDanhSachBaiTapTheoMaChuong(string machuong, string tukhoa = "")
        {
            ArrayList btlist = new ArrayList();
            foreach (BaiTapDTO bt in this.list)
            {
                if (bt.Machuong.Equals(machuong) && bt.Tieude.ToLower().Contains(tukhoa.ToLower()) && bt.Daxoa == 0)
                    btlist.Add(bt);
            }
            return btlist;
        }

        public bool createBaitap(BaiTapDTO bt)
        {
            if (btDAO.createBaiTap(bt))
            {
                this.list.Add(bt);
                return true;
            }
            return false;
        }

        public bool EditBaitap(BaiTapDTO bt)
        {
            if (btDAO.EditBaiTap(bt))
            {
                BaiTapComparer comparer = new BaiTapComparer
                {
                    TypeToCompare = BaiTapComparer.ComparisonType.mabaitap
                };
                BaiTapDTO tmp = new BaiTapDTO
                {
                    Mabaitap = bt.Mabaitap
                };
                int index = this.list.BinarySearch(tmp, comparer);
                if (index < 0) return false;
                this.list.RemoveAt(index);
                this.list.Add(bt);
                return true;
            }
            return false;
        }
        public bool deleteBaitap(string mabaitap)
        {
            if (btDAO.DeleteBaiTapByMaBaiTap(mabaitap))
            {
                BaiTapComparer comparer = new BaiTapComparer();
                comparer.TypeToCompare = BaiTapComparer.ComparisonType.mabaitap;
                BaiTapDTO bt = new BaiTapDTO();
                bt.Mabaitap = mabaitap;
                int index = this.list.BinarySearch(bt, comparer);
                if (index < 0) return true;
                this.list.RemoveAt(index);
                return true;
            }
            return false;
        }
        public bool DeleteBaitapByChangeState(string mabaitap)
        {
            if (btDAO.DeleteBaiTapByChangeState(mabaitap))
            {
                BaiTapComparer comparer = new BaiTapComparer();
                comparer.TypeToCompare = BaiTapComparer.ComparisonType.mabaitap;
                BaiTapDTO bt = new BaiTapDTO
                {
                    Mabaitap = mabaitap
                };
                int index = this.list.BinarySearch(bt, comparer);
                if (index < 0) return true;
                (this.list[index] as BaiTapDTO).Daxoa = 1;
                return true;
            }
            return false;
        }
        public BaiTapDTO GetBaiTapByMaBaiTap(string mabaitap)
        {
            foreach (BaiTapDTO bt in this.list)
            {
                if (bt.Mabaitap.Equals(mabaitap))
                    return bt;
            }
            return null;
        }
        public ArrayList GetTatCaBaiTapDaNopByMaLopHoc(string malophoc, string mataikhoan)
        {
            return btDAO.GetTatCaBaiTapDaNopByMaLopHoc(malophoc, mataikhoan);
        }
        public ArrayList GetTatCaBaiTapChuaNopByMaLopHoc(string malophoc)
        {
            return btDAO.GetTatCaBaiTapChuaNopByMaLopHoc(malophoc);

        }
    }
}

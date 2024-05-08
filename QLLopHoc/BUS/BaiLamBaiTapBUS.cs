using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;

namespace QLLopHoc.BUS
{
    public class BaiLamBaiTapBUS
    {
        private ArrayList list;
        private BaiLamBaiTapDAO bailambtDAO;
        private BaiTapBUS btbus;

        public ArrayList List { get => list; set => list = value; }

        public BaiLamBaiTapBUS()
        {
            bailambtDAO = new BaiLamBaiTapDAO();
            btbus = new BaiTapBUS();
            loadList();
        }
        public void loadList()
        {
            list = bailambtDAO.loadList();
            BaiLamBaiTapComparer comparer = new BaiLamBaiTapComparer();
            comparer.TypeToCompare = BaiLamBaiTapComparer.ComparisonType.mabailam;
            list.Sort(comparer);
        }
        public int GetBaiLamBaiTapWithMaBaiLam(string mabailam)
        {
            BaiLamBaiTapComparer comparer = new BaiLamBaiTapComparer();
            comparer.TypeToCompare = BaiLamBaiTapComparer.ComparisonType.mabailam;
            BaiLamBaiTapDTO blbtSearch = new BaiLamBaiTapDTO();
            blbtSearch.Mabailam = mabailam.ToLower();
            int index = list.BinarySearch(blbtSearch, comparer);
            return index;
        }

        public Dictionary<float, int> ThongKePhoDiemTheoMaBaiTap(string mabt)
        {
            Dictionary<float, int> rslist = new Dictionary<float, int>();
            List<float> diemList = new List<float>();
            foreach (BaiLamBaiTapDTO b in this.list)
            {
                if (b.Mabaitap.Equals(mabt) && b.Diem != -1)
                {
                    diemList.Add(b.Diem);
                }
            }
            foreach (float diem in diemList)
            {
                if (rslist.ContainsKey(diem))
                {
                    rslist[diem]++;
                }
                else
                {
                    rslist[diem] = 1;
                }
            }
            return rslist;
        }

        public Dictionary<string, float> ThongKePhoDiemTheoMaTaiKhoan(string matk)
        {
            Dictionary<string, float> rslist = new Dictionary<string, float>();
            foreach (BaiLamBaiTapDTO blbt in this.list)
            {
                if (blbt.Mataikhoan.Equals(matk) && blbt.Diem != -1 && btbus.GetBaiTapByMaBaiTap(blbt.Mabaitap).Congkhaidapan == 1)
                {
                    rslist.Add(blbt.Mabaitap, blbt.Diem);
                }
            }
            return rslist;
        }

        public DataTable ThongKeDiemThongKeDiemHocSinhTheoMaBaiTap(string mabaitap)
        {
            return bailambtDAO.ThongKeDiemHocSinhTheoMaBaiTap(mabaitap);
        }
        public DataTable ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(string mataikhoan, string machuong)
        {
            return bailambtDAO.ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(mataikhoan, machuong);
        }
        public int GetBaiLamBaiTapWithMaTaiKhoanAndMaBaiTap(string mataikhoan, string mabaitap)
        {
            int index = 0;
            foreach (BaiLamBaiTapDTO blbt in this.list)
            {
                if (blbt.Mataikhoan.Equals(mataikhoan) && blbt.Mabaitap.Equals(mabaitap))
                    return index;
                else
                    index++;
            }
            return -1;
        }

        public bool CreateBaiLamBaiTap(BaiLamBaiTapDTO blbt)
        {
            if (bailambtDAO.CreateBaiLamBaiTap(blbt))
            {
                this.list.Add(blbt);
                return true;
            }
            return false;
        }
        public bool DeleteBaiLamBaiTap(string mabailam)
        {
            if (bailambtDAO.DeleteBaiLamBaiTapByMaBaiLam(mabailam))
            {
                BaiLamBaiTapComparer comparer = new BaiLamBaiTapComparer();
                comparer.TypeToCompare = BaiLamBaiTapComparer.ComparisonType.mabailam;
                BaiLamBaiTapDTO blbt = new BaiLamBaiTapDTO();
                blbt.Mabailam = mabailam;
                int index = this.list.BinarySearch(blbt, comparer);
                if (index < 0) return true;
                this.list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool ChamDiemBaiLamBaiTap(BaiLamBaiTapDTO blbt)
        {
            if (bailambtDAO.ChamDiemBaiLamBaiTap(blbt))
            {
                int index = GetBaiLamBaiTapWithMaBaiLam(blbt.Mabailam);
                if (index < 0) return false;
                (this.list[index] as BaiLamBaiTapDTO).Diem = blbt.Diem;
                (this.list[index] as BaiLamBaiTapDTO).Nhanxet = blbt.Nhanxet;
                return true;
            }
            return false;
        }
    }
}

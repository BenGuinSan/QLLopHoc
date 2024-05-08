using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.Comparer;

namespace QLLopHoc.BUS
{
    public class ChiTietBaiLamKiemTraBUS
    {
        private ArrayList list;
        private ChiTietBaiLamKiemTraDAO blktDAO;
        public ChiTietBaiLamKiemTraBUS()
        {
            blktDAO = new ChiTietBaiLamKiemTraDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = blktDAO.loadList();
            //list.Sort();
        }
        public void AddChiTietBaiLam(ArrayList chitietbailam)
        {
            try
            {
                blktDAO.addChiTietBaiLamKiemTra(chitietbailam);
                list.Add(chitietbailam);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file chitietbailamkiemtraBUS:" + ex.Message);
                return;
            }
        }

        public ArrayList GetChiTietBaiLamKiemTraWithMaBaiLam(string mabailamkiemtra)
        {
            ArrayList listctblkt = new ArrayList();
            foreach (ChiTietBaiLamKiemTraDTO item in list)
            {
                if (item.Mabailamkiemtra.Equals(mabailamkiemtra))
                    listctblkt.Add(item);
            }
            ChiTietBaiLamKiemTraComparer comparer = new ChiTietBaiLamKiemTraComparer();
            comparer.TypeToCompare = ChiTietBaiLamKiemTraComparer.ComparisonType.sothutu;
            listctblkt.Sort(comparer);
            return listctblkt;
        }
    }
}


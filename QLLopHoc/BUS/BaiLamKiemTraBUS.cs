﻿using System;
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
    public class BaiLamKiemTraBUS
    {
        private ArrayList list;
        private BaiLamKiemTraDAO blktDAO;
        private DeKiemTraBUS dktbus;

        public ArrayList List { get => list; set => list = value; }

        public BaiLamKiemTraBUS()
        {
            blktDAO = new BaiLamKiemTraDAO();
            dktbus = new DeKiemTraBUS();
            loadList();
        }
        public void loadList()
        {
            List = blktDAO.loadList();
        }
        public bool addBaiLam(BaiLamKiemTra bldkt)
        {
            if (blktDAO.addBaiLamKiemTra(bldkt) == 0)
                return false;
            else
            {
                List.Add(bldkt);
                return true;
            }
        }
        public int getBaiLamKiemTraWithMaTaiKhoanAndMaDeKiemTra(string mataikhoan, string madekiemtra)
        {
            int index = 0;
            foreach (BaiLamKiemTra blkt in List)
            {
                if (blkt.Mataikhoan.Equals(mataikhoan) && blkt.Madekiemtra.Equals(madekiemtra))
                    return index;
                else
                    index++;
            }
            return -1;
        }
        public int isSubmited(string mataikhoan, string madekiemtra)
        {
            foreach (BaiLamKiemTra blkt in List)
            {
                if (blkt.Mataikhoan.Equals(mataikhoan) && blkt.Madekiemtra.Equals(madekiemtra))
                    return 1;
            }
            return 0;
        }
        public Dictionary<float, int> ThongKePhoDiemTheoMaDeKiemTra(string madkt)
        {
            Dictionary<float, int> rslist = new Dictionary<float, int>();
            List<float> diemList = new List<float>();
            foreach (BaiLamKiemTra b in this.list)
            {
                if (b.Madekiemtra.Equals(madkt))
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
            foreach (BaiLamKiemTra blkt in this.list)
            {
                if (blkt.Mataikhoan.Equals(matk) && dktbus.GetDeKiemTraByMaDe(blkt.Madekiemtra).Xemdapan != 0)
                {
                    rslist.Add(blkt.Madekiemtra, blkt.Diem);
                }
            }
            return rslist;
        }

        public DataTable ThongKeDiemHocSinhTheoMaDeKiemTra(string madkt)
        {
            return blktDAO.ThongKeDiemHocSinhTheoMaDeKiemTra(madkt);
        }

        public DataTable ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(string mataikhoan, string machuong)
        {
            return blktDAO.ThongKeDiemHocSinhTheoMaTaiKhoanVaMaChuong(mataikhoan, machuong);
        }
    }
}

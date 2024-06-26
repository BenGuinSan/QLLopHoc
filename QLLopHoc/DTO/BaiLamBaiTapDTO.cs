﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class BaiLamBaiTapDTO /*: IComparable*/
    {
        private string mabailam;
        private string mataikhoan;
        private string mabaitap;
        private string noidung;
        private DateTime thoigiannopbai;
        private float diem;
        private string nhanxet;
        private int noptre;

        public BaiLamBaiTapDTO() { }

        public BaiLamBaiTapDTO(string mabailam, string noidung, DateTime thoigiannopbai, float diem, string nhanxet, string mataikhoan, string mabaitap, int noptre)
        {
            this.Mabailam = mabailam;
            this.Noidung = noidung;
            this.Thoigiannopbai = thoigiannopbai;
            this.Diem = diem;
            this.Nhanxet = nhanxet;
            this.Mataikhoan = mataikhoan;
            this.Mabaitap = mabaitap;
            this.Noptre = noptre;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public DateTime Thoigiannopbai { get => thoigiannopbai; set => thoigiannopbai = value; }
        public float Diem { get => diem; set => diem = value; }
        public string Nhanxet { get => nhanxet; set => nhanxet = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Mabaitap { get => mabaitap; set => mabaitap = value; }
        public int Noptre { get => noptre; set => noptre = value; }

        public int CompareTo(object obj)
        {
            return mabailam.CompareTo(obj);
        }
        public int CompareTo(BaiLamBaiTapDTO c1, BaiLamBaiTapComparer.ComparisonType type)
        {
            switch (type)
            {
                case BaiLamBaiTapComparer.ComparisonType.mabailam:
                    return this.mabailam.CompareTo(c1.mabailam);
                case BaiLamBaiTapComparer.ComparisonType.mabaitap:
                    return this.mabaitap.CompareTo(c1.mabaitap);
                case BaiLamBaiTapComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
            }
            return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLopHoc.DTO
{
    public class BaiLamKiemTra : IComparable
    {
        private string mabailam;
        private string madekiemtra;
        private string mataikhoan;
        private float diem;
        private DateTime thoigiannop;
        private int socaudung;
        private int noptre;

        public BaiLamKiemTra() { }
        public BaiLamKiemTra(string mabailam, float diem, DateTime thoigianvaokiemtra, DateTime thoigiannop, int socaudung, string mataikhoan, int noptre, string madekiemtra)
        {
            this.Mabailam = mabailam;
            this.Diem = diem;
            this.Thoigiannop = thoigiannop;
            this.Socaudung = socaudung;
            this.Mataikhoan = mataikhoan;
            this.noptre = noptre;
            this.madekiemtra = madekiemtra;
        }

        public string Mabailam { get => mabailam; set => mabailam = value; }
        public float Diem { get => diem; set => diem = value; }
        public DateTime Thoigiannop { get => thoigiannop; set => thoigiannop = value; }
        public int Socaudung { get => socaudung; set => socaudung = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public int Noptre { get => noptre; set => noptre = value; }
        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Mã bài làm: {mabailam}\n" +
                   $"Mã đề kiểm tra: {madekiemtra}\n" +
                   $"Điểm: {diem}\n" +
                   $"Thời gian nộp: {thoigiannop}\n" +
                   $"Số câu đúng: {socaudung}\n" +
                   $"Nộp trễ: {noptre}\n" +
                   $"Mã tài khoản: {mataikhoan}";
        }
        /*public int CompareTo(object obj)
        {
            BaiLamKiemTra blkt = (BaiLamKiemTra)obj;
            return this.mabailam.CompareTo(blkt.Mabailam);
        }
        public int CompareTo(BaiLamKiemTra c1, BailamkiemtraComparer.ComparisonType type)
        {
            switch (type)
            {
                case BailamkiemtraComparer.ComparisonType.mabailam:
                    return this.mabailam.CompareTo(c1.Mabailam);
                case BailamkiemtraComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
            }
            return 0;
        }*/
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class ChuongDTO : IComparable
    {
        private string machuong;
        private string malop;
        private string tenchuong;
        private DateTime thoigiantao;
        private int daxoa;

        public ChuongDTO() { }
        public ChuongDTO(string machuong, string tenchuong, DateTime thoigiantao, string malop, int daxoa)
        {
            this.machuong = machuong;
            this.tenchuong = tenchuong;
            this.thoigiantao = thoigiantao;
            this.malop = malop;
            this.daxoa = daxoa;
        }

        public string Machuong { get => machuong; set => machuong = value; }
        public string Tenchuong { get => tenchuong; set => tenchuong = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public string Malop { get => malop; set => malop = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public int CompareTo(Object obj)
        {
            ChuongDTO chuong = (ChuongDTO)obj;
            return this.machuong.CompareTo(chuong.machuong);
        }
        public int CompareTo(ChuongDTO c1, ChuongComparer.ComparisonType type)
        {
            switch (type)
            {
                case ChuongComparer.ComparisonType.machuong:
                    return this.Machuong.CompareTo(c1.Machuong);
                case ChuongComparer.ComparisonType.tenchuong:
                    return this.tenchuong.CompareTo(c1.tenchuong);
            }
            return 0;
        }
    }
}

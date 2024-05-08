using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class CauHoiDTO : IComparable
    {
        private string macauhoi;
        private string mataikhoan;
        private string noidung;
        private int daxoa;

        public CauHoiDTO() { }

        public CauHoiDTO(string macauhoi, string noidung, string mataikhoan, int daxoa)
        {
            this.macauhoi = macauhoi;
            this.noidung = noidung;
            this.mataikhoan = mataikhoan;
            this.Daxoa = daxoa;
        }

        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }

        public int CompareTo(object obj)
        {
            CauHoiDTO ch = (CauHoiDTO)obj;
            return this.macauhoi.CompareTo(ch.macauhoi);
        }
        public int CompareTo(CauHoiDTO c1, CauHoiComparer.ComparisonType type)
        {
            switch (type)
            {
                case CauHoiComparer.ComparisonType.macauhoi:
                    return this.macauhoi.CompareTo(c1.macauhoi);
                case CauHoiComparer.ComparisonType.mataikhoan:
                    return this.mataikhoan.CompareTo(c1.mataikhoan);
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class CauTraLoiDTO : IComparable
    {
        private string macautraloi;
        private string macauhoi;
        private string noidung;
        private int ladapan;

        public CauTraLoiDTO(string macautraloi = "", string noidung = "", int ladapan = 0, string macauhoi = "")
        {
            this.Macautraloi = macautraloi;
            this.Noidung = noidung;
            this.Ladapan = ladapan;
            this.Macauhoi = macauhoi;
        }

        public string Macautraloi { get => macautraloi; set => macautraloi = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public int Ladapan { get => ladapan; set => ladapan = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }

        public int CompareTo(Object obj)
        {
             CauTraLoiDTO chuong = (CauTraLoiDTO)obj;
             return this.macautraloi.CompareTo(chuong.macautraloi);
        }

        public int CompareTo(CauTraLoiDTO c1, CauTraLoiComparer.ComparisonType type)
        {
             switch (type)
            {
             case CauTraLoiComparer.ComparisonType.macauhoi:
                return this.Macauhoi.CompareTo(c1.macauhoi);
             case CauTraLoiComparer.ComparisonType.macautraloi:
                return this.macautraloi.CompareTo(c1.macautraloi);
            }
            return 0;
        }
    }
}

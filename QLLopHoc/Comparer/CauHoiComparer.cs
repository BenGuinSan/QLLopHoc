using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class CauHoiComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            macauhoi, mataikhoan
        }

        public int Compare(object i, object j)
        {
            CauHoiDTO left = (CauHoiDTO)i;
            CauHoiDTO right = (CauHoiDTO)j; ;
            return left.CompareTo(right, typeToCompare);

        }
    }
}

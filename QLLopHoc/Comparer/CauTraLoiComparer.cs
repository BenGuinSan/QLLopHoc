using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class CauTraLoiComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            macautraloi, macauhoi
        }

        public int Compare(object i, object j)
        {
            CauTraLoiDTO left = (CauTraLoiDTO)i;
            CauTraLoiDTO right = (CauTraLoiDTO)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}

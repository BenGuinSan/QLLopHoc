using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class BaiTapComparer:IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mabaitap
        }

        public int Compare(object i, object j)
        {
            BaiTapDTO left = (BaiTapDTO)i;
            BaiTapDTO right = (BaiTapDTO)j;
            return left.CompareTo(right, typeToCompare);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class HocLieuComparer: IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mahoclieu
        }

        public int Compare(object i, object j)
        {
            HocLieuDTO left = (HocLieuDTO)i;
            HocLieuDTO right = (HocLieuDTO)j;
            return left.CompareTo(right,  typeToCompare);
        }
    }
}

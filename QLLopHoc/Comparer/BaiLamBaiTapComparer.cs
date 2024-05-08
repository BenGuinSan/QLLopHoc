using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class BaiLamBaiTapComparer: IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mabailam, mataikhoan, mabaitap
        }

        public int Compare(object i, object j)
        {
            BaiLamBaiTapDTO left = (BaiLamBaiTapDTO)i;
            BaiLamBaiTapDTO right = (BaiLamBaiTapDTO)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}

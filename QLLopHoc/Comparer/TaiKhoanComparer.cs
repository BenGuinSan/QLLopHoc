using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class TaiKhoanComparer : IComparer<TaiKhoan>
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            mataikhoan, manhomquyen
        }

        public int Compare(TaiKhoan x, TaiKhoan y)
        {
            TaiKhoan left = x;
            TaiKhoan right = y;
            return left.CompareTo(right, typeToCompare);
        }
    }
}

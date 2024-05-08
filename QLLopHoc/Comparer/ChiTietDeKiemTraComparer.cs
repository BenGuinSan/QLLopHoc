using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class ChiTietDeKiemTraComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            sothutu
        }

        public int Compare(object i, object j)
        {
            ChiTietDeKiemTraDTO left = (ChiTietDeKiemTraDTO)i;
            ChiTietDeKiemTraDTO right = (ChiTietDeKiemTraDTO)j;
            return left.CompareTo(right);
        }
    }
}

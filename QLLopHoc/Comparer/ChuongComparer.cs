using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using QLLopHoc.DTO;

namespace QLLopHoc.Comparer
{
    public class ChuongComparer : IComparer
    {
        private ComparisonType typeToCompare;

        public ComparisonType TypeToCompare { get => typeToCompare; set => typeToCompare = value; }

        public enum ComparisonType
        {
            machuong, tenchuong
        }

        public int Compare(object i, object j)
        {
            ChuongDTO left = (ChuongDTO)i;
            ChuongDTO right = (ChuongDTO)j;
            return left.CompareTo(right, typeToCompare);

        }
    }
}

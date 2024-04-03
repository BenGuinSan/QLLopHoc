using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class LopHocDTO : IComparable
    {
        private string malop;
        private string tenlop;
        private string magiangvien;
        private string mota;
        private string avatar;
        private int daxoa;

        public LopHocDTO() { }

        public LopHocDTO(string malop, string tenlop, string mota, string avatar, string magiangvien, int daxoa)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;
            this.Mota = mota;
            this.Avatar = avatar;
            this.Magiangvien = magiangvien;
            this.Daxoa = daxoa;
        }

        public string Magiangvien { get => magiangvien; set => magiangvien = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }

        public int CompareTo(Object obj)
        {
            LopHocDTO chuong = (LopHocDTO)obj;
            return Malop.CompareTo(chuong.Malop);
        }

        public int CompareTo(LopHocDTO c1, LopHocComparer.ComparisonType type)
        {
            switch (type)
            {
                case LopHocComparer.ComparisonType.malophoc:
                    return this.Malop.CompareTo(c1.Malop);
                case LopHocComparer.ComparisonType.tenlophoc:
                    return this.Tenlop.CompareTo(c1.Tenlop);
            }
            return 0;
        }

    }
}

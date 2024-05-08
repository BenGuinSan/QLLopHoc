using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;

namespace QLLopHoc.DTO
{
    public class HocLieuDTO: IComparable
    {
        private string mahoclieu;
        private string machuong;
        private string tieude;
        private string noidung;
        private int daxoa;
        private DateTime thoigiantao;

        public HocLieuDTO(string mahoclieu = "", string tieude = "", string noidung = "", string machuong = "", int daxoa = 0, DateTime thoigiantao = default)
        {
            this.mahoclieu = mahoclieu;
            this.tieude = tieude;
            this.noidung = noidung;
            this.machuong = machuong;
            this.daxoa = daxoa;
            this.thoigiantao = thoigiantao;
        }

        public string Mahoclieu { get => mahoclieu; set => mahoclieu = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Machuong { get => machuong; set => machuong = value; }
        public int Daxoa { get => daxoa; set => daxoa = value; }
        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }

        public int CompareTo(Object obj)
        {
            HocLieuDTO Hoclieu = (HocLieuDTO)obj;
            return this.Mahoclieu.CompareTo(Hoclieu.Mahoclieu);
        }

        public int CompareTo(HocLieuDTO c1, HocLieuComparer.ComparisonType type)
        {
            switch (type)
            {
                case HocLieuComparer.ComparisonType.mahoclieu:
                    return this.mahoclieu.CompareTo(c1.mahoclieu);
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLopHoc.DTO
{
    public class ChiTietDeKiemTraDTO : IComparable
    {
        private string madekiemtra;
        private string macauhoi;
        private int thutu;

        public ChiTietDeKiemTraDTO(string madekiemtra = "", string macauhoi = "", int thutu = 0)
        {
            this.madekiemtra = madekiemtra;
            this.macauhoi = macauhoi;
            this.thutu = thutu;
        }

        public string Madekiemtra { get => madekiemtra; set => madekiemtra = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public int Thutu { get => thutu; set => thutu = value; }
        public int CompareTo(Object obj)
        {
            ChiTietDeKiemTraDTO chuong = (ChiTietDeKiemTraDTO)obj;
            return this.thutu.CompareTo(chuong.thutu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLopHoc.DTO
{
    public class ChiTietBaiLamKiemTraDTO
    {
        private string mabailamkiemtra;
        private string macauhoi;
        private string dapanchon;
        private int thutu;

        public ChiTietBaiLamKiemTraDTO(string mabailamkiemtra = "", string macauhoi = "", string dapanchon = "", int thutu = 0)
        {
            this.mabailamkiemtra = mabailamkiemtra;
            this.macauhoi = macauhoi;
            this.dapanchon = dapanchon;
        }

        public string Mabailamkiemtra { get => mabailamkiemtra; set => mabailamkiemtra = value; }
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Dapanchon { get => dapanchon; set => dapanchon = value; }
        public int Thutu { get => thutu; set => thutu = value; }

        public int CompareTo(Object obj)
        {
            ChiTietBaiLamKiemTraDTO ctblkt = (ChiTietBaiLamKiemTraDTO)obj;
            return this.thutu.CompareTo(ctblkt.thutu);
        }
    }
}

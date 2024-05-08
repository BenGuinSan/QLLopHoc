using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using QLLopHoc.Comparer;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.GUI.Home.HomeComponents;

namespace QLLopHoc.BUS
{
    public class HocLieuBUS
    {
        List<string> file_local = new List<string>();
        List<FileHocLieu> list_filehl = new List<FileHocLieu>();
        FileHocLieuDAO filehl;
        HocLieuDAO HocLieuDAO = new HocLieuDAO();
        private ArrayList listhoclieu;


        public HocLieuBUS()
        {
            LoadList();
        }

        public void LoadList()
        {
            listhoclieu = HocLieuDAO.loadList();
        }

        public ArrayList GetDanhSachHocLieuTheoMaChuong(string machuong, string tukhoa = "")
        {
            ArrayList rslist = new ArrayList();
            foreach (HocLieuDTO hl in this.listhoclieu)
            {
                if (hl.Machuong.Equals(machuong) && hl.Tieude.ToLower().Contains(tukhoa.ToLower()) && hl.Daxoa == 0)
                    rslist.Add(hl);
            }
            return rslist;
        }
       

        public void SuaHocLieu(HocLieuDTO hoclieu)
        {
            HocLieuDAO.update_hoclieu(hoclieu);
            foreach (HocLieuDTO hl in this.listhoclieu)
            {
                if (hl.Mahoclieu.Equals(hoclieu.Mahoclieu))
                {
                    hl.Daxoa = hoclieu.Daxoa;
                    hl.Tieude = hoclieu.Tieude;
                    hl.Noidung = hoclieu.Noidung;
                    break;
                }
            }
        }

        public bool DeleteHocLieuByChangeState(string mahoclieu)
        {
            if (HocLieuDAO.DeleteHocLieuByChangeState(mahoclieu))
            {
                HocLieuComparer comparer = new HocLieuComparer();
                comparer.TypeToCompare = HocLieuComparer.ComparisonType.mahoclieu;
                HocLieuDTO hoclieu = new HocLieuDTO
                {
                    Mahoclieu = mahoclieu
                };

                int index = this.listhoclieu.BinarySearch(hoclieu, comparer);
                if (index < 0) return true;
                (this.listhoclieu[index] as HocLieuDTO).Daxoa = 1;
                return true;
            }
            return false;
        }

    }
}

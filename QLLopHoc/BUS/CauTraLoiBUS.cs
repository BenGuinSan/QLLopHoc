using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.Comparer;
using QLLopHoc.DTO;
using QLLopHoc.DAO;

namespace QLLopHoc.BUS
{
    public class CauTraLoiBUS
    {
        private ArrayList list;
        private CauTraLoiDAO cautlDAO;
        public CauTraLoiBUS()
        {
            cautlDAO = new CauTraLoiDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = cautlDAO.loadList();
            list.Sort();
        }
        public ArrayList getCauTraLoiWithMaCauHoi(string macauhoi)
        {
            ArrayList listcautraloi = new ArrayList();
            foreach (CauTraLoiDTO item in list)
            {
                if (item.Macauhoi.Equals(macauhoi))
                    listcautraloi.Add(item);
            }
            return listcautraloi;
        }
        public CauTraLoiDTO getCauTraLoiWithMaCauTraLoi(string macautraloi)
        {
            CauTraLoiComparer comparer = new CauTraLoiComparer();
            comparer.TypeToCompare = CauTraLoiComparer.ComparisonType.macautraloi;
            CauTraLoiDTO cauTraLoi = new CauTraLoiDTO();
            cauTraLoi.Macautraloi = macautraloi;
            int index = list.BinarySearch(cauTraLoi, comparer);
            return (CauTraLoiDTO)list[index];
        }
        public bool ThemCauTraLoi(CauTraLoiDTO cautraloi)
        {
            if (cautlDAO.ThemCauTraLoi(cautraloi))
            {
                this.list.Add(cautraloi);
                return true;
            }
            return false;
        }

        public bool SuaCauTraLoi(CauTraLoiDTO cautraloi)
        {
            if (cautlDAO.SuaCauTraLoi(cautraloi))
            {
                foreach (CauTraLoiDTO ctl in this.list)
                {
                    if (ctl.Macautraloi.Equals(cautraloi.Macautraloi))
                    {
                        ctl.Noidung = cautraloi.Noidung;
                        ctl.Ladapan = cautraloi.Ladapan;
                        break;
                    }
                }
                return true;
            }
            else
                return false;
        }

        public ArrayList GetDanhSachCauTraLoiByMaCauHoi(string macauhoi)
        {
            ArrayList resultList = new ArrayList();
            foreach (CauTraLoiDTO ctl in this.list)
            {
                if (ctl.Macauhoi.Equals(macauhoi))
                    resultList.Add(ctl);
            }
            return resultList;
        }
    }
}


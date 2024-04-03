using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLLopHoc.DAO;
using QLLopHoc.DTO;

namespace QLLopHoc.BUS
{
    public class NhomChatBUS
    {
        private ArrayList list;
        private NhomChatDAO nhomchatDAO;
        public NhomChatBUS()
        {
            nhomchatDAO = new NhomChatDAO();
            loadList();
        }

        public ArrayList getList()
        {
            return list;
        }
        public void loadList()
        {
            list = nhomchatDAO.loadList();
            //list.Sort();
        }

        public bool ThemNhomChat(NhomChatDTO nhomchat)
        {
            if (nhomchatDAO.ThemNhomChat(nhomchat))
            {
                list.Add(nhomchat);
                return true;
            }
            return false;
        }
    }
}

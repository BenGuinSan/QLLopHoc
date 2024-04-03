using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using QLLopHoc.DTO;

using System.Threading.Tasks;
using System.Windows;

namespace QLLopHoc.DAO
{
    public class NhomChatDAO
    {
        
        public NhomChatDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sql_get_all = "SELECT * FROM nhomchat";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhomChatDTO tmp = new NhomChatDTO();
                    tmp.Manhomchat = dr["manhomchat"].ToString();
                    tmp.Malop = dr["malophoc"].ToString();
                    tmp.Tennhomchat = dr["ten"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file NhomchatDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public bool ThemNhomChat(NhomChatDTO nhomchat)
        {
            try
            {
                string sql_themlophoc = "INSERT INTO nhomchat(manhomchat,malophoc,ten) VALUES (@manhomchat,@malophoc,N'" + nhomchat.Tennhomchat + "')";
                SqlCommand cmd_themlophoc = new SqlCommand(sql_themlophoc, DatabaseConnect.GetConnection());
                cmd_themlophoc.Parameters.AddWithValue("@manhomchat", Guid.Parse(nhomchat.Manhomchat));
                cmd_themlophoc.Parameters.AddWithValue("@malophoc", Guid.Parse(nhomchat.Malop));
                cmd_themlophoc.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file NhomchatDAO:" + ex.Message);
                return false;
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DTO;

namespace QLLopHoc.DAO
{
    public class FileHocLieuDAO
    {
        public FileHocLieuDAO()
        {
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM filehoclieu";
                SqlCommand cmd = new SqlCommand(sql_get_all, DatabaseConnect.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FileHocLieu tmp = new FileHocLieu();
                    tmp.Mahoclieu = dr["mahoclieu"].ToString();
                    tmp.Tenfile = dr["tenfile"].ToString();
                    tmp.Id_file = dr["id_file"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file filehoclieuDAO:" + ex.Message);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public List<FileHocLieu> get_list_filehoclieu(string mahoclieu)
        {
            List<FileHocLieu> list_filehl = new List<FileHocLieu>();
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Select * from filehoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        FileHocLieu temp = new FileHocLieu();
                        temp.Mahoclieu = reader["mahoclieu"].ToString();
                        temp.Tenfile = reader["tenfile"].ToString();
                        temp.Id_file = reader["id_file"].ToString();
                        list_filehl.Add(temp);
                    }
                }
            }
            return list_filehl;
        }

        public void drop_date_filehoclieu_mahoclieu(string mahoclieu)
        {
            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Delete from filehoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, connection))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
        public void insert_filehoclieu(FileHocLieu fileHocLieu)
        {
            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlstring = "INSERT INTO filehoclieu ([mahoclieu], [tenfile], [id_file]) VALUES (@mahoclieu, @tenfile, @id_file);";
                using (SqlCommand command = new SqlCommand(sqlstring, connection))
                {
                    command.Parameters.AddWithValue("@mahoclieu", fileHocLieu.Mahoclieu);
                    command.Parameters.AddWithValue("@tenfile", fileHocLieu.Tenfile);
                    command.Parameters.AddWithValue("@id_file", fileHocLieu.Id_file);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

    }
}

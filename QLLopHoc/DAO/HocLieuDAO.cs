using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using QLLopHoc.DTO;
using QLLopHoc.Comparer;

namespace QLLopHoc.DAO
{
    public class HocLieuDAO
    {
        public HocLieuDAO() { }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {
                string sqlQuery = "Select * From hoclieu";
                SqlCommand cmd = new SqlCommand(sqlQuery, DatabaseConnect.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    HocLieuDTO hoclieuDTO = new HocLieuDTO();
                    hoclieuDTO.Mahoclieu = dr["mahoclieu"].ToString();
                    hoclieuDTO.Machuong = dr["machuong"].ToString();
                    hoclieuDTO.Noidung = dr["noidung"].ToString();
                    hoclieuDTO.Tieude = dr["tieude"].ToString();
                    hoclieuDTO.Thoigiantao = Convert.ToDateTime(dr["thoigiantao"].ToString());
                    hoclieuDTO.Daxoa = Convert.ToInt32(dr["daxoa"].ToString());
                    listTmp.Add(hoclieuDTO);
                }
                dr.Close();
            }
            catch(Exception ex) {
                MessageBox.Show("Lỗi xảy ra ở file HocLieuDAO:" + ex.Message);
            }
            finally
            {
               DatabaseConnect.CloseConnection();
            }
            return listTmp;
        }

        public HocLieuDTO taohoclieu(string machuong, string tieude, string noidung, List<FileHocLieu> list_filehl)
        {
            Guid temp;
            DateTime thoigiantao = DateTime.Now;
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "INSERT INTO hoclieu (machuong, tieude, noidung, daxoa, thoigiantao) OUTPUT INSERTED.mahoclieu VALUES (@machuong, @tieude,@noidung, 0,@thoigiantao)";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@machuong", machuong);
                    command.Parameters.AddWithValue("@tieude", tieude);
                    command.Parameters.AddWithValue("@noidung", noidung);
                    command.Parameters.AddWithValue("@thoigiantao", thoigiantao);
                    temp = (Guid)command.ExecuteScalar();
                }
            }
            if (list_filehl != null)
                taofilehoclieu_tudong(temp, list_filehl);
            return new HocLieuDTO(temp.ToString(), tieude, noidung, machuong, 0, thoigiantao);
        }

        public void taofilehoclieu_tudong(Guid mahoclieu, List<FileHocLieu> list_filehl)
        {
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "INSERT INTO filehoclieu(mahoclieu, tenfile, id_file) VALUES(@mahoclieu, @tenfile, @id_file)";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    foreach (FileHocLieu fileHocLieu in list_filehl)
                    {
                        // Thay thế các giá trị thực tế của bạn vào tham số
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                        command.Parameters.AddWithValue("@tenfile", fileHocLieu.Tenfile);
                        command.Parameters.AddWithValue("@id_file", fileHocLieu.Id_file);

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public string get_tieude_mahoclieu(string mahoclieu)
        {
            string temp = null;
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Select tieude from hoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["tieude"].ToString();
                    }
                }
            }
            return temp;
        }
        public string get_noidung_mahoclieu(string mahoclieu)
        {
            string temp = null;
            using (SqlConnection conn = DatabaseConnect.GetConnection())
            {
                string sqlstring = "Select noidung from hoclieu where mahoclieu=@mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, conn))
                {
                    command.Parameters.AddWithValue("@mahoclieu", mahoclieu);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = reader["noidung"].ToString();
                    }
                }
            }
            return temp;
        }
      
        public void update_hoclieu(HocLieuDTO hoclieu)
        {
            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {
                string sqlstring = "UPDATE hoclieu SET  [tieude] = @tieude, [noidung] = @noidung, [daxoa] = @daxoa WHERE [mahoclieu] = @mahoclieu";
                using (SqlCommand command = new SqlCommand(sqlstring, connection))
                {
                    command.Parameters.AddWithValue("@mahoclieu", hoclieu.Mahoclieu);
                    command.Parameters.AddWithValue("@tieude", hoclieu.Tieude);
                    command.Parameters.AddWithValue("@noidung", hoclieu.Noidung);
                    command.Parameters.AddWithValue("@daxoa", hoclieu.Daxoa);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
       
        public bool DeleteHocLieuByChangeState(string mahoclieu)
        {
            try
            {
                string sql_delete = "UPDATE hoclieu SET daxoa=1 WHERE mahoclieu=@mahoclieu";
                SqlCommand command = new SqlCommand(sql_delete, DatabaseConnect.GetConnection());
                command.Parameters.Add("@mahoclieu", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mahoclieu);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file HocLieuDAO:" + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                DatabaseConnect.CloseConnection();
            }
            return true;
        }
    }
}

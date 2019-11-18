using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapGiuaKiMonKiemThu.ClassObject
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string StringConnection = "Data Source=DESKTOP-C5FJA28;Initial Catalog=PetStore;Integrated Security=True";

        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } private set => instance = value; }

        private DataProvider() { }
        public DataTable ExecuteQuery(string sqlcmd, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(StringConnection))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlcmd, conn);

                if (parameter != null)
                {
                    string[] listpara = sqlcmd.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                conn.Close();
            }

            return dt;
        }

        public int ExecuteNonQuery(string sqlcmd, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(StringConnection))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlcmd, conn);

                if (parameter != null)
                {
                    string[] listpara = sqlcmd.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                conn.Close();
            }

            return data;
        }

        public object ExecuteScalar(string sqlcmd, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(StringConnection))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlcmd, conn);

                if (parameter != null)
                {
                    string[] listpara = sqlcmd.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                conn.Close();
            }

            return data;
        }
    }
}

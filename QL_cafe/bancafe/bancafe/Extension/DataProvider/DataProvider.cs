using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancafe.Extension.DataProvider
{
	class DataProvider
	{
		string connection = @"Data Source=DESKTOP-VAB0L94;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

		public SqlConnection cn = new SqlConnection();
		public void kn_csdl()
		{
			cn.ConnectionString = connection;
			cn.Open();
		}
		private void dong_kn()
		{
			if (cn.State == ConnectionState.Open)
			{
				cn.Close();
			}
		}
		public DataTable ExcuteQuery(string procname, object[] parameter = null, List<string> listpara = null)
        {

            using (SqlConnection cnn = new SqlConnection(connection))
            {
                DataTable dt = new DataTable();
                try
                {
                    cnn.Open();
                    SqlCommand command = new SqlCommand(procname, cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameter != null)
                    {
                        for (int i = 0; i < parameter.Length; i++)
                        {
                            command.Parameters.AddWithValue(listpara[i], parameter[i]);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    dt = null;
                }

                return dt;
            }

        }
        public int ExcuteNoneQuery(string procname, object[] parameter = null, List<string> listpara = null)
        {
            using (SqlConnection cnn = new SqlConnection(connection))
            {
                int kq = 0;
                try
                {
                    cnn.Open();
                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(procname, cnn);
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameter != null)
                    {
                        for (int i = 0; i < parameter.Length; i++)
                        {
                            command.Parameters.AddWithValue(listpara[i], parameter[i]);
                        }
                    }
                    kq = command.ExecuteNonQuery();
                }
                catch
                {
                    kq = 0;
                }
                return kq;
            }
        }
	}
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class
{
    class Connection
    {
        private static Connection instance;

        internal static Connection Instance
        {
            get { if (instance == null) instance = new Connection(); return Connection.instance; }
            private set { Connection.instance = value; }
        }
        private Connection(){} 
        private String connectionStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";
        
        public DataTable ExecuteQuery(String query,object[] paramater=null)
        { 
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    String[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (String item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;

                        }
                    }
                }
                
               
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;


        }
        public int ExecuteNonQuery(String query, object[] paramater=null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    String[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (String item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;

                        }
                    }
                }
                data = command.ExecuteNonQuery();

                 
                connection.Close();
            }
            return data;


        }
        public object ExecuteScalar(String query, object[] paramater=null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    String[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (String item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;

                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;


        }


 
    }
}

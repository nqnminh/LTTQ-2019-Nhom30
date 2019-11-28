using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace frmMain.Class.Connect
{
    class Connection
    {
        public int i;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader data;
        public DataTable table;

        public static string constr = @"Data Source=QUOCMINH\SQLEXPRESS;Initial Catalog=QLKTX;Integrated Security=True";


        public void connecnhanvien(String query)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            command = new SqlCommand(query, connection);
            table = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(table);

            connection.Close();
        }
        public void loadAccount(String tk, string mk)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "select * from Account where username='" + tk + "' and password ='" + mk + "'";
            command = new SqlCommand(query, connection);
            data = command.ExecuteReader();
            if (data.Read() == true)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            connection.Close();
        }
        public int kn;
        public int kn1;
        public void ketnoi(string query, int i)
        {

            connection = new SqlConnection(constr);
            connection.Open();
            switch (i)
            {
                case 1:
                    {
                        command = new SqlCommand(query, connection);
                        if ((int)command.ExecuteScalar() == 1)
                        {
                            kn = 1;
                        }
                    }
                    break;
                case 2:
                    {
                        command = new SqlCommand(query, connection);
                        data = command.ExecuteReader();
                        if (data.Read() == true)
                        {
                            kn1 = 1;
                        }
                    }
                    break;
            }

            connection.Close();
        }
        public int a;
        public void taotaikhoan(String usename, String pass, String cauhoi, String traloi)
        {
            try
            {
                connection = new SqlConnection(constr);
                connection.Open();
                string query = "insert into Account (username,password,cauhoi,traloi) values ('" + usename + "','" + pass + "',N'" + cauhoi + "',N'" + traloi + "')";
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Tài khoản đã tồn tại !", "Lỗi tạo tài khoản");
                return;
            }
            MessageBox.Show("Tạo tài khoản mới thành công !", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
            connection.Close();
        }
        public int b;
        public void quenmatkhau(string usename)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "select COUNT(username) from Account where username='" + usename + "'";
            command = new SqlCommand(query, connection);
            command.ExecuteScalar();
            if ((int)command.ExecuteScalar() == 1)
            {
                b = 1;
            }
            connection.Close();
        }
        public string cauhoi;
        public string Atraloi;
        public string matkhau;
        public void resetmk(String user)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "update account set password='1962026656160185351301320480154111117132155' where username='" + user + "'";
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            matkhau = "1";
        }
        public void traloi(string usename)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "select cauhoi,traloi from Account where username='" + usename + "'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);
            cauhoi = table.Rows[0][0].ToString();
            Atraloi = table.Rows[0][1].ToString();
        }
    }
}

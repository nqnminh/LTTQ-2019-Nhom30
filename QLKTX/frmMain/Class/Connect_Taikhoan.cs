using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class
{
    public class Connect_Taikhoan
    {
        private static Connect_Taikhoan instance;

        public static Connect_Taikhoan Instance
        {
            get { if (instance == null) instance = new Connect_Taikhoan(); return instance; }
            private set { instance = value; }
        }
        private Connect_Taikhoan()
        {

        }
        public bool Login(String userName,String passWord){
            String query = "select * from tblNhanvien where Manv='"+userName+"' and Matkhau='"+passWord+"'";
            DataTable result = Connection.Instance.ExecuteQuery(query);
            return result.Rows.Count>0;
           
        }
        public bool loadForm(String user)
        {
            string query="select Quyenhan from tblNhanvien where Manv='"+user+"'";

            DataTable dt = Connection.Instance.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            return Convert.ToInt32(dr["Quyenhan"].ToString())>0;
        }



    }
}

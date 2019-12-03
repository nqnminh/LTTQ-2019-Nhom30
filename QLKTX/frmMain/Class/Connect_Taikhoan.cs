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
            string query="select * from tblNhanvien where Manv='"+user+"' and Quyenhan=1";

            DataTable dt = Connection.Instance.ExecuteQuery(query);
            return dt.Rows.Count>0;
            
        }
        public bool doimk(String manv, String pass ,String passnew)
        {
            string query = "update tblNhanvien set Matkhau= @MK where Manv= @MANV and Matkhau= @MATKHAU";
            int sul=Connection.Instance.ExecuteNonQuery(query,new object[]{passnew,manv,pass});
            return sul > 0;
        }



    }
}

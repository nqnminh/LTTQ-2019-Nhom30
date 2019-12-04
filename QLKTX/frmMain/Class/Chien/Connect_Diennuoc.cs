using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Chien
{
    public class Connect_Diennuoc
    {
        private static Connect_Diennuoc instance;

        public static Connect_Diennuoc Instance
        {
            get { if (instance == null) instance = new Connect_Diennuoc(); return Connect_Diennuoc.instance; }
            private set { Connect_Diennuoc.instance = value; }
        }
        private Connect_Diennuoc()
        {

        }
        public bool SaveDN(String makhu, int giadien,int gianuoc,int giaphong,int a ,String idmakhu)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblQuydinh (Makhu,Giadien,Gianuoc,Giaphong) " +
                    "values( @MAKHU , @GIADIEN , @GIANUOC , @GIAPHONG  )";
                    break;
                case 2: query = "UPDATE tblQuydinh set Giadien= @GIADIEN ,Gianuoc= @GIANUOC ,Giaphong= @GIAPHONG where Makhu= '"+idmakhu+"'";
                    break;
            }
            int sult = Connection.Instance.ExecuteNonQuery(query, new object[] {makhu,giadien,gianuoc,giaphong });
            return sult > 0;
        }
        public bool Dele(string iddn)
        {
            string query = "delete from tblQuydinh where Makhu= '"+iddn+"'";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { iddn });
            return result > 0;
        }
        public DataTable loadKhu()
        {
            string query = "select Makhu from tblKhu";
            DataTable dt = Connection.Instance.ExecuteQuery(query);
            return dt;
        }
    }

}

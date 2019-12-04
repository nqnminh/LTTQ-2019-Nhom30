using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Chien
{
    public class Connect_Khu
    {
        private static Connect_Khu instance;

        public static Connect_Khu Instance
        {
            get { if(instance == null ) instance=new Connect_Khu();return Connect_Khu.instance; }
           private set { Connect_Khu.instance = value; }
        }
        private Connect_Khu()
        {

        }
        public bool SaveK(string makhu,string tenkhu,string manv,int a,string idk)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblKhu (Makhu,Tenkhu,Manv) " +
                    "values( @MAKHU , @TENKHU , @MANV  )";
                    break;
                case 2: query = "UPDATE tblKhu set MaKhu= @MAKHU , Tenkhu=@TENKHU , Manv = @MANV , where Makhu ='" + idk + "'";
                    break;
            }
            int sult = Connection.Instance.ExecuteNonQuery(query, new object[] { makhu, tenkhu, manv });
            return sult > 0;
        }
        public bool Dele(string idk)
        {
            string query = "delete from tblKhu where MaKhu= @MAKHU ";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { idk });
            return result > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Chien
{
     public class Connect_Phong
    {
        private static Connect_Phong instance;

        public static Connect_Phong Instance
        {
            get { if (instance == null) instance = new Connect_Phong(); return Connect_Phong.instance; }
           private set { Connect_Phong.instance = value; }

        }
         private Connect_Phong()
        {

        }
         public bool SaveP(string maphong, string slmax, string sldango, string makhu,string loaiphong, int a, string idp)
         {
             String query = "";
             switch (a)
             {
                 case 1: query = "insert into tblPhong (Maphong,Slmax,Sldango,Makhu,Loaiphong) " +
                     "values( @MAPHONG , @SLMAX , @SLDANGO , @MAKHU , @LOAIPHONG )";
                     break;
                 case 2: query = "UPDATE tblPhong set Maphong= @MAPHONG , Slmax=@SLMAX , Sldango = @SLDANGO , Loaiphong=@LOAIPHONG , Makhu=@MAKHU where MaPhong='" + idp + "'";
                     break;
             }
             int sult = Connection.Instance.ExecuteNonQuery(query, new object[] { maphong, slmax, sldango, makhu,loaiphong });
             return sult > 0;
         }
         public bool DeleP(string idp)
         {
             string query = "delete from tblPhong where Maphong= @MAPHONG ";
             int result = Connection.Instance.ExecuteNonQuery(query, new object[] { idp });
             return result > 0;
         }
         public DataTable timkiem(String giatri, String loai)
         {
             string query = "select * from tblPhong where " + giatri + " like '%" + loai + "%'";
             DataTable tb = Connection.Instance.ExecuteQuery(query);
             return tb;
         }
         public DataTable loadcboKhu()
         {
             string query = "select Makhu from tblKhu";
             DataTable dt = Connection.Instance.ExecuteQuery(query);
             return dt;
         }
         public DataTable timkiemlb(string lp)
         {
             string query = "select * from tblPhong where Loaiphong like '%" + lp + "%'";
             DataTable tb = Connection.Instance.ExecuteQuery(query);
             return tb;
         }
    }
}

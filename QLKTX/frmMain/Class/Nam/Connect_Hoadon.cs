using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Nam
{
    public class Connect_Hoadon
    {
        private static Connect_Hoadon instance;

        public static Connect_Hoadon Instance
        {
            get {if(instance==null) instance=new Connect_Hoadon; return Connect_Hoadon.instance; }
            private set { Connect_Hoadon.instance = value; }
        }
        private Connect_Hoadon() {  }
        public bool save(String id,String mahd,int sdtt,int sdts,int sntt,int snts,int tt,int a,String mp)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblHoadon (Maphong,Sodienthangtruoc,Sodienthangsau,Sonuocthangtruoc,Sonuocthangsau,Tongtien) " +
                    "values( @MAP , @SDTT , @SDTS , @SNTT , @SNTS, @TT )";
                    break;
                case 2: query = "UPDATE tblHoadon set Maphong= @MAP ,Sodienthangtruoc= @SDTT ,Sodienthangsau= @SNTS ,Sonuocthangtruoc= @SNTT ,Sonuocthangsau= @Sonuocthangsau where Maphong='" + mp + "'";
                    break;
            }
            int sult = Connection.Instance.ExecuteNonQuery(query, new object[] { id, mahd, sdtt, sdts, sntt, snts, tt });
            return sult > 0;

        }
        public bool dele(String idvn)
        {
            string query = "delete from tblHoadon where Manv= @Mavn ";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { idvn });
            return result > 0;
        }
        public DataTable timkiem(String giatritimkiem, String loaitimkiem)
        {
            string query = "select * from tblNhanvien where " + loaitimkiem + " like '%" + giatritimkiem + "%'";
            DataTable tb = Connection.Instance.ExecuteQuery(query);
            return tb;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Nam
{
    public class Connect_Taisan
    {
        private static Connect_Taisan instance;//Crt e+r

        public static Connect_Taisan Instance
        {
            get { if(instance==null) instance=new Connect_Taisan() ;return Connect_Taisan.instance; }
            private set { Connect_Taisan.instance = value; }
        }
        private Connect_Taisan()
        {

        }
        public bool save( string mats, string maphong, int sl,int id,int a)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblTaisan (Mataisan,Maphong,Soluong) " +
                    "values(  @Mataisan , @Maphong , @Soluong )";
                    break;
                case 2: query = "UPDATE tblTaisan set Mataisan= @Mataisan , Maphong= @Maphong , Soluong= @Soluong where Id='"+id+"'";
                    break;
                    
            }
            int sult = Connection.Instance.ExecuteNonQuery(query, new object[] {mats,maphong,sl});
            return sult > 0;
        
        }
        public bool dele(int id)
        {
            string query = "delete from tblTaisan where Id= @ID ";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Minh
{
    public class Connect_Hopdong 
    {
        private static Connect_Hopdong instance;

        public static Connect_Hopdong Instance
        {
            get { if(instance==null) instance=new Connect_Hopdong();return Connect_Hopdong.instance; }
           private set { Connect_Hopdong.instance = value; }
        }
        private Connect_Hopdong() { }
        public Boolean save(String masv, string thoihan, int a, String Masv)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblHdong (MaSV, Thoihan) " +
                    "values( @MASV  , @THOIHAN )";
                    break;
                case 2: query = "update tblHdong set MaSV= @MASV ,Thoihan= @THOIHAN where MaSV='"+Masv+ "'";
                    break;
            }
            int sult = Connection.Instance.ExecuteNonQuery(query, new object[] { masv, thoihan });
            return sult > 0;
        }
        public bool dele(int id)
        {
            string query = "delete from tblHdong where MaHopdong= @id ";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        public DataTable timkiem(String giatritimkiem, String loaitimkiem)
        {
            string query = "select hd.MaHopdong,sv.MaSV,sv.Hoten,hd.Thoihan from tblHdong as hd inner join tblSinhvien as sv on hd.MaSV=sv.MaSV where " + loaitimkiem + " like '%" + giatritimkiem + "%'";
            DataTable tb = Connection.Instance.ExecuteQuery(query);
            return tb;
        }
        public DataTable loadMasvnedit()
        {
            string query = "select MaSV from tblSinhvien ";
            DataTable dt = Connection.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable loadMasvnew()
        {
            string query = "select MaSV from tblSinhvien where not exists (select * from tblHdong where tblSinhvien.MaSV=tblHdong.MaSV)";
            DataTable dt = Connection.Instance.ExecuteQuery(query);
            return dt;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Minh
{
    public class Connect_Nhanvien
    {
        private static Connect_Nhanvien instance;

        public static Connect_Nhanvien Instance
        {
            get { if(instance==null) instance=new Connect_Nhanvien();return Connect_Nhanvien.instance; }
            private set { Connect_Nhanvien.instance = value; }
        }
        private Connect_Nhanvien()
        {

        }

        public bool save(String manv, String hoten, int sdt, int quyenhan, String ghichu, int a,String idnv)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblNhanvien (Manv,Matkhau,Hoten,Sodienthoai,Quyenhan,Ghichu) " +
                    "values( @Mavn ,'123', @Hoten , @Sodienthoai , @Quyenhan , @Ghichu )";
                    break;
                case 2: query = "UPDATE tblNhanvien set Manv= @Mavn ,Hoten= @Hoten ,Sodienthoai= @Sodienthoai ,Quyenhan= @Quyenhan ,Ghichu= @Ghichu where Manv='"+idnv+"'";
                    break;
            }
            int sult = Connection.Instance.ExecuteNonQuery(query, new object[] { manv,hoten,sdt,quyenhan,ghichu });
            return sult > 0;
            
        }
        public bool dele(String idvn)
        {
            string query = "delete from tblNhanvien where Manv= @Mavn ";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { idvn });
            return result > 0;
        }
        public DataTable timkiem(String giatritimkiem, String loaitimkiem)
        {
            string query = "select Manv as [Mã nhân viên],Hoten as [Họ tên],Sodienthoai [Số điện thoại],Quyenhan as [Quyền hạn],Ghichu as [Ghi chú] from tblNhanvien where " + loaitimkiem + " like '%" + giatritimkiem + "%'";
            DataTable tb = Connection.Instance.ExecuteQuery(query);
            return tb;
        }


    }
}

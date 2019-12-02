using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain.Class.Minh
{
    public class Connect_Sinhvien
    {
        private static Connect_Sinhvien instance;

        public static Connect_Sinhvien Instance
        {
            get { if (instance == null) instance = new Connect_Sinhvien(); ;return Connect_Sinhvien.instance; }
            private set { Connect_Sinhvien.instance = value; }
        }
        private Connect_Sinhvien()
        {

        }
        public bool saveSv(String maSv, String Hoten, String Ngaysinh, String gioitinh, String hokhau, int Sodienthoai, String ngaydk, String Ghichu, String Maphong,int a,string id)
        {
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tblSinhvien (MaSV,Hoten,Ngaysinh,Gioitinh,Hokhau,Sodienthoai,Ngaydk,Ghichu,Maphong) " +
                    "values( @MASV , @HOTEN , @NGAYSINH , @GIOITINH , @HOKHAU , @SODT , @NGAYDK , @GHICHU , @MAPHONG )";
                    break;
                case 2: query = "UPDATE tblSinhvien set MaSV= @MASV , Hoten= @HOTEN ,Ngaysinh= @NGAYSINH ,Gioitinh= @GIOITINH ,Hokhau= @HOKHAU ,Sodienthoai= @SODT ,Ngaydk= @NGAYDK ,Ghichu= @GHICHU ,Maphong= @MAPHONG where MaSV='"+id+"'";
                    break;
            }
            int sult = Connection.Instance.ExecuteNonQuery(query,new object[]{maSv,Hoten,Ngaysinh,gioitinh,hokhau,Sodienthoai,ngaydk,Ghichu,Maphong});
            return sult>0;
        }
        public bool deleteSv(String maSv)
        {
            string query = "delete from tblSinhvien where MaSV= @ID ";
            int result = Connection.Instance.ExecuteNonQuery(query, new object[] { maSv });
            return result>0;
        }
        public DataTable timkiem(String giatri, String loai)
        {
            string query = "select * from tblSinhvien where "+giatri+" like '%" + loai + "%'";
            DataTable tb= Connection.Instance.ExecuteQuery(query);
            return tb;
         }
        public DataTable loadPhong()
        {
            string query = "select Maphong from tblPhong where Sldango<6";
            DataTable dt= Connection.Instance.ExecuteQuery(query);
            return dt;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace frmMain.Class.Minh
{
    public partial class frmNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }
        private void formLoad()
        {
            string query = "select Manv as [Mã nhân viên],Hoten as [Họ tên],Sodienthoai [Số điện thoại],Quyenhan as [Quyền hạn],Ghichu as [Ghi chú] from tblNhanvien ";//đưa thông tin nhân viên lên grid view
            dgrNhanvien.DataSource= Connection.Instance.ExecuteQuery(query);//thực hiện câu truy vấn, trả về bảng dữ liệu
        }
        int a,index,quyenhan;
        String idnv;
            String loaitimkiem;

        

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            formLoad();
            setConntrol(true);
        }
        private void setConntrol(bool s)//sét bật tắt cho các nút button
        {
            btnNew.Enabled = s;
            btnSave.Enabled = !s;
            btnEdit.Enabled = s;
            btnDelete.Enabled = s;
            btnCancel.Enabled = !s;
            /////-------------
            txtManv.Enabled = !s;
            txtHoten.Enabled = !s;
            txtGhichu.Enabled = !s;
            txtSdt.Enabled = !s;


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            txtManv.Focus();
            txtManv.Text = "";
            txtHoten.Text = "";
            txtGhichu.Text = "";
            txtSdt.Text = "";
            a = 1;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            String manv, hoten, ghichu;
            int sdt;
            try
            {
                manv = txtManv.Text.ToString();
                hoten = txtHoten.Text.ToString();
                ghichu = txtGhichu.Text.ToString();
                sdt =0+ Int32.Parse(txtSdt.Text);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message+"\nGiá trị không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                if(Connect_Nhanvien.Instance.save(manv, hoten, sdt, quyenhan, ghichu, a, idnv))
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            formLoad();
            }
                catch(Exception a){
                    MessageBox.Show(a.Message+"\nXem lại giá trị nhập vào bị trùng không?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

        }
        
        private void dgrNhanvien_Click(object sender, EventArgs e)
        {
            index = dgrNhanvien.CurrentRow.Index;
            txtManv.Text = dgrNhanvien.Rows[index].Cells[0].Value.ToString().Trim();
            txtHoten.Text = dgrNhanvien.Rows[index].Cells[1].Value.ToString().Trim();
            txtSdt.Text = dgrNhanvien.Rows[index].Cells[2].Value.ToString().Trim();
            String quyenhan1 = dgrNhanvien.Rows[index].Cells[3].Value.ToString().Trim();
            txtGhichu.Text = dgrNhanvien.Rows[index].Cells[4].Value.ToString().Trim();
            if (quyenhan1 == "False")
            {
                cboQuyenhan.SelectedItem = "Admin";
            }
            if(quyenhan1=="True")
            {
                cboQuyenhan.SelectedItem = "Nhân viên";
            }
            
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 2;
            idnv = dgrNhanvien.Rows[index].Cells[0].Value.ToString().Trim();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            idnv = dgrNhanvien.Rows[index].Cells[0].Value.ToString().Trim();
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa thông tin vừa nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connect_Nhanvien.Instance.dele(idnv);
            formLoad();
        }

        private void cboQuyenhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboQuyenhan.SelectedIndex == 0)
            {
                quyenhan = 0;
            }
            if (cboQuyenhan.SelectedIndex == 1)
            {
                quyenhan = 1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            formLoad();
        }


        private void simpleButton6_Click(object sender, EventArgs e)
        {
            String giatritimkiem = txtTimkiem.Text.ToString().Trim();
            
            dgrNhanvien.DataSource=Connect_Nhanvien.Instance.timkiem(giatritimkiem,loaitimkiem);
        }

        private void cboTimkiem_SelectedIndexChanged(object sender, EventArgs e){
        
            ;
            if (cboTimkiem.SelectedIndex == 0)
            {
                loaitimkiem = "Manv";
            }
            if (cboTimkiem.SelectedIndex == 1)
            {
                loaitimkiem = "Hoten";
            }
        }

        
    }
}
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
    public partial class frmSinhvien : DevExpress.XtraEditors.XtraForm
    {
        public frmSinhvien()
        {
            InitializeComponent();
            loadSinhvien();
            setConntrol(true);
        }
        int index, a,gtinh;
        String masv,giatri;

        void loadSinhvien()//load sinh viên gridview
        {
            String query = "select * from tblSinhvien";
            grvSinhvien.DataSource = Connection.Instance.ExecuteQuery(query);
        }
        private void setConntrol(bool s)//sét bật tắt cho các nút button
        {
            btnNew.Enabled = s;
            btnSave.Enabled=!s;
            btnEdit.Enabled = s;
            btnDelete.Enabled = s;
            btnCancel.Enabled = !s;
            /////-------------
            txtHoten.Enabled = !s;
            txtHokhau.Enabled = !s;
            txtGhichu.Enabled = !s;
             cmbPhong.Enabled = !s;
            dtNgaydk.Enabled = !s;
            txtSodienthoai.Enabled = !s;
            dtNgaysinh.Enabled = !s;
            txtMasv.Enabled = !s;
            cboGioitinh.Enabled = !s;



        }
        #region New

        private void btnNew_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            txtMasv.Focus();//đưa con trỏ về ô sinh viên
            a = 1;
            loadPhong();
        }
        #endregion

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            setConntrol(true);
        }
        
        private void btnSave_Click(object sender, EventArgs e)//Lưu
        {
            setConntrol(true);
            string msv, ht, ns, gt, hk, ngdk, gc, mp;
            int sdt;
            try { 
            msv = txtMasv.Text.Trim();
            ht=txtHoten.Text.Trim();
            ns = dtNgaysinh.Value.ToString("yyyy-MM-dd");
            gt = gtinh.ToString();
            hk = txtHokhau.Text.Trim();
            sdt = Int32.Parse(txtSodienthoai.Text);
            ngdk = dtNgaydk.Value.ToString("yyyy-MM-dd");
            gc = txtGhichu.Text.Trim();
            mp = cmbPhong.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Sai định dạng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
                   
            }
            try
            {
                if (Connect_Sinhvien.Instance.saveSv(msv, ht, ns, gt, hk, sdt, ngdk, gc, mp, a, masv))
                {
                   
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connect_Sinhvien.Instance.themSl(mp, a);
                }
                loadSinhvien();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

        private void grvSinhvien_Click(object sender, EventArgs e)//Sư kiên click vào grid view
        {
            index = grvSinhvien.CurrentRow.Index;
            txtMasv.Text = grvSinhvien.Rows[index].Cells[0].Value.ToString().Trim();
            txtHoten.Text = grvSinhvien.Rows[index].Cells[1].Value.ToString().Trim();
            dtNgaysinh.Text = grvSinhvien.Rows[index].Cells[2].Value.ToString().Trim();
            txtGhichu.Text = grvSinhvien.Rows[index].Cells[7].Value.ToString().Trim();
            cmbPhong.Text = grvSinhvien.Rows[index].Cells[8].Value.ToString();
            txtHokhau.Text = grvSinhvien.Rows[index].Cells[4].Value.ToString();
            String gioitinh = grvSinhvien.Rows[index].Cells[3].Value.ToString().Trim();
            if(gioitinh=="False"){
                cboGioitinh.SelectedItem="Nam";
            }
            if (gioitinh == "True")
            {
                cboGioitinh.SelectedItem ="Nữ";

            }
            txtSodienthoai.Text = "0"+grvSinhvien.Rows[index].Cells[5].Value.ToString().Trim();
        }

        private void cboGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGioitinh.SelectedIndex == 0)
            {
                gtinh = 0;
            }
            if (cboGioitinh.SelectedIndex == 1)
            {
                gtinh = 1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                setConntrol(false);
                a = 2;
                masv = grvSinhvien.Rows[index].Cells[0].Value.ToString().Trim();
                loadPhong();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn giá trị cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                a = 3;
                masv = grvSinhvien.Rows[index].Cells[0].Value.ToString().Trim();
                String mp = grvSinhvien.Rows[index].Cells[8].Value.ToString().Trim();
                DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = MessageBox.Show("Bạn có muốn xóa thông tin vừa nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                Connect_Sinhvien.Instance.deleteSv(masv);
                Connect_Sinhvien.Instance.themSl(mp,a);
                loadSinhvien();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn giá trị cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                giatri="MaSV";

            }
            if(comboBoxEdit1.SelectedIndex==1){
                giatri="Hoten";
            }

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String loai = txtTimkiem.Text.ToString().Trim();
            grvSinhvien.DataSource = Connect_Sinhvien.Instance.timkiem(giatri, loai);
        }
        private void loadPhong()
        {
            cmbPhong.DataSource = Connect_Sinhvien.Instance.loadPhong();
            cmbPhong.DisplayMember="Maphong";
            cmbPhong.ValueMember = "Maphong";
        }

        

       
     


    }
}
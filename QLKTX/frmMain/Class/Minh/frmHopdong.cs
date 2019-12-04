using frmMain.Class;
using frmMain.Class.Minh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmHopdong : Form
    {
        public frmHopdong()
        {
            InitializeComponent();
            
          
        }
        int index,a;
        int id;
        String masv,loaitk;
        

        private void loadForm()
        {
            string query = "select hd.MaHopdong,sv.MaSV,sv.Hoten,hd.Thoihan from tblHdong as hd inner join tblSinhvien as sv on hd.MaSV=sv.MaSV";
            dgrHopdong.DataSource = Connection.Instance.ExecuteQuery(query);
            
        }

        private void frmHopdong_Load(object sender, EventArgs e)
        {
            loadForm();
            setConntrol(true);
            txtMahopdong.Enabled = false;
        }
        private void setConntrol(bool s)//sét bật tắt cho các nút button
        {
            btnNew.Enabled = s;
            btnSave.Enabled = !s;
            btnEdit.Enabled = s;
            btnDelete.Enabled = s;
            btnCancel.Enabled = !s;
            /////-------------
            txtHoten.Enabled = !s;
            
            dtDate.Enabled = !s;
            cboMasv.Enabled=!s;
            



        }

        private void dgrHopdong_Click(object sender, EventArgs e)
        {
            index = dgrHopdong.CurrentRow.Index;
            cboMasv.Text = dgrHopdong.Rows[index].Cells[1].Value.ToString().Trim();
            txtHoten.Text = dgrHopdong.Rows[index].Cells[2].Value.ToString().Trim();
            txtMahopdong.Text = dgrHopdong.Rows[index].Cells[0].Value.ToString().Trim();
            dtDate.Text = dgrHopdong.Rows[index].Cells[3].Value.ToString().Trim();
            
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 1;
            loadCbonew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                setConntrol(false);
                a = 2;
                masv = dgrHopdong.Rows[index].Cells[1].Value.ToString().Trim();
                loadCboedit();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn giá trị cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            txtHoten.Text = "";
            txtMahopdong.Text = "";
            dtDate.Text = "";
            cboMasv.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            String msv, hoten, thoihan;
            msv = cboMasv.Text.ToString().Trim();
            hoten = txtHoten.Text.ToString();
            thoihan = dtDate.Value.ToString("yyyy-MM-dd");
            if(Connect_Hopdong.Instance.save(msv,thoihan,a,masv)){
                MessageBox.Show("Lưu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            loadForm();
            
           
        }

        private void loadCbonew()
        {
            cboMasv.DataSource = Connect_Hopdong.Instance.loadMasvnew();
            cboMasv.DisplayMember = "MaSV";
            cboMasv.ValueMember = "MaSv";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                setConntrol(true);
                id = Int32.Parse(dgrHopdong.Rows[index].Cells[0].Value.ToString().Trim());
                DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = MessageBox.Show("Bạn có muốn xóa thông tin vừa nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                if (Connect_Hopdong.Instance.dele(id))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadForm();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn giá trị cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadCboedit()
        {
            cboMasv.DataSource = Connect_Hopdong.Instance.loadMasvnedit();
            cboMasv.DisplayMember = "MaSV";
            cboMasv.ValueMember = "MaSV";
        }

       
        private void cboTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTim.SelectedIndex == 0)
            {
                loaitk = "hd.MaHopdong";
            }
            if (cboTim.SelectedIndex == 1)
            {
                loaitk = "hd.MaSV";
            }
            if (cboTim.SelectedIndex == 2)
            {
                loaitk = "hd.Thoihan";
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try{
                String giatri = txtTimkiem.Text.ToString().Trim();
             dgrHopdong.DataSource = Connect_Hopdong.Instance.timkiem(giatri, loaitk);
            }
                catch{
                    MessageBox.Show("Vui lòng chọn giá trị cần tìm","Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
        }


        
    }
}

using frmMain.Class;
using frmMain.Class.Chien;
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
    public partial class frmDienNuoc : Form
    {
        public frmDienNuoc()
        {
            InitializeComponent();
        }
        int a,index;
        string idkhu;
        private void loadDiennuoc() 
        {
            String query = "Select * from tblQuydinh";
            dgvDiennuoc.DataSource = Connection.Instance.ExecuteQuery(query);
        }
        private void frmDienNuoc_Load(object sender, EventArgs e)
        {
            loadDiennuoc();
        }

       
        private void setConntrol(bool s)
        {
            btnNew.Enabled = s;
            btnCancel.Enabled = !s;
            btnSave.Enabled = !s;
            btnDelete.Enabled = s;
            btnCancel.Enabled = !s;
            
            
            txtTienD.Enabled = !s;
            txtTienN.Enabled = !s;
        }

        private void btnSaveDN_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            String makhu;
            int giadien,gianuoc,giaphong;
            
            try
            {
                makhu = cboMakhu.Text.ToString();
                giadien = Int32.Parse(txtTienD.Text);
                gianuoc = Int32.Parse(txtTienN.Text);
                giaphong = Int32.Parse(txtGiaphong.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "\nGiá trị không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (Connect_Diennuoc.Instance.SaveDN(makhu, giadien, gianuoc, giaphong,a,idkhu))
                {
                    MessageBox.Show(" thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                loadDiennuoc();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message + "\nXem lại giá trị nhập vào bị trùng không?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvDiennuoc_Click(object sender, EventArgs e)
        {
            index = dgvDiennuoc.CurrentRow.Index;
            
            txtTienD.Text = dgvDiennuoc.Rows[index].Cells[1].Value.ToString().Trim();
            txtTienN.Text = dgvDiennuoc.Rows[index].Cells[2].Value.ToString().Trim();
            
            txtGiaphong.Text = dgvDiennuoc.Rows[index].Cells[3].Value.ToString().Trim();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 2;
            idkhu = dgvDiennuoc.Rows[index].Cells[0].Value.ToString().Trim();
            loadKhuu();
        }

        private void btnCanl_Click(object sender, EventArgs e)
        {
            setConntrol(true);
        }

        private void loadKhuu()
        {
            cboMakhu.DataSource = Connect_Diennuoc.Instance.loadKhu();
            cboMakhu.DisplayMember = "Makhu";
            cboMakhu.ValueMember = "Makhu";
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 1;
            loadKhuu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            idkhu = dgvDiennuoc.Rows[index].Cells[0].Value.ToString().Trim();
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa thông tin vừa nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connect_Diennuoc.Instance.Dele(idkhu);
            loadDiennuoc();
        }

       
    }
}

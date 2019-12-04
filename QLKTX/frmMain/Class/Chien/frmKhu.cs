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
    public partial class frmKhu : Form
    {
        public frmKhu()
        {
            InitializeComponent();
            loadKhu();
            setConntrol(true);
        }
        int a, index;
        string idk;
        private void loadKhu()
        {
            string query = "select * from tblKhu ";
            dgvKhu.DataSource = Connection.Instance.ExecuteQuery(query);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            txtMK.Focus();
            txtMK.Text = "";
            txtTenK.Text = "";
            txtMNV.Text = "";
            
            a = 1;
            loadKhu();

        }
        private void setConntrol(bool s)
        {
            btnNew.Enabled = s;
            btnSave.Enabled = !s;
            btnEdit.Enabled = s;
            btnDel.Enabled = s;
            btnCanl.Enabled = !s;
            /////-------------
            txtMK.Enabled = !s;
            txtTenK.Enabled = !s;
            txtMNV.Enabled = !s;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            string makhu, tenkhu, manv;
            try
            {
                makhu = txtMK.Text.ToString().Trim();
                tenkhu = txtTenK.Text.ToString().Trim();
                manv = txtMNV.Text.ToString().Trim();
                
                loadKhu();
            }
            catch
            {
                MessageBox.Show("Sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (Connect_Khu.Instance.SaveK(makhu,tenkhu,manv, a, idk))
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadKhu();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    



        private void dgvKhu_Click(object sender, EventArgs e)
        {
            index = dgvKhu.CurrentRow.Index;
            txtMK.Text = dgvKhu.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenK.Text = dgvKhu.Rows[index].Cells[1].Value.ToString().Trim();
            txtMNV.Text = dgvKhu.Rows[index].Cells[2].Value.ToString().Trim();
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            idk = dgvKhu.Rows[index].Cells[0].Value.ToString().Trim();
            Connect_Khu.Instance.Dele(idk);
            loadKhu();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 2;
            idk = dgvKhu.Rows[index].Cells[0].Value.ToString().Trim();
        }

        private void btnCanl_Click(object sender, EventArgs e)
        {
            setConntrol(true);
        }

        private void frmKhu_Load(object sender, EventArgs e)
        {

        }
    }
}

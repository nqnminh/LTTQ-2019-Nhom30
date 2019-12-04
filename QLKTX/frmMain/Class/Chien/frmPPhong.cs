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
    public partial class frmPPhong : Form
    {
        public frmPPhong()
        {
            InitializeComponent();
            
        }
        int a, index, loaiphong;
        string idp,giatri;
        private void loadPhong()
        {
            string query = "select * from tblPhong ";
            dgvPhong.DataSource = Connection.Instance.ExecuteQuery(query);
        }
        private void frmPPhong_Load(object sender, EventArgs e)
        {
            loadPhong();
            setConntrol(true);
            txtSL.Enabled = false;
        }
        private void setConntrol(bool s)
        {
            btnnew.Enabled = s;
            btnSave.Enabled = !s;
            btnedit.Enabled = s;
            btndele.Enabled = !s;
            btnCanl.Enabled = !s;
            /////-------------
            txtMa.Enabled = !s;
            cboMakhu.Enabled = !s;
            
            txtSLMax.Enabled = !s; 
            cboLoaiphong.Enabled = !s;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            string maphong,slmax,sldango,makhu,lp;
            try
            {
                maphong = txtMa.Text.ToString().Trim();
                slmax = txtSLMax.Text.ToString().Trim();
                sldango = txtSL.Text.ToString().Trim();
                makhu = cboMakhu.Text.ToString().Trim();
                lp = loaiphong.ToString();
                loadPhong();
            }
            catch
            {
                MessageBox.Show("Sai định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (Connect_Phong.Instance.SaveP(maphong,slmax,sldango,makhu,lp,a,idp))
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadPhong();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            index = dgvPhong.CurrentRow.Index;
            txtMa.Text = dgvPhong.Rows[index].Cells[0].Value.ToString().Trim();
            txtSLMax.Text = dgvPhong.Rows[index].Cells[1].Value.ToString().Trim();
            txtSL.Text = dgvPhong.Rows[index].Cells[2].Value.ToString().Trim();
            cboMakhu.Text = dgvPhong.Rows[index].Cells[3].Value.ToString().Trim();
            String gioitinh = dgvPhong.Rows[index].Cells[4].Value.ToString().Trim();
            if (gioitinh == "False")
            {
                cboLoaiphong.SelectedItem = "Nam";
            }
            if (gioitinh == "True")
            {
                cboLoaiphong.SelectedItem = "Nữ";

            }
            
        }

        private void btndele_Click(object sender, EventArgs e)
        {
            idp = dgvPhong.Rows[index].Cells[0].Value.ToString().Trim();
            Connect_Phong.Instance.DeleP(idp);
            loadPhong();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 2;
            idp = dgvPhong.Rows[index].Cells[0].Value.ToString().Trim();
            loadcboKhu();
        }

        private void btnCanl_Click(object sender, EventArgs e)
        {
            setConntrol(true);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            txtMa.Focus();
            txtSLMax.Text = "";
            txtSL.Text = "";
            
            a = 1;
            loadPhong();
            loadcboKhu();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            String loai = txtTim.Text.ToString().Trim();
            dgvPhong.DataSource = Connect_Phong.Instance.timkiem(giatri, loai);
        }

        private void cBEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBEdit1.SelectedIndex == 0)
            {
                giatri="Maphong";

            }
            if (cBEdit1.SelectedIndex == 1)
            {
                giatri = "Makhu";
            }
            if (cBEdit1.SelectedIndex == 2)
            {
                giatri = "Loaiphong";
            }
        }

        private void cboLoaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiphong.SelectedIndex == 0)
            {
                loaiphong = 0;
            }
            if (cboLoaiphong.SelectedIndex == 1)
            {
                loaiphong = 1;
            }
        }
        private void loadcboKhu()
        {
            cboMakhu.DataSource = Connect_Phong.Instance.loadcboKhu();
            cboMakhu.DisplayMember = "Makhu";
        }

        private void cboTimloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lp;
            if (cboTimloaiphong.SelectedIndex == 0)
            {
                lp = "0";
                dgvPhong.DataSource = Connect_Phong.Instance.timkiemlb(lp);
                
            }
            if (cboTimloaiphong.SelectedIndex == 1)
            {
                lp = "1";
                dgvPhong.DataSource = Connect_Phong.Instance.timkiemlb(lp);

            }
            
        }

        


    }
}

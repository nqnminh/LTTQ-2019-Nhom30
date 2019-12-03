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
using System.Data.SqlClient;
using frmMain.Class;
using frmMain.Class.Nam;

namespace frmMain
{
    public partial class frmTaisan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaisan()
        {
            InitializeComponent();
            
        }
        int index,a,id;
        
        public void formLoad()
        {
            string query = "select * from tblTaisan";
            bts.DataSource = Connection.Instance.ExecuteQuery(query);
            txtid.Enabled = false;

        }

        private void frmTaisan_Load(object sender, EventArgs e)
        {
            formLoad();
            setConntrol(true);
            txtid.Enabled = true;//không cho nhập ô id, thuộc tính id tự tăng;
            txtid.Text = "";
            txtmaphong.Text = "";
            txtsoluong.Text = "";
            
        }
        private void setConntrol(bool s)
        {
            btnNew.Enabled = s;
            btnSave.Enabled = !s;
            btnEdit.Enabled = s;
            btnDelete.Enabled = s;
            btnCancel.Enabled = !s;
            /////-------------
            
            cboMats.Enabled = !s;
            txtmaphong.Enabled = !s;
            txtsoluong.Enabled = !s;
            txttentaisan.Enabled = !s;



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 2;
            id = Int32.Parse(bts.Rows[index].Cells[0].Value.ToString().Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            String mats, maphong;
            int sl;
            
            mats=cboMats.Text.Trim();
            maphong = txtmaphong.Text.Trim();
            sl = Int32.Parse(txtsoluong.Text);

            if(Connect_Taisan.Instance.save(mats,maphong,sl,a,id)){
                MessageBox.Show("Lưu thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            formLoad();

        }

        private void bts_Click(object sender, EventArgs e)
        {
            index = bts.CurrentRow.Index;
            txtid.Text = bts.Rows[index].Cells[0].Value.ToString().Trim();
            txtmaphong.Text = bts.Rows[index].Cells[2].Value.ToString().Trim();
            cboMats.Text = bts.Rows[index].Cells[1].Value.ToString().Trim();
            
           txtsoluong.Text = bts.Rows[index].Cells[3].Value.ToString();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            a = 1;
            setConntrol(false);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            id = Int32.Parse(bts.Rows[index].Cells[0].Value.ToString().Trim());
            Connect_Taisan.Instance.dele(id);
            formLoad();
        }

        
    }
}
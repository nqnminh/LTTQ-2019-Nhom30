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
using frmMain.Class;

namespace frmMain
{
    public partial class frmHoadon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoadon()
        {
            InitializeComponent();
        }
        private void loadHoadon()
        {
            string query = "select * from tblHoadon";
            dgvHoadon.DataSource = Connection.Instance.ExecuteQuery(query);
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            loadHoadon();
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
            txtmahoadon.Enabled = !s;
            txtmaphong.Enabled = !s;
            txtsodienthangsau.Enabled = !s;
            txtsodienthangtruoc.Enabled = !s;
            txtsonuocthangsau.Enabled = !s;
            txtsonuocthangtruoc.Enabled = !s;
            txtTongtien.Enabled = !s;

        }
    }
}
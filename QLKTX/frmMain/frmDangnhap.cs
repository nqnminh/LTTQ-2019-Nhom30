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

namespace frmMain
{
    public partial class frmDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMain fmain = new frmMain();
            this.Hide();
            fmain.Show();
        }
    }
}
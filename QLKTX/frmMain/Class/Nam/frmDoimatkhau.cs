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
    public partial class frmDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
                    }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String manv, pass, passnew, passnew1;
            
                manv = txtManv.Text.ToString().Trim();
                pass = txtPass.Text.ToString().Trim();
                passnew = txtPassnew.Text.ToString().Trim();
                passnew1 = txtPassnew1.Text.ToString().Trim();
                if (passnew != passnew1)
                {
                    MessageBox.Show("Mật khẩu mới không trùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    if (Connect_Taikhoan.Instance.doimk(manv, pass, passnew))
                    {
                        MessageBox.Show("Đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            
            
        }
    }
}
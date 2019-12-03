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
    public partial class frmDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String userName = txtUsername.Text;
            String passWord = txtPassưord.Text;
            if (Login(userName,passWord))
            {
                frmMain fmain = new frmMain();
                this.Hide();
                fmain.user = userName;
                fmain.Show();
                
                
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
        bool Login(String userName, String passWord)
        {
            return Connect_Taikhoan.Instance.Login(userName,passWord);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ với Trưởng ban QLKTX để được cấp lại mật khẩu hoặc liên hệ đường dây lạnh 1900100 có!", "Thồng báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
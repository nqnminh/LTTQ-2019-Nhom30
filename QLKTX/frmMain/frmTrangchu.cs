using frmMain.Class;
using frmMain.Class.Minh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public String user;
        private void loadForm()
        {
            if (Connect_Taikhoan.Instance.loadForm(user))
            {
                barButtonItem1.Enabled = false;
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Money Twins";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            skin();
        }
        
       


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmTaisan ftaisan = new frmTaisan();
                ftaisan.MdiParent = this;
                ftaisan.Show();
           
            
        }
       
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              frmHopdong fhopdong = new frmHopdong();
            fhopdong.MdiParent = this;
            fhopdong.Show();
           
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmHoadon fhoadon = new frmHoadon();
                fhoadon.MdiParent = this;
                fhoadon.Show();
           
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmKhu frmkhu = new frmKhu();
            frmkhu.MdiParent = this;
            frmkhu.Show();
            
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmDienNuoc frmdiennuoc = new frmDienNuoc();
            frmdiennuoc.MdiParent = this;
            frmdiennuoc.Show();
           
            
        }

        private void btnDangnhapa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
                    
                
                frmSinhvien frmsv = new frmSinhvien();
                frmsv.MdiParent =this;
                frmsv.Show();
        
            
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmPPhong fPhong = new frmPPhong();
                fPhong.MdiParent = this;
                fPhong.Show();
          
            
        }

        private void btnDoimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoimatkhau fmk = new frmDoimatkhau();
            fmk.MdiParent = this;
            fmk.Show();
        }

        private void btnDangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            frmDangnhap frm = new frmDangnhap();
            this.Close();
            frm.Show();
              
        }

       
  
    }
}

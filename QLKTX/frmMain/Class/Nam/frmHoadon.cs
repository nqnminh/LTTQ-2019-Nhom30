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
using frmMain.Class.Nam;

namespace frmMain
{
    public partial class frmHoadon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoadon()
        {
            InitializeComponent();
        }
        int a,index;
        String mp;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                mp = dgvHoadon.Rows[index].Cells[1].Value.ToString().Trim();
                DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = MessageBox.Show("Bạn có muốn xóa thông tin vừa nhập", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.No) return;
                Connect_Hoadon.Instance.dele(mp);
                loadHoadon();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn giá trị cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvHoadon_Click(object sender, EventArgs e)
        {
            index = dgvHoadon.CurrentRow.Index;
            txtmahoadon.Text = dgvHoadon.Rows[index].Cells[0].Value.ToString().Trim();
            txtmaphong.Text = dgvHoadon.Rows[index].Cells[1].Value.ToString().Trim();
            txtsodienthangtruoc.Text = dgvHoadon.Rows[index].Cells[2].Value.ToString().Trim();
            txtsodienthangsau.Text = dgvHoadon.Rows[index].Cells[3].Value.ToString().Trim();
            txtsonuocthangtruoc.Text = dgvHoadon.Rows[index].Cells[4].Value.ToString().Trim();
            txtsonuocthangsau.Text = dgvHoadon.Rows[index].Cells[5].Value.ToString().Trim();
            txtTongtien.Text = dgvHoadon.Rows[index].Cells[6].Value.ToString().Trim();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setConntrol(false);
            a = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setConntrol(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                setConntrol(false);
                a = 2;
                mp = dgvHoadon.Rows[index].Cells[1].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn giá trị cần sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setConntrol(true);
            String id, mahd;
            int sdtt,sdts,sntt,snts,tt;
            try
            {
                id = txtmahoadon.Text.ToString();
                mahd = txtmaphong.Text.ToString();
                sdtt = Int32.Parse(txtsodienthangtruoc.Text);
                sdts = Int32.Parse(txtsodienthangsau.Text);
                sntt =Int32.Parse(txtsonuocthangtruoc.Text);
                snts = Int32.Parse(txtsonuocthangtruoc.Text);
                
                tt = Int32.Parse(txtTongtien.Text);
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message+"\nGiá trị không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try{
                if(Connect_Hoadon.Instance.save(id, mahd,sdtt,sdts,sntt,snts,tt,a,mp))
            {
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                loadHoadon();
            }
                catch(Exception a){
                    MessageBox.Show(a.Message+"\nXem lại giá trị nhập vào bị trùng không?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

        
        }
    }
}
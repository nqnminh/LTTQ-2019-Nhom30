namespace frmMain
{
    partial class frmTaisan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bts = new System.Windows.Forms.DataGridView();
            this.lbid = new System.Windows.Forms.Label();
            this.lbmats = new System.Windows.Forms.Label();
            this.lbtents = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbmaphong = new System.Windows.Forms.Label();
            this.grTaisan = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.bttimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.grTaisan1 = new DevExpress.XtraEditors.GroupControl();
            this.cboMats = new System.Windows.Forms.ComboBox();
            this.txtmaphong = new DevExpress.XtraEditors.TextEdit();
            this.txttentaisan = new DevExpress.XtraEditors.TextEdit();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTaisan)).BeginInit();
            this.grTaisan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTaisan1)).BeginInit();
            this.grTaisan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttentaisan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bts
            // 
            this.bts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bts.Location = new System.Drawing.Point(22, 190);
            this.bts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bts.Name = "bts";
            this.bts.RowTemplate.Height = 24;
            this.bts.Size = new System.Drawing.Size(604, 222);
            this.bts.TabIndex = 0;
            this.bts.Click += new System.EventHandler(this.bts_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(9, 37);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(18, 13);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "ID";
            // 
            // lbmats
            // 
            this.lbmats.AutoSize = true;
            this.lbmats.Location = new System.Drawing.Point(9, 83);
            this.lbmats.Name = "lbmats";
            this.lbmats.Size = new System.Drawing.Size(56, 13);
            this.lbmats.TabIndex = 2;
            this.lbmats.Text = "Mã tài sản";
            // 
            // lbtents
            // 
            this.lbtents.AutoSize = true;
            this.lbtents.Location = new System.Drawing.Point(410, 37);
            this.lbtents.Name = "lbtents";
            this.lbtents.Size = new System.Drawing.Size(60, 13);
            this.lbtents.TabIndex = 3;
            this.lbtents.Text = "Tên tài sản";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(410, 83);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(49, 13);
            this.lbsoluong.TabIndex = 4;
            this.lbsoluong.Text = "Số lượng";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Location = new System.Drawing.Point(9, 129);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(54, 13);
            this.lbmaphong.TabIndex = 5;
            this.lbmaphong.Text = "Mã phòng";
            // 
            // grTaisan
            // 
            this.grTaisan.Controls.Add(this.simpleButton1);
            this.grTaisan.Controls.Add(this.btnDelete);
            this.grTaisan.Controls.Add(this.btnCancel);
            this.grTaisan.Controls.Add(this.btnEdit);
            this.grTaisan.Controls.Add(this.btnNew);
            this.grTaisan.Controls.Add(this.btnSave);
            this.grTaisan.Location = new System.Drawing.Point(632, 190);
            this.grTaisan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTaisan.Name = "grTaisan";
            this.grTaisan.Size = new System.Drawing.Size(203, 121);
            this.grTaisan.TabIndex = 17;
            this.grTaisan.Text = "Chức năng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(112, 90);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 19);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "In danh sách";
            this.simpleButton1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 19);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(5, 90);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 19);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(112, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 19);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(5, 22);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 19);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 56);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 19);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(67, 59);
            this.bttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(75, 19);
            this.bttimkiem.TabIndex = 17;
            this.bttimkiem.Text = "Tìm kiếm";
            // 
            // grTaisan1
            // 
            this.grTaisan1.Controls.Add(this.cboMats);
            this.grTaisan1.Controls.Add(this.txtmaphong);
            this.grTaisan1.Controls.Add(this.txttentaisan);
            this.grTaisan1.Controls.Add(this.txtsoluong);
            this.grTaisan1.Controls.Add(this.txtid);
            this.grTaisan1.Controls.Add(this.lbid);
            this.grTaisan1.Controls.Add(this.lbmats);
            this.grTaisan1.Controls.Add(this.lbtents);
            this.grTaisan1.Controls.Add(this.lbsoluong);
            this.grTaisan1.Controls.Add(this.lbmaphong);
            this.grTaisan1.Location = new System.Drawing.Point(22, 10);
            this.grTaisan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grTaisan1.Name = "grTaisan1";
            this.grTaisan1.Size = new System.Drawing.Size(813, 161);
            this.grTaisan1.TabIndex = 18;
            this.grTaisan1.Text = "Thông tin";
            // 
            // cboMats
            // 
            this.cboMats.FormattingEnabled = true;
            this.cboMats.Location = new System.Drawing.Point(100, 79);
            this.cboMats.Name = "cboMats";
            this.cboMats.Size = new System.Drawing.Size(260, 21);
            this.cboMats.TabIndex = 21;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(100, 127);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(260, 20);
            this.txtmaphong.TabIndex = 11;
            // 
            // txttentaisan
            // 
            this.txttentaisan.Location = new System.Drawing.Point(513, 34);
            this.txttentaisan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttentaisan.Name = "txttentaisan";
            this.txttentaisan.Size = new System.Drawing.Size(260, 20);
            this.txttentaisan.TabIndex = 9;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(513, 79);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(260, 20);
            this.txtsoluong.TabIndex = 8;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 33);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(260, 20);
            this.txtid.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(this.bttimkiem);
            this.groupControl1.Location = new System.Drawing.Point(632, 316);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(203, 96);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // frmTaisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 421);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grTaisan1);
            this.Controls.Add(this.grTaisan);
            this.Controls.Add(this.bts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTaisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaisan";
            this.Load += new System.EventHandler(this.frmTaisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTaisan)).EndInit();
            this.grTaisan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grTaisan1)).EndInit();
            this.grTaisan1.ResumeLayout(false);
            this.grTaisan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttentaisan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bts;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbmats;
        private System.Windows.Forms.Label lbtents;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbmaphong;
        private DevExpress.XtraEditors.GroupControl grTaisan;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton bttimkiem;
        private DevExpress.XtraEditors.GroupControl grTaisan1;
        private DevExpress.XtraEditors.TextEdit txtmaphong;
        private DevExpress.XtraEditors.TextEdit txttentaisan;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboMats;
    }
}
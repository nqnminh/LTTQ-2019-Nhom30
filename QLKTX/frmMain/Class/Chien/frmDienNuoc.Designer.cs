namespace frmMain
{
    partial class frmDienNuoc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDiennuoc = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiaphong = new System.Windows.Forms.TextBox();
            this.txtTienN = new System.Windows.Forms.TextBox();
            this.txtTienD = new System.Windows.Forms.TextBox();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cboMakhu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiennuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl1.Location = new System.Drawing.Point(252, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(166, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quy định điện nước";
            // 
            // dgvDiennuoc
            // 
            this.dgvDiennuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiennuoc.Location = new System.Drawing.Point(21, 56);
            this.dgvDiennuoc.Name = "dgvDiennuoc";
            this.dgvDiennuoc.Size = new System.Drawing.Size(327, 246);
            this.dgvDiennuoc.TabIndex = 2;
            this.dgvDiennuoc.Click += new System.EventHandler(this.dgvDiennuoc_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboMakhu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtGiaphong);
            this.groupControl1.Controls.Add(this.txtTienN);
            this.groupControl1.Controls.Add(this.txtTienD);
            this.groupControl1.Controls.Add(this.btnNew);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Location = new System.Drawing.Point(354, 56);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 246);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "TT Giá cả";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Giá phòng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Giá nước";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Mã khu";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Giá điện";
            // 
            // txtGiaphong
            // 
            this.txtGiaphong.Location = new System.Drawing.Point(80, 124);
            this.txtGiaphong.Name = "txtGiaphong";
            this.txtGiaphong.Size = new System.Drawing.Size(129, 21);
            this.txtGiaphong.TabIndex = 1;
            // 
            // txtTienN
            // 
            this.txtTienN.Location = new System.Drawing.Point(80, 86);
            this.txtTienN.Name = "txtTienN";
            this.txtTienN.Size = new System.Drawing.Size(129, 21);
            this.txtTienN.TabIndex = 1;
            // 
            // txtTienD
            // 
            this.txtTienD.Location = new System.Drawing.Point(80, 49);
            this.txtTienD.Name = "txtTienD";
            this.txtTienD.Size = new System.Drawing.Size(129, 21);
            this.txtTienD.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(17, 166);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Thêm";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 195);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCanl_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSaveDN_Click);
            // 
            // cboMakhu
            // 
            this.cboMakhu.FormattingEnabled = true;
            this.cboMakhu.Location = new System.Drawing.Point(80, 24);
            this.cboMakhu.Name = "cboMakhu";
            this.cboMakhu.Size = new System.Drawing.Size(129, 21);
            this.cboMakhu.TabIndex = 3;
            // 
            // frmDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 346);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvDiennuoc);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDienNuoc";
            this.Load += new System.EventHandler(this.frmDienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiennuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvDiennuoc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtTienN;
        private System.Windows.Forms.TextBox txtTienD;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.TextBox txtGiaphong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.ComboBox cboMakhu;
    }
}
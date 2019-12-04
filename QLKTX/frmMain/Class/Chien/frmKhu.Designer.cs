namespace frmMain
{
    partial class frmKhu
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
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.grTT = new System.Windows.Forms.GroupBox();
            this.btnCanl = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtTenK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.labMNV = new System.Windows.Forms.Label();
            this.labTen = new System.Windows.Forms.Label();
            this.lMaK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.grTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhu
            // 
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Location = new System.Drawing.Point(1, 36);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.Size = new System.Drawing.Size(437, 278);
            this.dgvKhu.TabIndex = 0;
            this.dgvKhu.Click += new System.EventHandler(this.dgvKhu_Click);
            // 
            // grTT
            // 
            this.grTT.Controls.Add(this.btnCanl);
            this.grTT.Controls.Add(this.btnSave);
            this.grTT.Controls.Add(this.btnDel);
            this.grTT.Controls.Add(this.btnEdit);
            this.grTT.Controls.Add(this.btnNew);
            this.grTT.Controls.Add(this.txtMNV);
            this.grTT.Controls.Add(this.txtTenK);
            this.grTT.Controls.Add(this.txtMK);
            this.grTT.Controls.Add(this.labMNV);
            this.grTT.Controls.Add(this.labTen);
            this.grTT.Controls.Add(this.lMaK);
            this.grTT.Location = new System.Drawing.Point(444, 31);
            this.grTT.Name = "grTT";
            this.grTT.Size = new System.Drawing.Size(289, 283);
            this.grTT.TabIndex = 1;
            this.grTT.TabStop = false;
            this.grTT.Text = "Thông tin";
            // 
            // btnCanl
            // 
            this.btnCanl.Location = new System.Drawing.Point(102, 249);
            this.btnCanl.Name = "btnCanl";
            this.btnCanl.Size = new System.Drawing.Size(75, 23);
            this.btnCanl.TabIndex = 3;
            this.btnCanl.Text = "Hủy";
            this.btnCanl.Click += new System.EventHandler(this.btnCanl_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(43, 216);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(165, 172);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(43, 172);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Thêm";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtMNV
            // 
            this.txtMNV.Location = new System.Drawing.Point(102, 91);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(154, 20);
            this.txtMNV.TabIndex = 1;
            // 
            // txtTenK
            // 
            this.txtTenK.Location = new System.Drawing.Point(102, 65);
            this.txtTenK.Name = "txtTenK";
            this.txtTenK.Size = new System.Drawing.Size(154, 20);
            this.txtTenK.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(102, 35);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(154, 20);
            this.txtMK.TabIndex = 1;
            // 
            // labMNV
            // 
            this.labMNV.AutoSize = true;
            this.labMNV.Location = new System.Drawing.Point(22, 91);
            this.labMNV.Name = "labMNV";
            this.labMNV.Size = new System.Drawing.Size(75, 13);
            this.labMNV.TabIndex = 0;
            this.labMNV.Text = "Mã Nhân Viên";
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(22, 65);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(48, 13);
            this.labTen.TabIndex = 0;
            this.labTen.Text = "Tên Khu";
            // 
            // lMaK
            // 
            this.lMaK.AutoSize = true;
            this.lMaK.Location = new System.Drawing.Point(22, 35);
            this.lMaK.Name = "lMaK";
            this.lMaK.Size = new System.Drawing.Size(44, 13);
            this.lMaK.TabIndex = 0;
            this.lMaK.Text = "Mã Khu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quảng lý Khu";
            // 
            // frmKhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grTT);
            this.Controls.Add(this.dgvKhu);
            this.Name = "frmKhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhu";
            this.Load += new System.EventHandler(this.frmKhu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.grTT.ResumeLayout(false);
            this.grTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.GroupBox grTT;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.TextBox txtTenK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label labMNV;
        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.Label lMaK;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCanl;
    }
}
namespace frmMain
{
    partial class frmPPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCanl = new DevExpress.XtraEditors.SimpleButton();
            this.btndele = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtSLMax = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboLoaiphong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMakhu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoaiphongtk = new System.Windows.Forms.Label();
            this.cboTimloaiphong = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBEdit1.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTimloaiphong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Location = new System.Drawing.Point(220, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quản lý Phòng KTX";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(25, 31);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(568, 202);
            this.dgvPhong.TabIndex = 1;
            this.dgvPhong.Click += new System.EventHandler(this.dgvPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCanl);
            this.groupBox2.Controls.Add(this.btndele);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Location = new System.Drawing.Point(25, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnCanl
            // 
            this.btnCanl.Location = new System.Drawing.Point(11, 144);
            this.btnCanl.Name = "btnCanl";
            this.btnCanl.Size = new System.Drawing.Size(75, 23);
            this.btnCanl.TabIndex = 8;
            this.btnCanl.Text = "Hủy";
            this.btnCanl.Click += new System.EventHandler(this.btnCanl_Click);
            // 
            // btndele
            // 
            this.btndele.Location = new System.Drawing.Point(11, 115);
            this.btndele.Name = "btndele";
            this.btndele.Size = new System.Drawing.Size(75, 23);
            this.btndele.TabIndex = 5;
            this.btndele.Text = "Xóa";
            this.btndele.Click += new System.EventHandler(this.btndele_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(11, 82);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Sửa";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(11, 19);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 7;
            this.btnnew.Text = "Thêm";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBEdit1);
            this.groupBox3.Controls.Add(this.cboTimloaiphong);
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.cboLoaiphongtk);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(432, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cBEdit1
            // 
            this.cBEdit1.Location = new System.Drawing.Point(6, 79);
            this.cBEdit1.Name = "cBEdit1";
            this.cBEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBEdit1.Properties.Items.AddRange(new object[] {
            "Mã phòng",
            "Mã khu"});
            this.cBEdit1.Size = new System.Drawing.Size(78, 20);
            this.cBEdit1.TabIndex = 8;
            this.cBEdit1.SelectedIndexChanged += new System.EventHandler(this.cBEdit1_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(6, 40);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(137, 20);
            this.txtTim.TabIndex = 0;
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(100, 19);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(146, 20);
            this.txtMa.TabIndex = 0;
            // 
            // txtSLMax
            // 
            this.txtSLMax.Location = new System.Drawing.Point(100, 57);
            this.txtSLMax.Name = "txtSLMax";
            this.txtSLMax.Size = new System.Drawing.Size(146, 20);
            this.txtSLMax.TabIndex = 0;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(100, 92);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(146, 20);
            this.txtSL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SlMax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "SL Đang ở";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại Phòng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboMakhu);
            this.groupBox4.Controls.Add(this.cboLoaiphong);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtSL);
            this.groupBox4.Controls.Add(this.txtSLMax);
            this.groupBox4.Controls.Add(this.txtMa);
            this.groupBox4.Location = new System.Drawing.Point(147, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 189);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin";
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.Location = new System.Drawing.Point(100, 161);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiphong.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboLoaiphong.Size = new System.Drawing.Size(146, 20);
            this.cboLoaiphong.TabIndex = 2;
            this.cboLoaiphong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiphong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khu";
            // 
            // cboMakhu
            // 
            this.cboMakhu.FormattingEnabled = true;
            this.cboMakhu.Location = new System.Drawing.Point(100, 127);
            this.cboMakhu.Name = "cboMakhu";
            this.cboMakhu.Size = new System.Drawing.Size(146, 21);
            this.cboMakhu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thuộc tính";
            // 
            // cboLoaiphongtk
            // 
            this.cboLoaiphongtk.AutoSize = true;
            this.cboLoaiphongtk.Location = new System.Drawing.Point(90, 120);
            this.cboLoaiphongtk.Name = "cboLoaiphongtk";
            this.cboLoaiphongtk.Size = new System.Drawing.Size(60, 13);
            this.cboLoaiphongtk.TabIndex = 1;
            this.cboLoaiphongtk.Text = "Loại phòng";
            // 
            // cboTimloaiphong
            // 
            this.cboTimloaiphong.Location = new System.Drawing.Point(9, 117);
            this.cboTimloaiphong.Name = "cboTimloaiphong";
            this.cboTimloaiphong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTimloaiphong.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboTimloaiphong.Size = new System.Drawing.Size(75, 20);
            this.cboTimloaiphong.TabIndex = 2;
            this.cboTimloaiphong.SelectedIndexChanged += new System.EventHandler(this.cboTimloaiphong_SelectedIndexChanged);
            // 
            // frmPPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmPPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.frmPPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBEdit1.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTimloaiphong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTim;
        private DevExpress.XtraEditors.SimpleButton btnCanl;
        private DevExpress.XtraEditors.SimpleButton btndele;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtSLMax;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cBEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiphong;
        private System.Windows.Forms.ComboBox cboMakhu;
        private DevExpress.XtraEditors.ComboBoxEdit cboTimloaiphong;
        private System.Windows.Forms.Label cboLoaiphongtk;
        private System.Windows.Forms.Label label3;
    }
}
namespace frmMain
{
    partial class frmHopdong
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
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimkiem = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboTimkiem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtHoten = new DevExpress.XtraEditors.TextEdit();
            this.grhopdong = new DevExpress.XtraEditors.GroupControl();
            this.cboMasv = new System.Windows.Forms.ComboBox();
            this.txtthoihan = new DevExpress.XtraEditors.TextEdit();
            this.txtMahopdong = new DevExpress.XtraEditors.TextEdit();
            this.bttimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.cbb1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmahopdong = new System.Windows.Forms.Label();
            this.lbthoihan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmasinhvien = new System.Windows.Forms.Label();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btin = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.grhopdong1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dgrHopdong = new System.Windows.Forms.DataGridView();
            this.cboTim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhopdong)).BeginInit();
            this.grhopdong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtthoihan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahopdong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhopdong1)).BeginInit();
            this.grhopdong1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHopdong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(148, 68);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(19, 37);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(204, 20);
            this.txtTimkiem.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboTim);
            this.groupControl1.Controls.Add(this.btnTimkiem);
            this.groupControl1.Controls.Add(this.cboTimkiem);
            this.groupControl1.Controls.Add(this.txtTimkiem);
            this.groupControl1.Location = new System.Drawing.Point(556, 254);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(239, 105);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.Location = new System.Drawing.Point(270, 46);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTimkiem.Size = new System.Drawing.Size(94, 20);
            this.cboTimkiem.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(140, 112);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(150, 21);
            this.dtDate.TabIndex = 22;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(140, 85);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(155, 20);
            this.txtHoten.TabIndex = 21;
            // 
            // grhopdong
            // 
            this.grhopdong.Controls.Add(this.cboMasv);
            this.grhopdong.Controls.Add(this.dtDate);
            this.grhopdong.Controls.Add(this.txtHoten);
            this.grhopdong.Controls.Add(this.txtthoihan);
            this.grhopdong.Controls.Add(this.txtMahopdong);
            this.grhopdong.Controls.Add(this.bttimkiem);
            this.grhopdong.Controls.Add(this.cbb1);
            this.grhopdong.Controls.Add(this.label2);
            this.grhopdong.Controls.Add(this.lbmahopdong);
            this.grhopdong.Controls.Add(this.lbthoihan);
            this.grhopdong.Controls.Add(this.label1);
            this.grhopdong.Controls.Add(this.lbmasinhvien);
            this.grhopdong.Location = new System.Drawing.Point(208, 254);
            this.grhopdong.Margin = new System.Windows.Forms.Padding(2);
            this.grhopdong.Name = "grhopdong";
            this.grhopdong.Size = new System.Drawing.Size(343, 157);
            this.grhopdong.TabIndex = 21;
            this.grhopdong.Text = "Thông tin";
            // 
            // cboMasv
            // 
            this.cboMasv.FormattingEnabled = true;
            this.cboMasv.Location = new System.Drawing.Point(140, 60);
            this.cboMasv.Name = "cboMasv";
            this.cboMasv.Size = new System.Drawing.Size(155, 21);
            this.cboMasv.TabIndex = 23;
            // 
            // txtthoihan
            // 
            this.txtthoihan.Location = new System.Drawing.Point(129, 165);
            this.txtthoihan.Margin = new System.Windows.Forms.Padding(2);
            this.txtthoihan.Name = "txtthoihan";
            this.txtthoihan.Size = new System.Drawing.Size(236, 20);
            this.txtthoihan.TabIndex = 19;
            // 
            // txtMahopdong
            // 
            this.txtMahopdong.Location = new System.Drawing.Point(140, 34);
            this.txtMahopdong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMahopdong.Name = "txtMahopdong";
            this.txtMahopdong.Size = new System.Drawing.Size(155, 20);
            this.txtMahopdong.TabIndex = 18;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(25, 212);
            this.bttimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(75, 19);
            this.bttimkiem.TabIndex = 17;
            this.bttimkiem.Text = "Tìm kiếm";
            // 
            // cbb1
            // 
            this.cbb1.Location = new System.Drawing.Point(129, 213);
            this.cbb1.Margin = new System.Windows.Forms.Padding(2);
            this.cbb1.Name = "cbb1";
            this.cbb1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb1.Size = new System.Drawing.Size(75, 20);
            this.cbb1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày hết hợp đồng";
            // 
            // lbmahopdong
            // 
            this.lbmahopdong.AutoSize = true;
            this.lbmahopdong.Location = new System.Drawing.Point(50, 37);
            this.lbmahopdong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmahopdong.Name = "lbmahopdong";
            this.lbmahopdong.Size = new System.Drawing.Size(69, 13);
            this.lbmahopdong.TabIndex = 13;
            this.lbmahopdong.Text = "Mã hợp đồng";
            // 
            // lbthoihan
            // 
            this.lbthoihan.AutoSize = true;
            this.lbthoihan.Location = new System.Drawing.Point(22, 169);
            this.lbthoihan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbthoihan.Name = "lbthoihan";
            this.lbthoihan.Size = new System.Drawing.Size(48, 13);
            this.lbthoihan.TabIndex = 13;
            this.lbthoihan.Text = "Thời hạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sinh viên";
            // 
            // lbmasinhvien
            // 
            this.lbmasinhvien.AutoSize = true;
            this.lbmasinhvien.Location = new System.Drawing.Point(53, 64);
            this.lbmasinhvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmasinhvien.Name = "lbmasinhvien";
            this.lbmasinhvien.Size = new System.Drawing.Size(66, 13);
            this.lbmasinhvien.TabIndex = 13;
            this.lbmasinhvien.Text = "Mã sinh viên";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 37);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 19);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(9, 123);
            this.btin.Margin = new System.Windows.Forms.Padding(2);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(75, 19);
            this.btin.TabIndex = 24;
            this.btin.Text = "In danh sách";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 81);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 19);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(98, 123);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 19);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(98, 82);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 19);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grhopdong1
            // 
            this.grhopdong1.Controls.Add(this.btnEdit);
            this.grhopdong1.Controls.Add(this.btnCancel);
            this.grhopdong1.Controls.Add(this.btnDelete);
            this.grhopdong1.Controls.Add(this.btnSave);
            this.grhopdong1.Controls.Add(this.btnNew);
            this.grhopdong1.Controls.Add(this.btin);
            this.grhopdong1.Location = new System.Drawing.Point(11, 254);
            this.grhopdong1.Margin = new System.Windows.Forms.Padding(2);
            this.grhopdong1.Name = "grhopdong1";
            this.grhopdong1.Size = new System.Drawing.Size(192, 157);
            this.grhopdong1.TabIndex = 20;
            this.grhopdong1.Text = "Chức năng";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 19);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgrHopdong
            // 
            this.dgrHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHopdong.Location = new System.Drawing.Point(11, 9);
            this.dgrHopdong.Margin = new System.Windows.Forms.Padding(2);
            this.dgrHopdong.Name = "dgrHopdong";
            this.dgrHopdong.RowTemplate.Height = 24;
            this.dgrHopdong.Size = new System.Drawing.Size(784, 232);
            this.dgrHopdong.TabIndex = 19;
            this.dgrHopdong.Click += new System.EventHandler(this.dgrHopdong_Click);
            // 
            // cboTim
            // 
            this.cboTim.FormattingEnabled = true;
            this.cboTim.Items.AddRange(new object[] {
            "Mã hợp đồng",
            "Mã sinh viên",
            "Thời hạn"});
            this.cboTim.Location = new System.Drawing.Point(19, 68);
            this.cboTim.Name = "cboTim";
            this.cboTim.Size = new System.Drawing.Size(123, 21);
            this.cboTim.TabIndex = 23;
            this.cboTim.SelectedIndexChanged += new System.EventHandler(this.cboTim_SelectedIndexChanged);
            // 
            // frmHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 421);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grhopdong);
            this.Controls.Add(this.grhopdong1);
            this.Controls.Add(this.dgrHopdong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHopdong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHopdong";
            this.Load += new System.EventHandler(this.frmHopdong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboTimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhopdong)).EndInit();
            this.grhopdong.ResumeLayout(false);
            this.grhopdong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtthoihan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMahopdong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhopdong1)).EndInit();
            this.grhopdong1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHopdong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private DevExpress.XtraEditors.TextEdit txtTimkiem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboTimkiem;
        private System.Windows.Forms.DateTimePicker dtDate;
        private DevExpress.XtraEditors.TextEdit txtHoten;
        private DevExpress.XtraEditors.GroupControl grhopdong;
        private DevExpress.XtraEditors.TextEdit txtthoihan;
        private DevExpress.XtraEditors.TextEdit txtMahopdong;
        private DevExpress.XtraEditors.SimpleButton bttimkiem;
        public DevExpress.XtraEditors.ComboBoxEdit cbb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmahopdong;
        private System.Windows.Forms.Label lbthoihan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmasinhvien;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btin;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.GroupControl grhopdong1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.DataGridView dgrHopdong;
        private System.Windows.Forms.ComboBox cboMasv;
        private System.Windows.Forms.ComboBox cboTim;

    }
}
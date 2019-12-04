namespace frmMain
{
    partial class frmHoadon
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
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.lbmahd = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.lbsonuocthangtruoc = new System.Windows.Forms.Label();
            this.lbsodienthangsau = new System.Windows.Forms.Label();
            this.lbsodienthangtruoc = new System.Windows.Forms.Label();
            this.lbmaphong = new System.Windows.Forms.Label();
            this.lbsonuocthangsau = new System.Windows.Forms.Label();
            this.grhoadon = new DevExpress.XtraEditors.GroupControl();
            this.txtmaphong = new DevExpress.XtraEditors.TextEdit();
            this.txtsodienthangtruoc = new DevExpress.XtraEditors.TextEdit();
            this.txtTongtien = new DevExpress.XtraEditors.TextEdit();
            this.txtsodienthangsau = new DevExpress.XtraEditors.TextEdit();
            this.txtsonuocthangsau = new DevExpress.XtraEditors.TextEdit();
            this.txtsonuocthangtruoc = new DevExpress.XtraEditors.TextEdit();
            this.txtmahoadon = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.grhoadon1 = new DevExpress.XtraEditors.GroupControl();
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            this.btin = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimkiem = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon)).BeginInit();
            this.grhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangtruoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangsau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangsau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangtruoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon1)).BeginInit();
            this.grhoadon1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(10, 206);
            this.dgvHoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowTemplate.Height = 24;
            this.dgvHoadon.Size = new System.Drawing.Size(830, 206);
            this.dgvHoadon.TabIndex = 0;
            this.dgvHoadon.Click += new System.EventHandler(this.dgvHoadon_Click);
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(21, 31);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(63, 13);
            this.lbmahd.TabIndex = 1;
            this.lbmahd.Text = "Mã hoá đơn";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(31, 281);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(52, 13);
            this.lbtongtien.TabIndex = 2;
            this.lbtongtien.Text = "Tổng tiền";
            // 
            // lbsonuocthangtruoc
            // 
            this.lbsonuocthangtruoc.AutoSize = true;
            this.lbsonuocthangtruoc.Location = new System.Drawing.Point(303, 89);
            this.lbsonuocthangtruoc.Name = "lbsonuocthangtruoc";
            this.lbsonuocthangtruoc.Size = new System.Drawing.Size(106, 13);
            this.lbsonuocthangtruoc.TabIndex = 5;
            this.lbsonuocthangtruoc.Text = "Số nước tháng trước";
            // 
            // lbsodienthangsau
            // 
            this.lbsodienthangsau.AutoSize = true;
            this.lbsodienthangsau.Location = new System.Drawing.Point(21, 123);
            this.lbsodienthangsau.Name = "lbsodienthangsau";
            this.lbsodienthangsau.Size = new System.Drawing.Size(93, 13);
            this.lbsodienthangsau.TabIndex = 7;
            this.lbsodienthangsau.Text = "Số điện tháng sau";
            // 
            // lbsodienthangtruoc
            // 
            this.lbsodienthangtruoc.AutoSize = true;
            this.lbsodienthangtruoc.Location = new System.Drawing.Point(21, 89);
            this.lbsodienthangtruoc.Name = "lbsodienthangtruoc";
            this.lbsodienthangtruoc.Size = new System.Drawing.Size(102, 13);
            this.lbsodienthangtruoc.TabIndex = 8;
            this.lbsodienthangtruoc.Text = "Số điện tháng trước";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Location = new System.Drawing.Point(21, 59);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(54, 13);
            this.lbmaphong.TabIndex = 9;
            this.lbmaphong.Text = "Mã phòng";
            // 
            // lbsonuocthangsau
            // 
            this.lbsonuocthangsau.AutoSize = true;
            this.lbsonuocthangsau.Location = new System.Drawing.Point(303, 121);
            this.lbsonuocthangsau.Name = "lbsonuocthangsau";
            this.lbsonuocthangsau.Size = new System.Drawing.Size(97, 13);
            this.lbsonuocthangsau.TabIndex = 19;
            this.lbsonuocthangsau.Text = "Số nước tháng sau";
            // 
            // grhoadon
            // 
            this.grhoadon.AllowDrop = true;
            this.grhoadon.Controls.Add(this.txtmaphong);
            this.grhoadon.Controls.Add(this.txtsodienthangtruoc);
            this.grhoadon.Controls.Add(this.txtTongtien);
            this.grhoadon.Controls.Add(this.txtsodienthangsau);
            this.grhoadon.Controls.Add(this.txtsonuocthangsau);
            this.grhoadon.Controls.Add(this.txtsonuocthangtruoc);
            this.grhoadon.Controls.Add(this.txtmahoadon);
            this.grhoadon.Controls.Add(this.lbsonuocthangtruoc);
            this.grhoadon.Controls.Add(this.lbmahd);
            this.grhoadon.Controls.Add(this.lbtongtien);
            this.grhoadon.Controls.Add(this.label1);
            this.grhoadon.Controls.Add(this.lbsodienthangsau);
            this.grhoadon.Controls.Add(this.lbsodienthangtruoc);
            this.grhoadon.Controls.Add(this.lbmaphong);
            this.grhoadon.Controls.Add(this.lbsonuocthangsau);
            this.grhoadon.Location = new System.Drawing.Point(10, 10);
            this.grhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grhoadon.Name = "grhoadon";
            this.grhoadon.Size = new System.Drawing.Size(604, 172);
            this.grhoadon.TabIndex = 29;
            this.grhoadon.Text = "Thông tin";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(184, 57);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(260, 20);
            this.txtmaphong.TabIndex = 27;
            // 
            // txtsodienthangtruoc
            // 
            this.txtsodienthangtruoc.Location = new System.Drawing.Point(184, 90);
            this.txtsodienthangtruoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsodienthangtruoc.Name = "txtsodienthangtruoc";
            this.txtsodienthangtruoc.Size = new System.Drawing.Size(67, 20);
            this.txtsodienthangtruoc.TabIndex = 26;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(184, 143);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(163, 20);
            this.txtTongtien.TabIndex = 25;
            // 
            // txtsodienthangsau
            // 
            this.txtsodienthangsau.Location = new System.Drawing.Point(184, 119);
            this.txtsodienthangsau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsodienthangsau.Name = "txtsodienthangsau";
            this.txtsodienthangsau.Size = new System.Drawing.Size(67, 20);
            this.txtsodienthangsau.TabIndex = 25;
            // 
            // txtsonuocthangsau
            // 
            this.txtsonuocthangsau.Location = new System.Drawing.Point(448, 117);
            this.txtsonuocthangsau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsonuocthangsau.Name = "txtsonuocthangsau";
            this.txtsonuocthangsau.Size = new System.Drawing.Size(67, 20);
            this.txtsonuocthangsau.TabIndex = 22;
            // 
            // txtsonuocthangtruoc
            // 
            this.txtsonuocthangtruoc.Location = new System.Drawing.Point(448, 87);
            this.txtsonuocthangtruoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsonuocthangtruoc.Name = "txtsonuocthangtruoc";
            this.txtsonuocthangtruoc.Size = new System.Drawing.Size(67, 20);
            this.txtsonuocthangtruoc.TabIndex = 21;
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(184, 28);
            this.txtmahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(260, 20);
            this.txtmahoadon.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền";
            // 
            // grhoadon1
            // 
            this.grhoadon1.Controls.Add(this.cboTimkiem);
            this.grhoadon1.Controls.Add(this.btin);
            this.grhoadon1.Controls.Add(this.btnTimkiem);
            this.grhoadon1.Controls.Add(this.btnSave);
            this.grhoadon1.Controls.Add(this.txtTimkiem);
            this.grhoadon1.Controls.Add(this.btnCancel);
            this.grhoadon1.Controls.Add(this.btnEdit);
            this.grhoadon1.Controls.Add(this.btnDelete);
            this.grhoadon1.Controls.Add(this.btnNew);
            this.grhoadon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grhoadon1.Location = new System.Drawing.Point(620, 10);
            this.grhoadon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grhoadon1.Name = "grhoadon1";
            this.grhoadon1.Size = new System.Drawing.Size(220, 172);
            this.grhoadon1.TabIndex = 30;
            this.grhoadon1.Text = "Chức năng";
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Location = new System.Drawing.Point(110, 115);
            this.cboTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(87, 21);
            this.cboTimkiem.TabIndex = 7;
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(110, 84);
            this.btin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(89, 19);
            this.btin.TabIndex = 6;
            this.btin.Text = "In dánh sách";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(15, 116);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(93, 19);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 56);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 19);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(15, 139);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(181, 20);
            this.txtTimkiem.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 86);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 19);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(107, 28);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 19);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(110, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 19);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 28);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 19);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 421);
            this.Controls.Add(this.grhoadon1);
            this.Controls.Add(this.grhoadon);
            this.Controls.Add(this.dgvHoadon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoadon";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon)).EndInit();
            this.grhoadon.ResumeLayout(false);
            this.grhoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangtruoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangsau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangsau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangtruoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon1)).EndInit();
            this.grhoadon1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Label lbsonuocthangtruoc;
        private System.Windows.Forms.Label lbsodienthangsau;
        private System.Windows.Forms.Label lbsodienthangtruoc;
        private System.Windows.Forms.Label lbmaphong;
        private System.Windows.Forms.Label lbsonuocthangsau;
        private DevExpress.XtraEditors.GroupControl grhoadon;
        private DevExpress.XtraEditors.GroupControl grhoadon1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.ComboBox cboTimkiem;
        private DevExpress.XtraEditors.SimpleButton btin;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.TextEdit txtmaphong;
        private DevExpress.XtraEditors.TextEdit txtsodienthangtruoc;
        private DevExpress.XtraEditors.TextEdit txtsodienthangsau;
        private DevExpress.XtraEditors.TextEdit txtsonuocthangsau;
        private DevExpress.XtraEditors.TextEdit txtsonuocthangtruoc;
        private DevExpress.XtraEditors.TextEdit txtmahoadon;
        private DevExpress.XtraEditors.TextEdit txtTimkiem;
        private DevExpress.XtraEditors.TextEdit txtTongtien;
        private System.Windows.Forms.Label label1;
    }
}
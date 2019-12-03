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
            this.bhd = new System.Windows.Forms.DataGridView();
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
            this.txtsodienthangsau = new DevExpress.XtraEditors.TextEdit();
            this.txtsonuocthangsau = new DevExpress.XtraEditors.TextEdit();
            this.txtsonuocthangtruoc = new DevExpress.XtraEditors.TextEdit();
            this.txtmahoadon = new DevExpress.XtraEditors.TextEdit();
            this.grhoadon1 = new DevExpress.XtraEditors.GroupControl();
            this.cbbtimkiem = new System.Windows.Forms.ComboBox();
            this.btin = new DevExpress.XtraEditors.SimpleButton();
            this.bttimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btluu = new DevExpress.XtraEditors.SimpleButton();
            this.bthuy = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bhd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon)).BeginInit();
            this.grhoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangtruoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangsau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangsau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangtruoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon1)).BeginInit();
            this.grhoadon1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bhd
            // 
            this.bhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bhd.Location = new System.Drawing.Point(12, 253);
            this.bhd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bhd.Name = "bhd";
            this.bhd.RowTemplate.Height = 24;
            this.bhd.Size = new System.Drawing.Size(968, 254);
            this.bhd.TabIndex = 0;
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(25, 38);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(80, 17);
            this.lbmahd.TabIndex = 1;
            this.lbmahd.Text = "Mã hoá đơn";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(36, 346);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(66, 17);
            this.lbtongtien.TabIndex = 2;
            this.lbtongtien.Text = "Tổng tiền";
            // 
            // lbsonuocthangtruoc
            // 
            this.lbsonuocthangtruoc.AutoSize = true;
            this.lbsonuocthangtruoc.Location = new System.Drawing.Point(353, 110);
            this.lbsonuocthangtruoc.Name = "lbsonuocthangtruoc";
            this.lbsonuocthangtruoc.Size = new System.Drawing.Size(138, 17);
            this.lbsonuocthangtruoc.TabIndex = 5;
            this.lbsonuocthangtruoc.Text = "Số nước tháng trước";
            // 
            // lbsodienthangsau
            // 
            this.lbsodienthangsau.AutoSize = true;
            this.lbsodienthangsau.Location = new System.Drawing.Point(25, 151);
            this.lbsodienthangsau.Name = "lbsodienthangsau";
            this.lbsodienthangsau.Size = new System.Drawing.Size(118, 17);
            this.lbsodienthangsau.TabIndex = 7;
            this.lbsodienthangsau.Text = "Số điện tháng sau";
            // 
            // lbsodienthangtruoc
            // 
            this.lbsodienthangtruoc.AutoSize = true;
            this.lbsodienthangtruoc.Location = new System.Drawing.Point(25, 110);
            this.lbsodienthangtruoc.Name = "lbsodienthangtruoc";
            this.lbsodienthangtruoc.Size = new System.Drawing.Size(131, 17);
            this.lbsodienthangtruoc.TabIndex = 8;
            this.lbsodienthangtruoc.Text = "Số điện tháng trước";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Location = new System.Drawing.Point(25, 73);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(69, 17);
            this.lbmaphong.TabIndex = 9;
            this.lbmaphong.Text = "Mã phòng";
            // 
            // lbsonuocthangsau
            // 
            this.lbsonuocthangsau.AutoSize = true;
            this.lbsonuocthangsau.Location = new System.Drawing.Point(353, 149);
            this.lbsonuocthangsau.Name = "lbsonuocthangsau";
            this.lbsonuocthangsau.Size = new System.Drawing.Size(125, 17);
            this.lbsonuocthangsau.TabIndex = 19;
            this.lbsonuocthangsau.Text = "Số nước tháng sau";
            // 
            // grhoadon
            // 
            this.grhoadon.AllowDrop = true;
            this.grhoadon.Controls.Add(this.txtmaphong);
            this.grhoadon.Controls.Add(this.txtsodienthangtruoc);
            this.grhoadon.Controls.Add(this.txtsodienthangsau);
            this.grhoadon.Controls.Add(this.txtsonuocthangsau);
            this.grhoadon.Controls.Add(this.txtsonuocthangtruoc);
            this.grhoadon.Controls.Add(this.txtmahoadon);
            this.grhoadon.Controls.Add(this.lbsonuocthangtruoc);
            this.grhoadon.Controls.Add(this.lbmahd);
            this.grhoadon.Controls.Add(this.lbtongtien);
            this.grhoadon.Controls.Add(this.lbsodienthangsau);
            this.grhoadon.Controls.Add(this.lbsodienthangtruoc);
            this.grhoadon.Controls.Add(this.lbmaphong);
            this.grhoadon.Controls.Add(this.lbsonuocthangsau);
            this.grhoadon.Location = new System.Drawing.Point(12, 12);
            this.grhoadon.Name = "grhoadon";
            this.grhoadon.Size = new System.Drawing.Size(705, 186);
            this.grhoadon.TabIndex = 29;
            this.grhoadon.Text = "Thông tin";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(215, 70);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(303, 22);
            this.txtmaphong.TabIndex = 27;
            // 
            // txtsodienthangtruoc
            // 
            this.txtsodienthangtruoc.Location = new System.Drawing.Point(215, 111);
            this.txtsodienthangtruoc.Name = "txtsodienthangtruoc";
            this.txtsodienthangtruoc.Size = new System.Drawing.Size(78, 22);
            this.txtsodienthangtruoc.TabIndex = 26;
            // 
            // txtsodienthangsau
            // 
            this.txtsodienthangsau.Location = new System.Drawing.Point(215, 146);
            this.txtsodienthangsau.Name = "txtsodienthangsau";
            this.txtsodienthangsau.Size = new System.Drawing.Size(78, 22);
            this.txtsodienthangsau.TabIndex = 25;
            // 
            // txtsonuocthangsau
            // 
            this.txtsonuocthangsau.Location = new System.Drawing.Point(523, 144);
            this.txtsonuocthangsau.Name = "txtsonuocthangsau";
            this.txtsonuocthangsau.Size = new System.Drawing.Size(78, 22);
            this.txtsonuocthangsau.TabIndex = 22;
            // 
            // txtsonuocthangtruoc
            // 
            this.txtsonuocthangtruoc.Location = new System.Drawing.Point(523, 107);
            this.txtsonuocthangtruoc.Name = "txtsonuocthangtruoc";
            this.txtsonuocthangtruoc.Size = new System.Drawing.Size(78, 22);
            this.txtsonuocthangtruoc.TabIndex = 21;
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(215, 35);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(303, 22);
            this.txtmahoadon.TabIndex = 20;
            // 
            // grhoadon1
            // 
            this.grhoadon1.Controls.Add(this.cbbtimkiem);
            this.grhoadon1.Controls.Add(this.btin);
            this.grhoadon1.Controls.Add(this.bttimkiem);
            this.grhoadon1.Controls.Add(this.btluu);
            this.grhoadon1.Controls.Add(this.bthuy);
            this.grhoadon1.Controls.Add(this.btsua);
            this.grhoadon1.Controls.Add(this.btxoa);
            this.grhoadon1.Controls.Add(this.btthem);
            this.grhoadon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grhoadon1.Location = new System.Drawing.Point(723, 12);
            this.grhoadon1.Name = "grhoadon1";
            this.grhoadon1.Size = new System.Drawing.Size(257, 186);
            this.grhoadon1.TabIndex = 30;
            this.grhoadon1.Text = "Chức năng";
            // 
            // cbbtimkiem
            // 
            this.cbbtimkiem.FormattingEnabled = true;
            this.cbbtimkiem.Location = new System.Drawing.Point(128, 142);
            this.cbbtimkiem.Name = "cbbtimkiem";
            this.cbbtimkiem.Size = new System.Drawing.Size(101, 24);
            this.cbbtimkiem.TabIndex = 7;
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(128, 104);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(104, 23);
            this.btin.TabIndex = 6;
            this.btin.Text = "In dánh sách";
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(17, 143);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(108, 23);
            this.bttimkiem.TabIndex = 5;
            this.bttimkiem.Text = "Tìm kiếm";
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(14, 69);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(108, 23);
            this.btluu.TabIndex = 4;
            this.btluu.Text = "Lưu";
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(14, 106);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(108, 23);
            this.bthuy.TabIndex = 3;
            this.bthuy.Text = "Huỷ";
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(125, 34);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(104, 23);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(128, 69);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(104, 23);
            this.btxoa.TabIndex = 1;
            this.btxoa.Text = "Xoá";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(14, 34);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(108, 23);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm mới";
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 518);
            this.Controls.Add(this.grhoadon1);
            this.Controls.Add(this.grhoadon);
            this.Controls.Add(this.bhd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoadon";
            ((System.ComponentModel.ISupportInitialize)(this.bhd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon)).EndInit();
            this.grhoadon.ResumeLayout(false);
            this.grhoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangtruoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthangsau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangsau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsonuocthangtruoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grhoadon1)).EndInit();
            this.grhoadon1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bhd;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Label lbsonuocthangtruoc;
        private System.Windows.Forms.Label lbsodienthangsau;
        private System.Windows.Forms.Label lbsodienthangtruoc;
        private System.Windows.Forms.Label lbmaphong;
        private System.Windows.Forms.Label lbsonuocthangsau;
        private DevExpress.XtraEditors.GroupControl grhoadon;
        private DevExpress.XtraEditors.GroupControl grhoadon1;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private System.Windows.Forms.ComboBox cbbtimkiem;
        private DevExpress.XtraEditors.SimpleButton btin;
        private DevExpress.XtraEditors.SimpleButton bttimkiem;
        private DevExpress.XtraEditors.SimpleButton btluu;
        private DevExpress.XtraEditors.SimpleButton bthuy;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.TextEdit txtmaphong;
        private DevExpress.XtraEditors.TextEdit txtsodienthangtruoc;
        private DevExpress.XtraEditors.TextEdit txtsodienthangsau;
        private DevExpress.XtraEditors.TextEdit txtsonuocthangsau;
        private DevExpress.XtraEditors.TextEdit txtsonuocthangtruoc;
        private DevExpress.XtraEditors.TextEdit txtmahoadon;
    }
}
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
            this.bhd = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.rbtmahopdong = new System.Windows.Forms.RadioButton();
            this.rbtmaphong = new System.Windows.Forms.RadioButton();
            this.rbtmasinhvien = new System.Windows.Forms.RadioButton();
            this.txtmahopdong = new System.Windows.Forms.TextBox();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txtthoihan = new System.Windows.Forms.TextBox();
            this.lbthoihan = new System.Windows.Forms.Label();
            this.lbmaphong = new System.Windows.Forms.Label();
            this.lbmasinhvien = new System.Windows.Forms.Label();
            this.lbmahopdong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bhd)).BeginInit();
            this.SuspendLayout();
            // 
            // bhd
            // 
            this.bhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bhd.Location = new System.Drawing.Point(38, 36);
            this.bhd.Name = "bhd";
            this.bhd.RowTemplate.Height = 24;
            this.bhd.Size = new System.Drawing.Size(536, 467);
            this.bhd.TabIndex = 0;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(678, 81);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(678, 407);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(75, 23);
            this.bttimkiem.TabIndex = 2;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(1035, 81);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(848, 81);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 4;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(828, 408);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(282, 22);
            this.txttimkiem.TabIndex = 5;
            // 
            // rbtmahopdong
            // 
            this.rbtmahopdong.AutoSize = true;
            this.rbtmahopdong.Location = new System.Drawing.Point(678, 463);
            this.rbtmahopdong.Name = "rbtmahopdong";
            this.rbtmahopdong.Size = new System.Drawing.Size(116, 21);
            this.rbtmahopdong.TabIndex = 6;
            this.rbtmahopdong.TabStop = true;
            this.rbtmahopdong.Text = "Mã  hợp đồng";
            this.rbtmahopdong.UseVisualStyleBackColor = true;
            // 
            // rbtmaphong
            // 
            this.rbtmaphong.AutoSize = true;
            this.rbtmaphong.Location = new System.Drawing.Point(1000, 463);
            this.rbtmaphong.Name = "rbtmaphong";
            this.rbtmaphong.Size = new System.Drawing.Size(92, 21);
            this.rbtmaphong.TabIndex = 7;
            this.rbtmaphong.TabStop = true;
            this.rbtmaphong.Text = "Mã phòng";
            this.rbtmaphong.UseVisualStyleBackColor = true;
            // 
            // rbtmasinhvien
            // 
            this.rbtmasinhvien.AutoSize = true;
            this.rbtmasinhvien.Location = new System.Drawing.Point(848, 463);
            this.rbtmasinhvien.Name = "rbtmasinhvien";
            this.rbtmasinhvien.Size = new System.Drawing.Size(108, 21);
            this.rbtmasinhvien.TabIndex = 8;
            this.rbtmasinhvien.TabStop = true;
            this.rbtmasinhvien.Text = "Mã sinh viên";
            this.rbtmasinhvien.UseVisualStyleBackColor = true;
            // 
            // txtmahopdong
            // 
            this.txtmahopdong.Location = new System.Drawing.Point(828, 172);
            this.txtmahopdong.Name = "txtmahopdong";
            this.txtmahopdong.Size = new System.Drawing.Size(282, 22);
            this.txtmahopdong.TabIndex = 9;
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Location = new System.Drawing.Point(828, 225);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(282, 22);
            this.txtmasinhvien.TabIndex = 10;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(828, 282);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(282, 22);
            this.txtmaphong.TabIndex = 11;
            // 
            // txtthoihan
            // 
            this.txtthoihan.Location = new System.Drawing.Point(828, 334);
            this.txtthoihan.Name = "txtthoihan";
            this.txtthoihan.Size = new System.Drawing.Size(282, 22);
            this.txtthoihan.TabIndex = 12;
            // 
            // lbthoihan
            // 
            this.lbthoihan.AutoSize = true;
            this.lbthoihan.Location = new System.Drawing.Point(675, 339);
            this.lbthoihan.Name = "lbthoihan";
            this.lbthoihan.Size = new System.Drawing.Size(64, 17);
            this.lbthoihan.TabIndex = 13;
            this.lbthoihan.Text = "Thời hạn";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Location = new System.Drawing.Point(675, 287);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(71, 17);
            this.lbmaphong.TabIndex = 13;
            this.lbmaphong.Text = "Mã phòng";
            // 
            // lbmasinhvien
            // 
            this.lbmasinhvien.AutoSize = true;
            this.lbmasinhvien.Location = new System.Drawing.Point(675, 230);
            this.lbmasinhvien.Name = "lbmasinhvien";
            this.lbmasinhvien.Size = new System.Drawing.Size(87, 17);
            this.lbmasinhvien.TabIndex = 13;
            this.lbmasinhvien.Text = "Mã sinh viên";
            // 
            // lbmahopdong
            // 
            this.lbmahopdong.AutoSize = true;
            this.lbmahopdong.Location = new System.Drawing.Point(675, 177);
            this.lbmahopdong.Name = "lbmahopdong";
            this.lbmahopdong.Size = new System.Drawing.Size(91, 17);
            this.lbmahopdong.TabIndex = 13;
            this.lbmahopdong.Text = "Mã hợp đồng";
            // 
            // frmHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 531);
            this.Controls.Add(this.lbmahopdong);
            this.Controls.Add(this.lbmasinhvien);
            this.Controls.Add(this.lbmaphong);
            this.Controls.Add(this.lbthoihan);
            this.Controls.Add(this.txtthoihan);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.txtmasinhvien);
            this.Controls.Add(this.txtmahopdong);
            this.Controls.Add(this.rbtmasinhvien);
            this.Controls.Add(this.rbtmaphong);
            this.Controls.Add(this.rbtmahopdong);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.bhd);
            this.Name = "frmHopdong";
            this.Text = "frmHopdong";
            ((System.ComponentModel.ISupportInitialize)(this.bhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bhd;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rbtmahopdong;
        private System.Windows.Forms.RadioButton rbtmaphong;
        private System.Windows.Forms.RadioButton rbtmasinhvien;
        private System.Windows.Forms.TextBox txtmahopdong;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txtthoihan;
        private System.Windows.Forms.Label lbthoihan;
        private System.Windows.Forms.Label lbmaphong;
        private System.Windows.Forms.Label lbmasinhvien;
        private System.Windows.Forms.Label lbmahopdong;
    }
}
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
            this.lbgianuoc = new System.Windows.Forms.Label();
            this.lbgiadien = new System.Windows.Forms.Label();
            this.lbsonuocthangtruoc = new System.Windows.Forms.Label();
            this.lbsodienthangsau = new System.Windows.Forms.Label();
            this.lbsodienthangtruoc = new System.Windows.Forms.Label();
            this.lbmaphong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lbsonuocthangsau = new System.Windows.Forms.Label();
            this.btinhoadon = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.rbtmaphong = new System.Windows.Forms.RadioButton();
            this.rbtmahoadon = new System.Windows.Forms.RadioButton();
            this.btxuat = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bhd)).BeginInit();
            this.SuspendLayout();
            // 
            // bhd
            // 
            this.bhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bhd.Location = new System.Drawing.Point(20, 299);
            this.bhd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bhd.Name = "bhd";
            this.bhd.RowTemplate.Height = 24;
            this.bhd.Size = new System.Drawing.Size(958, 192);
            this.bhd.TabIndex = 0;
            // 
            // lbmahd
            // 
            this.lbmahd.AutoSize = true;
            this.lbmahd.Location = new System.Drawing.Point(17, 19);
            this.lbmahd.Name = "lbmahd";
            this.lbmahd.Size = new System.Drawing.Size(63, 13);
            this.lbmahd.TabIndex = 1;
            this.lbmahd.Text = "Mã hoá đơn";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(17, 263);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(52, 13);
            this.lbtongtien.TabIndex = 2;
            this.lbtongtien.Text = "Tổng tiền";
            // 
            // lbgianuoc
            // 
            this.lbgianuoc.AutoSize = true;
            this.lbgianuoc.Location = new System.Drawing.Point(17, 232);
            this.lbgianuoc.Name = "lbgianuoc";
            this.lbgianuoc.Size = new System.Drawing.Size(49, 13);
            this.lbgianuoc.TabIndex = 3;
            this.lbgianuoc.Text = "Giá nước";
            // 
            // lbgiadien
            // 
            this.lbgiadien.AutoSize = true;
            this.lbgiadien.Location = new System.Drawing.Point(17, 201);
            this.lbgiadien.Name = "lbgiadien";
            this.lbgiadien.Size = new System.Drawing.Size(45, 13);
            this.lbgiadien.TabIndex = 4;
            this.lbgiadien.Text = "Giá điện";
            // 
            // lbsonuocthangtruoc
            // 
            this.lbsonuocthangtruoc.AutoSize = true;
            this.lbsonuocthangtruoc.Location = new System.Drawing.Point(17, 145);
            this.lbsonuocthangtruoc.Name = "lbsonuocthangtruoc";
            this.lbsonuocthangtruoc.Size = new System.Drawing.Size(106, 13);
            this.lbsonuocthangtruoc.TabIndex = 5;
            this.lbsonuocthangtruoc.Text = "Số nước tháng trước";
            // 
            // lbsodienthangsau
            // 
            this.lbsodienthangsau.AutoSize = true;
            this.lbsodienthangsau.Location = new System.Drawing.Point(17, 112);
            this.lbsodienthangsau.Name = "lbsodienthangsau";
            this.lbsodienthangsau.Size = new System.Drawing.Size(93, 13);
            this.lbsodienthangsau.TabIndex = 7;
            this.lbsodienthangsau.Text = "Số điện tháng sau";
            // 
            // lbsodienthangtruoc
            // 
            this.lbsodienthangtruoc.AutoSize = true;
            this.lbsodienthangtruoc.Location = new System.Drawing.Point(17, 81);
            this.lbsodienthangtruoc.Name = "lbsodienthangtruoc";
            this.lbsodienthangtruoc.Size = new System.Drawing.Size(102, 13);
            this.lbsodienthangtruoc.TabIndex = 8;
            this.lbsodienthangtruoc.Text = "Số điện tháng trước";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Location = new System.Drawing.Point(17, 48);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(54, 13);
            this.lbmaphong.TabIndex = 9;
            this.lbmaphong.Text = "Mã phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 21);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 261);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 21);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 229);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 21);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 198);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(297, 21);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(153, 170);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(297, 21);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(153, 140);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(297, 21);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(153, 107);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(297, 21);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(153, 76);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(297, 21);
            this.textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(153, 43);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(297, 21);
            this.textBox9.TabIndex = 18;
            // 
            // lbsonuocthangsau
            // 
            this.lbsonuocthangsau.AutoSize = true;
            this.lbsonuocthangsau.Location = new System.Drawing.Point(17, 175);
            this.lbsonuocthangsau.Name = "lbsonuocthangsau";
            this.lbsonuocthangsau.Size = new System.Drawing.Size(97, 13);
            this.lbsonuocthangsau.TabIndex = 19;
            this.lbsonuocthangsau.Text = "Số nước tháng sau";
            // 
            // btinhoadon
            // 
            this.btinhoadon.Location = new System.Drawing.Point(723, 32);
            this.btinhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btinhoadon.Name = "btinhoadon";
            this.btinhoadon.Size = new System.Drawing.Size(64, 19);
            this.btinhoadon.TabIndex = 20;
            this.btinhoadon.Text = "Sửa";
            this.btinhoadon.UseVisualStyleBackColor = true;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(557, 172);
            this.bttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(64, 19);
            this.bttimkiem.TabIndex = 22;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(557, 96);
            this.btxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(64, 19);
            this.btxoa.TabIndex = 23;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(557, 32);
            this.btthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(64, 19);
            this.btthem.TabIndex = 24;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // rbtmaphong
            // 
            this.rbtmaphong.AutoSize = true;
            this.rbtmaphong.Location = new System.Drawing.Point(557, 220);
            this.rbtmaphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtmaphong.Name = "rbtmaphong";
            this.rbtmaphong.Size = new System.Drawing.Size(72, 17);
            this.rbtmaphong.TabIndex = 25;
            this.rbtmaphong.TabStop = true;
            this.rbtmaphong.Text = "Mã phòng";
            this.rbtmaphong.UseVisualStyleBackColor = true;
            // 
            // rbtmahoadon
            // 
            this.rbtmahoadon.AutoSize = true;
            this.rbtmahoadon.Location = new System.Drawing.Point(708, 220);
            this.rbtmahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtmahoadon.Name = "rbtmahoadon";
            this.rbtmahoadon.Size = new System.Drawing.Size(81, 17);
            this.rbtmahoadon.TabIndex = 26;
            this.rbtmahoadon.TabStop = true;
            this.rbtmahoadon.Text = "Mã hoá đơn";
            this.rbtmahoadon.UseVisualStyleBackColor = true;
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(723, 96);
            this.btxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(64, 19);
            this.btxuat.TabIndex = 27;
            this.btxuat.Text = "In hoá đơn";
            this.btxuat.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(656, 172);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(222, 21);
            this.txttimkiem.TabIndex = 28;
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 421);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btxuat);
            this.Controls.Add(this.rbtmahoadon);
            this.Controls.Add(this.rbtmaphong);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.btinhoadon);
            this.Controls.Add(this.lbsonuocthangsau);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbmaphong);
            this.Controls.Add(this.lbsodienthangtruoc);
            this.Controls.Add(this.lbsodienthangsau);
            this.Controls.Add(this.lbsonuocthangtruoc);
            this.Controls.Add(this.lbgiadien);
            this.Controls.Add(this.lbgianuoc);
            this.Controls.Add(this.lbtongtien);
            this.Controls.Add(this.lbmahd);
            this.Controls.Add(this.bhd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoadon";
            ((System.ComponentModel.ISupportInitialize)(this.bhd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bhd;
        private System.Windows.Forms.Label lbmahd;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Label lbgianuoc;
        private System.Windows.Forms.Label lbgiadien;
        private System.Windows.Forms.Label lbsonuocthangtruoc;
        private System.Windows.Forms.Label lbsodienthangsau;
        private System.Windows.Forms.Label lbsodienthangtruoc;
        private System.Windows.Forms.Label lbmaphong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lbsonuocthangsau;
        private System.Windows.Forms.Button btinhoadon;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.RadioButton rbtmaphong;
        private System.Windows.Forms.RadioButton rbtmahoadon;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}
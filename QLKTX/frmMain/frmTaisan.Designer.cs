﻿namespace frmMain
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
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtmats = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txttents = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bts)).BeginInit();
            this.SuspendLayout();
            // 
            // bts
            // 
            this.bts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bts.Location = new System.Drawing.Point(42, 214);
            this.bts.Name = "bts";
            this.bts.RowTemplate.Height = 24;
            this.bts.Size = new System.Drawing.Size(761, 267);
            this.bts.TabIndex = 0;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(39, 27);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(22, 17);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "ID";
            // 
            // lbmats
            // 
            this.lbmats.AutoSize = true;
            this.lbmats.Location = new System.Drawing.Point(39, 76);
            this.lbmats.Name = "lbmats";
            this.lbmats.Size = new System.Drawing.Size(68, 17);
            this.lbmats.TabIndex = 2;
            this.lbmats.Text = "Mã tài sản";
            // 
            // lbtents
            // 
            this.lbtents.AutoSize = true;
            this.lbtents.Location = new System.Drawing.Point(527, 30);
            this.lbtents.Name = "lbtents";
            this.lbtents.Size = new System.Drawing.Size(74, 17);
            this.lbtents.TabIndex = 3;
            this.lbtents.Text = "Tên tài sản";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(527, 76);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(63, 17);
            this.lbsoluong.TabIndex = 4;
            this.lbsoluong.Text = "Số lượng";
            // 
            // lbmaphong
            // 
            this.lbmaphong.AutoSize = true;
            this.lbmaphong.Location = new System.Drawing.Point(39, 135);
            this.lbmaphong.Name = "lbmaphong";
            this.lbmaphong.Size = new System.Drawing.Size(69, 17);
            this.lbmaphong.TabIndex = 5;
            this.lbmaphong.Text = "Mã phòng";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(831, 322);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(831, 394);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 8;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(831, 458);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(136, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(321, 23);
            this.txtid.TabIndex = 10;
            // 
            // txtmats
            // 
            this.txtmats.Location = new System.Drawing.Point(136, 73);
            this.txtmats.Name = "txtmats";
            this.txtmats.Size = new System.Drawing.Size(321, 23);
            this.txtmats.TabIndex = 11;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(136, 129);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(321, 23);
            this.txtmaphong.TabIndex = 12;
            // 
            // txttents
            // 
            this.txttents.Location = new System.Drawing.Point(647, 27);
            this.txttents.Name = "txttents";
            this.txttents.Size = new System.Drawing.Size(331, 23);
            this.txttents.TabIndex = 13;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(647, 70);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(331, 23);
            this.txtsoluong.TabIndex = 14;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(831, 214);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(111, 23);
            this.bttimkiem.TabIndex = 15;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(831, 264);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(234, 23);
            this.txttimkiem.TabIndex = 16;
            // 
            // frmTaisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 512);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttents);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.txtmats);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.lbmaphong);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.lbtents);
            this.Controls.Add(this.lbmats);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.bts);
            this.Name = "frmTaisan";
            this.Text = "frmTaisan";
            ((System.ComponentModel.ISupportInitialize)(this.bts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bts;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbmats;
        private System.Windows.Forms.Label lbtents;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbmaphong;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtmats;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txttents;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}
namespace frmMain.Class.Minh
{
    partial class frmDoimatkhau
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
            this.txtManv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassnew = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassnew1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassnew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassnew1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(12, 41);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(263, 20);
            this.txtManv.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nhập mật khẩu cũ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(263, 20);
            this.txtPass.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nhập mật khẩu mới";
            // 
            // txtPassnew
            // 
            this.txtPassnew.Location = new System.Drawing.Point(12, 155);
            this.txtPassnew.Name = "txtPassnew";
            this.txtPassnew.Size = new System.Drawing.Size(263, 20);
            this.txtPassnew.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(100, 259);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Đổi mật khẩu";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 196);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtPassnew1
            // 
            this.txtPassnew1.Location = new System.Drawing.Point(12, 215);
            this.txtPassnew1.Name = "txtPassnew1";
            this.txtPassnew1.Size = new System.Drawing.Size(263, 20);
            this.txtPassnew1.TabIndex = 1;
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 307);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPassnew1);
            this.Controls.Add(this.txtPassnew);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoimatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.txtManv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassnew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassnew1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtManv;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPassnew;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPassnew1;

    }
}
namespace QUANLYNHANSU
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.lblDangKyTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTaiKhoan.Location = new System.Drawing.Point(221, 107);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(261, 32);
            this.txtTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.ForeColor = System.Drawing.Color.Gold;
            this.txtMatKhau.Location = new System.Drawing.Point(221, 191);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(261, 32);
            this.txtMatKhau.TabIndex = 5;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.Location = new System.Drawing.Point(151, 268);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(167, 28);
            this.chkHienMatKhau.TabIndex = 6;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(335, 268);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(147, 24);
            this.lblQuenMatKhau.TabIndex = 7;
            this.lblQuenMatKhau.TabStop = true;
            this.lblQuenMatKhau.Text = "Quên mật khẩu";
            // 
            // lblDangKyTaiKhoan
            // 
            this.lblDangKyTaiKhoan.AutoSize = true;
            this.lblDangKyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangKyTaiKhoan.Location = new System.Drawing.Point(499, 268);
            this.lblDangKyTaiKhoan.Name = "lblDangKyTaiKhoan";
            this.lblDangKyTaiKhoan.Size = new System.Drawing.Size(172, 24);
            this.lblDangKyTaiKhoan.TabIndex = 8;
            this.lblDangKyTaiKhoan.TabStop = true;
            this.lblDangKyTaiKhoan.Text = "Đăng ký tài khoản";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(134, 319);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(184, 69);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(367, 319);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(184, 69);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(703, 448);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDangKyTaiKhoan);
            this.Controls.Add(this.lblQuenMatKhau);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.LinkLabel lblQuenMatKhau;
        private System.Windows.Forms.LinkLabel lblDangKyTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
    }
}
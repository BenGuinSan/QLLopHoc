namespace QLLopHoc.GUI.DangNhap
{
    partial class Signinfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signinfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.thanhngang = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.btnHideMK = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnShowMK = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng nhập";
            // 
            // thanhngang
            // 
            this.thanhngang.BackColor = System.Drawing.Color.Black;
            this.thanhngang.Location = new System.Drawing.Point(57, 240);
            this.thanhngang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thanhngang.Name = "thanhngang";
            this.thanhngang.Size = new System.Drawing.Size(252, 2);
            this.thanhngang.TabIndex = 6;
            this.thanhngang.Text = "label2";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.Location = new System.Drawing.Point(59, 211);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(248, 21);
            this.txt_email.TabIndex = 5;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 2);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.Silver;
            this.txt_matkhau.Location = new System.Drawing.Point(61, 269);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(218, 21);
            this.txt_matkhau.TabIndex = 8;
            this.txt_matkhau.Text = "Mật khẩu";
            this.txt_matkhau.Enter += new System.EventHandler(this.txt_matkhau_Enter);
            this.txt_matkhau.Leave += new System.EventHandler(this.txt_matkhau_Leave);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(64, 350);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(196, 45);
            this.btn_dangnhap.TabIndex = 11;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.Color.White;
            this.btn_dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btn_dangky.Location = new System.Drawing.Point(64, 404);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(196, 36);
            this.btn_dangky.TabIndex = 12;
            this.btn_dangky.Text = "Đăng ký";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // btnHideMK
            // 
            this.btnHideMK.Image = global::QLLopHoc.Properties.Resources.hide;
            this.btnHideMK.Location = new System.Drawing.Point(285, 269);
            this.btnHideMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHideMK.Name = "btnHideMK";
            this.btnHideMK.Size = new System.Drawing.Size(24, 24);
            this.btnHideMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHideMK.TabIndex = 15;
            this.btnHideMK.TabStop = false;
            this.btnHideMK.Click += new System.EventHandler(this.btnHideMK_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(110, 17);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 104);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // btnShowMK
            // 
            this.btnShowMK.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMK.Image")));
            this.btnShowMK.Location = new System.Drawing.Point(285, 269);
            this.btnShowMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowMK.Name = "btnShowMK";
            this.btnShowMK.Size = new System.Drawing.Size(24, 24);
            this.btnShowMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnShowMK.TabIndex = 10;
            this.btnShowMK.TabStop = false;
            this.btnShowMK.Click += new System.EventHandler(this.btnShowMK_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 268);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 210);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Signinfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 466);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.thanhngang);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowMK);
            this.Controls.Add(this.btnHideMK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Signinfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signinfrm";
            this.Load += new System.EventHandler(this.Signinfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHideMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label thanhngang;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.PictureBox btnShowMK;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnHideMK;
    }
}
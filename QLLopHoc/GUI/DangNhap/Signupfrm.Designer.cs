namespace QLLopHoc.GUI.DangNhap
{
    partial class Signupfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signupfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowMK = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.thanhngang = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHideMK = new System.Windows.Forms.PictureBox();
            this.btnShowMK2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nhaplaimk = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnHideMK2 = new System.Windows.Forms.PictureBox();
            this.btn_qldangnhap = new System.Windows.Forms.Button();
            this.btn_xndangky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowMK2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideMK2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng ký";
            // 
            // btnShowMK
            // 
            this.btnShowMK.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMK.Image")));
            this.btnShowMK.Location = new System.Drawing.Point(376, 306);
            this.btnShowMK.Name = "btnShowMK";
            this.btnShowMK.Size = new System.Drawing.Size(24, 24);
            this.btnShowMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnShowMK.TabIndex = 22;
            this.btnShowMK.TabStop = false;
            this.btnShowMK.Click += new System.EventHandler(this.btnShowMK_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 2);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.Silver;
            this.txt_matkhau.Location = new System.Drawing.Point(77, 306);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(290, 27);
            this.txt_matkhau.TabIndex = 20;
            this.txt_matkhau.Text = "Mật khẩu";
            this.txt_matkhau.Enter += new System.EventHandler(this.txt_matkhau_Enter);
            this.txt_matkhau.Leave += new System.EventHandler(this.txt_matkhau_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // thanhngang
            // 
            this.thanhngang.BackColor = System.Drawing.Color.Black;
            this.thanhngang.Location = new System.Drawing.Point(72, 271);
            this.thanhngang.Name = "thanhngang";
            this.thanhngang.Size = new System.Drawing.Size(336, 2);
            this.thanhngang.TabIndex = 18;
            this.thanhngang.Text = "label2";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.Location = new System.Drawing.Point(75, 235);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(331, 27);
            this.txt_email.TabIndex = 17;
            this.txt_email.Text = "Email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnHideMK
            // 
            this.btnHideMK.Image = global::QLLopHoc.Properties.Resources.hide;
            this.btnHideMK.Location = new System.Drawing.Point(376, 306);
            this.btnHideMK.Name = "btnHideMK";
            this.btnHideMK.Size = new System.Drawing.Size(24, 24);
            this.btnHideMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHideMK.TabIndex = 23;
            this.btnHideMK.TabStop = false;
            this.btnHideMK.Click += new System.EventHandler(this.btnHideMK_Click);
            // 
            // btnShowMK2
            // 
            this.btnShowMK2.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMK2.Image")));
            this.btnShowMK2.Location = new System.Drawing.Point(376, 378);
            this.btnShowMK2.Name = "btnShowMK2";
            this.btnShowMK2.Size = new System.Drawing.Size(24, 24);
            this.btnShowMK2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnShowMK2.TabIndex = 27;
            this.btnShowMK2.TabStop = false;
            this.btnShowMK2.Click += new System.EventHandler(this.btnShowMK2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 2);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // txt_nhaplaimk
            // 
            this.txt_nhaplaimk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nhaplaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhaplaimk.ForeColor = System.Drawing.Color.Silver;
            this.txt_nhaplaimk.Location = new System.Drawing.Point(77, 378);
            this.txt_nhaplaimk.Name = "txt_nhaplaimk";
            this.txt_nhaplaimk.Size = new System.Drawing.Size(290, 27);
            this.txt_nhaplaimk.TabIndex = 25;
            this.txt_nhaplaimk.Text = "Xác nhận mật khẩu";
            this.txt_nhaplaimk.Enter += new System.EventHandler(this.txt_nhaplaimk_Enter);
            this.txt_nhaplaimk.Leave += new System.EventHandler(this.txt_nhaplaimk_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(24, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // btnHideMK2
            // 
            this.btnHideMK2.Image = global::QLLopHoc.Properties.Resources.hide;
            this.btnHideMK2.Location = new System.Drawing.Point(376, 378);
            this.btnHideMK2.Name = "btnHideMK2";
            this.btnHideMK2.Size = new System.Drawing.Size(24, 24);
            this.btnHideMK2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHideMK2.TabIndex = 28;
            this.btnHideMK2.TabStop = false;
            this.btnHideMK2.Click += new System.EventHandler(this.btnHideMK2_Click);
            // 
            // btn_qldangnhap
            // 
            this.btn_qldangnhap.BackColor = System.Drawing.Color.White;
            this.btn_qldangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qldangnhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btn_qldangnhap.Location = new System.Drawing.Point(86, 505);
            this.btn_qldangnhap.Name = "btn_qldangnhap";
            this.btn_qldangnhap.Size = new System.Drawing.Size(261, 44);
            this.btn_qldangnhap.TabIndex = 30;
            this.btn_qldangnhap.Text = "Đăng nhập";
            this.btn_qldangnhap.UseVisualStyleBackColor = false;
            this.btn_qldangnhap.Click += new System.EventHandler(this.btn_qldangnhap_Click);
            // 
            // btn_xndangky
            // 
            this.btn_xndangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btn_xndangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xndangky.ForeColor = System.Drawing.Color.White;
            this.btn_xndangky.Location = new System.Drawing.Point(86, 439);
            this.btn_xndangky.Name = "btn_xndangky";
            this.btn_xndangky.Size = new System.Drawing.Size(261, 55);
            this.btn_xndangky.TabIndex = 29;
            this.btn_xndangky.Text = "Đăng ký";
            this.btn_xndangky.UseVisualStyleBackColor = false;
            this.btn_xndangky.Click += new System.EventHandler(this.btn_xndangky_Click);
            // 
            // Signupfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 573);
            this.Controls.Add(this.btn_qldangnhap);
            this.Controls.Add(this.btn_xndangky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nhaplaimk);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.thanhngang);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowMK);
            this.Controls.Add(this.btnShowMK2);
            this.Controls.Add(this.btnHideMK);
            this.Controls.Add(this.btnHideMK2);
            this.Name = "Signupfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signupfrm";
            this.Load += new System.EventHandler(this.Signupfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnShowMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowMK2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHideMK2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnShowMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label thanhngang;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnHideMK;
        private System.Windows.Forms.PictureBox btnShowMK2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nhaplaimk;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnHideMK2;
        private System.Windows.Forms.Button btn_qldangnhap;
        private System.Windows.Forms.Button btn_xndangky;
    }
}
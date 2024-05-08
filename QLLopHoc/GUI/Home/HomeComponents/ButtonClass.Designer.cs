using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace QLLopHoc.GUI.Home
{
    partial class ButtonClass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonClass));
            this.btnLopHoc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lbl_time_latest = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.AllowDrop = true;
            this.btnLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLopHoc.Location = new System.Drawing.Point(0, 0);
            this.btnLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnLopHoc.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnLopHoc.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLopHoc.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLopHoc.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLopHoc.Size = new System.Drawing.Size(368, 98);
            this.btnLopHoc.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnLopHoc.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnLopHoc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnLopHoc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnLopHoc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLopHoc.StateCommon.Border.Rounding = 5;
            this.btnLopHoc.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLopHoc.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLopHoc.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLopHoc.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLopHoc.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnLopHoc.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLopHoc.TabIndex = 1;
            this.btnLopHoc.Values.Text = "";
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click_1);
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoEllipsis = true;
            this.lblTenLop.BackColor = System.Drawing.Color.White;
            this.lblTenLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenLop.ForeColor = System.Drawing.Color.Black;
            this.lblTenLop.Location = new System.Drawing.Point(75, 15);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(244, 28);
            this.lblTenLop.TabIndex = 3;
            this.lblTenLop.Text = "Lập trình C#";
            this.lblTenLop.Click += new System.EventHandler(this.lblTenLop_Click_1);
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoEllipsis = true;
            this.lblChiTiet.BackColor = System.Drawing.Color.White;
            this.lblChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChiTiet.Location = new System.Drawing.Point(75, 46);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(199, 20);
            this.lblChiTiet.TabIndex = 4;
            this.lblChiTiet.Text = "Lập trình C#";
            this.lblChiTiet.Click += new System.EventHandler(this.lblChiTiet_Click_1);
            // 
            // lbl_time_latest
            // 
            this.lbl_time_latest.AutoEllipsis = true;
            this.lbl_time_latest.BackColor = System.Drawing.Color.White;
            this.lbl_time_latest.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_time_latest.ForeColor = System.Drawing.Color.Black;
            this.lbl_time_latest.Location = new System.Drawing.Point(271, 46);
            this.lbl_time_latest.Name = "lbl_time_latest";
            this.lbl_time_latest.Size = new System.Drawing.Size(61, 20);
            this.lbl_time_latest.TabIndex = 5;
            this.lbl_time_latest.Text = "12:30";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_time_latest);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLopHoc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ButtonClass";
            this.Size = new System.Drawing.Size(368, 98);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLopHoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.Label lbl_time_latest;

        public KryptonButton BtnLopHoc { get => btnLopHoc; set => btnLopHoc = value; }
        public Label LblTenLop { get => lblTenLop; set => lblTenLop = value; }
        public Label LblChiTiet { get => lblChiTiet; set => lblChiTiet = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
    }
}

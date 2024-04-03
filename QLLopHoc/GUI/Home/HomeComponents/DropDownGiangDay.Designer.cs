namespace QLLopHoc.GUI.Home.HomeComponents
{
    partial class DropDownGiangDay
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
            this.components = new System.ComponentModel.Container();
            this.timerHieuUngDropDown = new System.Windows.Forms.Timer(this.components);
            this.pnlGiangDayComponent = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoRong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerHieuUngDropDown
            // 
            this.timerHieuUngDropDown.Tick += new System.EventHandler(this.timerHieuUngDropDown_Tick);
            // 
            // pnlGiangDayComponent
            // 
            this.pnlGiangDayComponent.AutoScroll = true;
            this.pnlGiangDayComponent.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGiangDayComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiangDayComponent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlGiangDayComponent.Location = new System.Drawing.Point(0, 65);
            this.pnlGiangDayComponent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGiangDayComponent.Name = "pnlGiangDayComponent";
            this.pnlGiangDayComponent.Size = new System.Drawing.Size(289, 0);
            this.pnlGiangDayComponent.TabIndex = 2;
            this.pnlGiangDayComponent.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMoRong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 65);
            this.panel1.TabIndex = 1;
            // 
            // btnMoRong
            // 
            this.btnMoRong.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnMoRong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoRong.Location = new System.Drawing.Point(250, 21);
            this.btnMoRong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.Size = new System.Drawing.Size(29, 26);
            this.btnMoRong.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.btnMoRong.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnMoRong.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StateCommon.Border.Rounding = 5;
            this.btnMoRong.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.btnMoRong.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMoRong.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btnMoRong.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnMoRong.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnMoRong.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnMoRong.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMoRong.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnMoRong.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnMoRong.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnMoRong.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnMoRong.TabIndex = 16;
            this.btnMoRong.Values.Text = "▼";
            this.btnMoRong.Click += new System.EventHandler(this.btnMoRong_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giảng dạy";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 21);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 26);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // DropDownGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlGiangDayComponent);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DropDownGiangDay";
            this.Size = new System.Drawing.Size(289, 65);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerHieuUngDropDown;
        private System.Windows.Forms.FlowLayoutPanel pnlGiangDayComponent;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMoRong;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

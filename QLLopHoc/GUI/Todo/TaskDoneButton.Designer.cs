namespace QLLopHoc.GUI.Todo
{
    partial class TaskDoneButton
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
            this.lblNotDone = new System.Windows.Forms.Label();
            this.tickPic = new System.Windows.Forms.PictureBox();
            this.btnDaxuly = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.tickPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotDone
            // 
            this.lblNotDone.AutoSize = true;
            this.lblNotDone.BackColor = System.Drawing.Color.White;
            this.lblNotDone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotDone.ForeColor = System.Drawing.Color.Black;
            this.lblNotDone.Location = new System.Drawing.Point(79, 20);
            this.lblNotDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotDone.Name = "lblNotDone";
            this.lblNotDone.Size = new System.Drawing.Size(78, 22);
            this.lblNotDone.TabIndex = 12;
            this.lblNotDone.Text = "Đã xử lý";
            this.lblNotDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotDone.Click += new System.EventHandler(this.lblNotDone_Click);
            // 
            // tickPic
            // 
            this.tickPic.BackColor = System.Drawing.Color.White;
            this.tickPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tickPic.Image = global::QLLopHoc.Properties.Resources.check_mark;
            this.tickPic.Location = new System.Drawing.Point(20, 17);
            this.tickPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tickPic.Name = "tickPic";
            this.tickPic.Size = new System.Drawing.Size(32, 32);
            this.tickPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tickPic.TabIndex = 9;
            this.tickPic.TabStop = false;
            this.tickPic.Click += new System.EventHandler(this.tickPic_Click);
            // 
            // btnDaxuly
            // 
            this.btnDaxuly.Location = new System.Drawing.Point(0, 0);
            this.btnDaxuly.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaxuly.Name = "btnDaxuly";
            this.btnDaxuly.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnDaxuly.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDaxuly.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDaxuly.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDaxuly.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDaxuly.Size = new System.Drawing.Size(215, 61);
            this.btnDaxuly.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnDaxuly.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDaxuly.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnDaxuly.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDaxuly.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.btnDaxuly.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaxuly.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnDaxuly.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnDaxuly.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDaxuly.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDaxuly.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDaxuly.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDaxuly.TabIndex = 13;
            this.btnDaxuly.Values.Text = "";
            // 
            // TaskDoneButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNotDone);
            this.Controls.Add(this.tickPic);
            this.Controls.Add(this.btnDaxuly);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskDoneButton";
            this.Size = new System.Drawing.Size(215, 61);
            ((System.ComponentModel.ISupportInitialize)(this.tickPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tickPic;
        private System.Windows.Forms.Label lblNotDone;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDaxuly;
    }
}

namespace QLLopHoc.GUI.Todo
{
    partial class TaskNotDoneButton
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
            this.sangclockPic = new System.Windows.Forms.PictureBox();
            this.btnChuaxuly = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotDone
            // 
            this.lblNotDone.AutoSize = true;
            this.lblNotDone.BackColor = System.Drawing.Color.White;
            this.lblNotDone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotDone.ForeColor = System.Drawing.Color.Black;
            this.lblNotDone.Location = new System.Drawing.Point(70, 20);
            this.lblNotDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotDone.Name = "lblNotDone";
            this.lblNotDone.Size = new System.Drawing.Size(99, 22);
            this.lblNotDone.TabIndex = 11;
            this.lblNotDone.Text = "Chưa xử lý";
            this.lblNotDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotDone.Click += new System.EventHandler(this.lblNotDone_Click);
            // 
            // sangclockPic
            // 
            this.sangclockPic.BackColor = System.Drawing.Color.White;
            this.sangclockPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sangclockPic.Image = global::QLLopHoc.Properties.Resources._interface;
            this.sangclockPic.Location = new System.Drawing.Point(20, 17);
            this.sangclockPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sangclockPic.Name = "sangclockPic";
            this.sangclockPic.Size = new System.Drawing.Size(32, 32);
            this.sangclockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sangclockPic.TabIndex = 12;
            this.sangclockPic.TabStop = false;
            this.sangclockPic.Click += new System.EventHandler(this.sangclockPic_Click);
            // 
            // btnChuaxuly
            // 
            this.btnChuaxuly.Location = new System.Drawing.Point(0, 0);
            this.btnChuaxuly.Margin = new System.Windows.Forms.Padding(2);
            this.btnChuaxuly.Name = "btnChuaxuly";
            this.btnChuaxuly.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnChuaxuly.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChuaxuly.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChuaxuly.Size = new System.Drawing.Size(215, 61);
            this.btnChuaxuly.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnChuaxuly.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnChuaxuly.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.btnChuaxuly.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaxuly.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnChuaxuly.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnChuaxuly.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnChuaxuly.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnChuaxuly.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChuaxuly.TabIndex = 13;
            this.btnChuaxuly.Values.Text = "";
            // 
            // TaskNotDoneButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sangclockPic);
            this.Controls.Add(this.lblNotDone);
            this.Controls.Add(this.btnChuaxuly);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskNotDoneButton";
            this.Size = new System.Drawing.Size(215, 61);
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotDone;
        private System.Windows.Forms.PictureBox sangclockPic;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChuaxuly;
    }
}

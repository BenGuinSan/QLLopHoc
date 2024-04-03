namespace QLLopHoc.GUI.Todo
{
    partial class TaskExam
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
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblExam = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnDoExam = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBoxDiscuss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscuss)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton3.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(676, 80);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 10;
            this.kryptonButton3.TabIndex = 15;
            this.kryptonButton3.Values.Text = "";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.Location = new System.Drawing.Point(138, 56);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(63, 16);
            this.lblExam.TabIndex = 17;
            this.lblExam.Text = "Kiểm tra";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoEllipsis = true;
            this.lblEnd.BackColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(255, 54);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(224, 18);
            this.lblEnd.TabIndex = 19;
            // 
            // btnDoExam
            // 
            this.btnDoExam.Location = new System.Drawing.Point(513, 20);
            this.btnDoExam.Name = "btnDoExam";
            this.btnDoExam.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoExam.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDoExam.Size = new System.Drawing.Size(136, 45);
            this.btnDoExam.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoExam.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDoExam.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDoExam.StateCommon.Border.Rounding = 5;
            this.btnDoExam.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDoExam.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoExam.TabIndex = 20;
            this.btnDoExam.Values.Text = "";
            // 
            // pictureBoxDiscuss
            // 
            this.pictureBoxDiscuss.BackColor = System.Drawing.Color.White;
            this.pictureBoxDiscuss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDiscuss.Image = global::QLLopHoc.Properties.Resources.exam;
            this.pictureBoxDiscuss.InitialImage = null;
            this.pictureBoxDiscuss.Location = new System.Drawing.Point(28, 9);
            this.pictureBoxDiscuss.Name = "pictureBoxDiscuss";
            this.pictureBoxDiscuss.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxDiscuss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDiscuss.TabIndex = 16;
            this.pictureBoxDiscuss.TabStop = false;
            // 
            // TaskExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDoExam);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.pictureBoxDiscuss);
            this.Controls.Add(this.kryptonButton3);
            this.Name = "TaskExam";
            this.Size = new System.Drawing.Size(676, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscuss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.PictureBox pictureBoxDiscuss;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Label lblEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDoExam;
    }
}

namespace QLLopHoc.GUI.Todo
{
    partial class TaskHomeWork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblTypeclass = new System.Windows.Forms.Label();
            this.btnDoHomework = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBoxHomework = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomework)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDeadline);
            this.panel1.Controls.Add(this.lblTypeclass);
            this.panel1.Location = new System.Drawing.Point(117, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 31);
            this.panel1.TabIndex = 10;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoEllipsis = true;
            this.lblDeadline.Location = new System.Drawing.Point(95, 7);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(270, 16);
            this.lblDeadline.TabIndex = 6;
            // 
            // lblTypeclass
            // 
            this.lblTypeclass.AutoSize = true;
            this.lblTypeclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeclass.Location = new System.Drawing.Point(3, 7);
            this.lblTypeclass.Name = "lblTypeclass";
            this.lblTypeclass.Size = new System.Drawing.Size(56, 16);
            this.lblTypeclass.TabIndex = 3;
            this.lblTypeclass.Text = "Bài tập";
            // 
            // btnDoHomework
            // 
            this.btnDoHomework.Location = new System.Drawing.Point(520, 19);
            this.btnDoHomework.Name = "btnDoHomework";
            this.btnDoHomework.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoHomework.Size = new System.Drawing.Size(136, 45);
            this.btnDoHomework.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoHomework.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDoHomework.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDoHomework.StateCommon.Border.Rounding = 5;
            this.btnDoHomework.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDoHomework.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoHomework.TabIndex = 12;
            this.btnDoHomework.Values.Text = "";
            // 
            // pictureBoxHomework
            // 
            this.pictureBoxHomework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHomework.Image = global::QLLopHoc.Properties.Resources.homework;
            this.pictureBoxHomework.InitialImage = null;
            this.pictureBoxHomework.Location = new System.Drawing.Point(28, 9);
            this.pictureBoxHomework.Name = "pictureBoxHomework";
            this.pictureBoxHomework.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxHomework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHomework.TabIndex = 8;
            this.pictureBoxHomework.TabStop = false;
            // 
            // TaskHomeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDoHomework);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxHomework);
            this.Name = "TaskHomeWork";
            this.Size = new System.Drawing.Size(676, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHomework;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblTypeclass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDoHomework;
    }
}

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lophoc = new System.Windows.Forms.Label();
            this.btnTask = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomework)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDeadline);
            this.panel1.Controls.Add(this.lblTypeclass);
            this.panel1.Location = new System.Drawing.Point(88, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 25);
            this.panel1.TabIndex = 10;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoEllipsis = true;
            this.lblDeadline.Location = new System.Drawing.Point(71, 6);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(202, 13);
            this.lblDeadline.TabIndex = 6;
            // 
            // lblTypeclass
            // 
            this.lblTypeclass.AutoSize = true;
            this.lblTypeclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeclass.Location = new System.Drawing.Point(2, 6);
            this.lblTypeclass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeclass.Name = "lblTypeclass";
            this.lblTypeclass.Size = new System.Drawing.Size(47, 13);
            this.lblTypeclass.TabIndex = 3;
            this.lblTypeclass.Text = "Bài tập";
            // 
            // btnDoHomework
            // 
            this.btnDoHomework.Location = new System.Drawing.Point(390, 15);
            this.btnDoHomework.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoHomework.Name = "btnDoHomework";
            this.btnDoHomework.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoHomework.Size = new System.Drawing.Size(102, 37);
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
            this.btnDoHomework.Click += new System.EventHandler(this.btnDoHomework_Click);
            // 
            // pictureBoxHomework
            // 
            this.pictureBoxHomework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHomework.Image = global::QLLopHoc.Properties.Resources.homework;
            this.pictureBoxHomework.InitialImage = null;
            this.pictureBoxHomework.Location = new System.Drawing.Point(20, 10);
            this.pictureBoxHomework.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHomework.Name = "pictureBoxHomework";
            this.pictureBoxHomework.Size = new System.Drawing.Size(51, 48);
            this.pictureBoxHomework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHomework.TabIndex = 8;
            this.pictureBoxHomework.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(90, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 16);
            this.lblTitle.TabIndex = 13;
            // 
            // lophoc
            // 
            this.lophoc.AutoEllipsis = true;
            this.lophoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lophoc.Location = new System.Drawing.Point(229, 7);
            this.lophoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lophoc.Name = "lophoc";
            this.lophoc.Size = new System.Drawing.Size(152, 16);
            this.lophoc.TabIndex = 14;
            // 
            // btnTask
            // 
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTask.Location = new System.Drawing.Point(0, 0);
            this.btnTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(507, 65);
            this.btnTask.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTask.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnTask.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTask.StateCommon.Border.Rounding = 10;
            this.btnTask.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnTask.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTask.TabIndex = 15;
            this.btnTask.Values.Text = "";
            // 
            // TaskHomeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lophoc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDoHomework);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxHomework);
            this.Controls.Add(this.btnTask);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskHomeWork";
            this.Size = new System.Drawing.Size(507, 65);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomework)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHomework;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblTypeclass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDoHomework;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lophoc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTask;
    }
}

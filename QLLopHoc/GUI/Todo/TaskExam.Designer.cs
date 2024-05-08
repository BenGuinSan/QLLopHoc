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
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscuss)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton3.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(507, 65);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 10;
            this.kryptonButton3.TabIndex = 15;
            this.kryptonButton3.Values.Text = "";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.Location = new System.Drawing.Point(70, 46);
            this.lblExam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(53, 13);
            this.lblExam.TabIndex = 17;
            this.lblExam.Text = "Kiểm tra";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoEllipsis = true;
            this.lblEnd.BackColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(127, 46);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(168, 15);
            this.lblEnd.TabIndex = 19;
            // 
            // btnDoExam
            // 
            this.btnDoExam.Location = new System.Drawing.Point(394, 16);
            this.btnDoExam.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoExam.Name = "btnDoExam";
            this.btnDoExam.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnDoExam.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDoExam.Size = new System.Drawing.Size(102, 37);
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
            this.btnDoExam.Click += new System.EventHandler(this.btnDoExam_Click);
            // 
            // pictureBoxDiscuss
            // 
            this.pictureBoxDiscuss.BackColor = System.Drawing.Color.White;
            this.pictureBoxDiscuss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDiscuss.Image = global::QLLopHoc.Properties.Resources.exam;
            this.pictureBoxDiscuss.InitialImage = null;
            this.pictureBoxDiscuss.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxDiscuss.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDiscuss.Name = "pictureBoxDiscuss";
            this.pictureBoxDiscuss.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxDiscuss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiscuss.TabIndex = 16;
            this.pictureBoxDiscuss.TabStop = false;
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoEllipsis = true;
            this.lblExamTitle.BackColor = System.Drawing.Color.White;
            this.lblExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTitle.Location = new System.Drawing.Point(70, 7);
            this.lblExamTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(128, 21);
            this.lblExamTitle.TabIndex = 21;
            this.lblExamTitle.Click += new System.EventHandler(this.lblExamTitle_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoEllipsis = true;
            this.lblStart.BackColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(213, 7);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(168, 15);
            this.lblStart.TabIndex = 22;
            // 
            // lblClass
            // 
            this.lblClass.AutoEllipsis = true;
            this.lblClass.BackColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(286, 33);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(104, 13);
            this.lblClass.TabIndex = 23;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(0, 26);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(68, 20);
            this.kryptonButton1.TabIndex = 24;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton2.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(507, 65);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 10;
            this.kryptonButton2.TabIndex = 25;
            this.kryptonButton2.Values.Text = "";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton4.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(507, 65);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.Rounding = 10;
            this.kryptonButton4.TabIndex = 26;
            this.kryptonButton4.Values.Text = "";
            // 
            // TaskExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxDiscuss);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblExamTitle);
            this.Controls.Add(this.btnDoExam);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskExam";
            this.Size = new System.Drawing.Size(507, 65);
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
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblClass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
    }
}

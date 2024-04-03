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
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotDone
            // 
            this.lblNotDone.AutoSize = true;
            this.lblNotDone.BackColor = System.Drawing.Color.White;
            this.lblNotDone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotDone.ForeColor = System.Drawing.Color.Black;
            this.lblNotDone.Location = new System.Drawing.Point(93, 25);
            this.lblNotDone.Name = "lblNotDone";
            this.lblNotDone.Size = new System.Drawing.Size(122, 25);
            this.lblNotDone.TabIndex = 11;
            this.lblNotDone.Text = "Chưa xử lý";
            this.lblNotDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sangclockPic
            // 
            this.sangclockPic.BackColor = System.Drawing.Color.White;
            this.sangclockPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sangclockPic.Image = global::QLLopHoc.Properties.Resources._interface;
            this.sangclockPic.Location = new System.Drawing.Point(27, 21);
            this.sangclockPic.Name = "sangclockPic";
            this.sangclockPic.Size = new System.Drawing.Size(32, 32);
            this.sangclockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sangclockPic.TabIndex = 12;
            this.sangclockPic.TabStop = false;
            // 
            // TaskNotDoneButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sangclockPic);
            this.Controls.Add(this.lblNotDone);
            this.Name = "TaskNotDoneButton";
            this.Size = new System.Drawing.Size(276, 75);
            ((System.ComponentModel.ISupportInitialize)(this.sangclockPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotDone;
        private System.Windows.Forms.PictureBox sangclockPic;
    }
}

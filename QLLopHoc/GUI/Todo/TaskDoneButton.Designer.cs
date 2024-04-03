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
            ((System.ComponentModel.ISupportInitialize)(this.tickPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotDone
            // 
            this.lblNotDone.AutoSize = true;
            this.lblNotDone.BackColor = System.Drawing.Color.White;
            this.lblNotDone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotDone.ForeColor = System.Drawing.Color.Black;
            this.lblNotDone.Location = new System.Drawing.Point(105, 25);
            this.lblNotDone.Name = "lblNotDone";
            this.lblNotDone.Size = new System.Drawing.Size(95, 25);
            this.lblNotDone.TabIndex = 12;
            this.lblNotDone.Text = "Đã xử lý";
            this.lblNotDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tickPic
            // 
            this.tickPic.BackColor = System.Drawing.Color.White;
            this.tickPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tickPic.Image = global::QLLopHoc.Properties.Resources.check_mark;
            this.tickPic.Location = new System.Drawing.Point(27, 21);
            this.tickPic.Name = "tickPic";
            this.tickPic.Size = new System.Drawing.Size(32, 32);
            this.tickPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tickPic.TabIndex = 9;
            this.tickPic.TabStop = false;
            // 
            // TaskDoneButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNotDone);
            this.Controls.Add(this.tickPic);
            this.Name = "TaskDoneButton";
            this.Size = new System.Drawing.Size(276, 75);
            ((System.ComponentModel.ISupportInitialize)(this.tickPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tickPic;
        private System.Windows.Forms.Label lblNotDone;
    }
}

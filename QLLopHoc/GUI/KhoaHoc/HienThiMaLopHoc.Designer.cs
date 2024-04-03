namespace QLLopHoc.GUI.KhoaHoc
{
    partial class HienThiMaLopHoc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaLop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaLop
            // 
            this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaLop.Location = new System.Drawing.Point(16, 26);
            this.lblMaLop.MaximumSize = new System.Drawing.Size(1000, 200);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(1000, 200);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "label1";
            // 
            // HienThiMaLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 253);
            this.Controls.Add(this.lblMaLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HienThiMaLopHoc";
            this.Text = "Mã lớp học";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaLop;
    }
}
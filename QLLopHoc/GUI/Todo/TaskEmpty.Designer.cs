namespace QLLopHoc.GUI.Todo
{
    partial class TaskEmpty
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(306, 218);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Xuất sắc !!";
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.SystemColors.Control;
            this.body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.body.Enabled = false;
            this.body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(84, 283);
            this.body.Name = "body";
            this.body.ReadOnly = true;
            this.body.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.body.Size = new System.Drawing.Size(639, 86);
            this.body.TabIndex = 2;
            this.body.Text = "";
            // 
            // TaskEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.body);
            this.Controls.Add(this.lblTitle);
            this.Name = "TaskEmpty";
            this.Size = new System.Drawing.Size(810, 736);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox body;
    }
}

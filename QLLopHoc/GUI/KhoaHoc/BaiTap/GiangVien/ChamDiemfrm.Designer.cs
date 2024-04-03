namespace QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien
{
    partial class ChamDiemfrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.lblSubmitTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.teacherComment = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.flowFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.MaximumSize = new System.Drawing.Size(1298, 48);
            this.lblTitle.MinimumSize = new System.Drawing.Size(0, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(958, 48);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceholder.Location = new System.Drawing.Point(612, 116);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(228, 22);
            this.lblPlaceholder.TabIndex = 42;
            this.lblPlaceholder.Text = "Viết nhận xét cho bài làm....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-190, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Thông tin bài nộp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Điểm số";
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(463, 86);
            this.score.MaxLength = 4;
            this.score.Multiline = false;
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(129, 114);
            this.score.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.score.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.score.StateCommon.Border.Rounding = 10;
            this.score.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.score.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 30, -1, -1);
            this.score.TabIndex = 39;
            this.score.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.lblSubmitTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 114);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nộp vào lúc:";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.state.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.Red;
            this.state.Location = new System.Drawing.Point(122, 7);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(86, 19);
            this.state.TabIndex = 36;
            this.state.Text = "Đã kết thúc";
            // 
            // lblSubmitTime
            // 
            this.lblSubmitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitTime.Location = new System.Drawing.Point(4, 81);
            this.lblSubmitTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblSubmitTime.Name = "lblSubmitTime";
            this.lblSubmitTime.Size = new System.Drawing.Size(435, 23);
            this.lblSubmitTime.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bài làm của:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoEllipsis = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(4, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(435, 23);
            this.lblStudent.TabIndex = 0;
            // 
            // teacherComment
            // 
            this.teacherComment.Location = new System.Drawing.Point(598, 86);
            this.teacherComment.MaxLength = 300;
            this.teacherComment.Name = "teacherComment";
            this.teacherComment.Size = new System.Drawing.Size(372, 114);
            this.teacherComment.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.teacherComment.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.teacherComment.StateCommon.Border.Rounding = 10;
            this.teacherComment.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherComment.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, -1, -1);
            this.teacherComment.TabIndex = 37;
            this.teacherComment.Tag = "";
            this.teacherComment.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Thông tin bài nộp";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 206);
            this.txtContent.MaxLength = 4000;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(958, 364);
            this.txtContent.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtContent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContent.StateCommon.Border.Rounding = 10;
            this.txtContent.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 8, -1, -1);
            this.txtContent.TabIndex = 44;
            this.txtContent.Text = "";
            // 
            // flowFilePanel
            // 
            this.flowFilePanel.AutoScroll = true;
            this.flowFilePanel.BackColor = System.Drawing.Color.White;
            this.flowFilePanel.Location = new System.Drawing.Point(12, 576);
            this.flowFilePanel.Name = "flowFilePanel";
            this.flowFilePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowFilePanel.Size = new System.Drawing.Size(958, 65);
            this.flowFilePanel.TabIndex = 45;
            // 
            // ChamDiemfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.flowFilePanel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlaceholder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.teacherComment);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChamDiemfrm";
            this.Text = "Chấm điểm bài tập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlaceholder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label lblSubmitTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStudent;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox teacherComment;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtContent;
        private System.Windows.Forms.FlowLayoutPanel flowFilePanel;
    }
}
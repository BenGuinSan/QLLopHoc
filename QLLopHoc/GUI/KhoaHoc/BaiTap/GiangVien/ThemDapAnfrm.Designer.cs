namespace QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien
{
    partial class ThemDapAnfrm
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
            this.ckbPublicAnswer = new System.Windows.Forms.CheckBox();
            this.txtContent = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblCharCountContent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.saveAnswer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPlaceholderContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckbPublicAnswer
            // 
            this.ckbPublicAnswer.AutoSize = true;
            this.ckbPublicAnswer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbPublicAnswer.ForeColor = System.Drawing.Color.Black;
            this.ckbPublicAnswer.Location = new System.Drawing.Point(15, 14);
            this.ckbPublicAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbPublicAnswer.Name = "ckbPublicAnswer";
            this.ckbPublicAnswer.Size = new System.Drawing.Size(316, 27);
            this.ckbPublicAnswer.TabIndex = 16;
            this.ckbPublicAnswer.Text = "Công khai đáp án sau khi kết thúc";
            this.ckbPublicAnswer.UseVisualStyleBackColor = true;
            this.ckbPublicAnswer.CheckedChanged += new System.EventHandler(this.ckbPublicAnswer_CheckedChanged);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(15, 47);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContent.MaxLength = 4000;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(1033, 524);
            this.txtContent.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtContent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContent.StateCommon.Border.Rounding = 5;
            this.txtContent.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 10, -1, -1);
            this.txtContent.TabIndex = 19;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // lblCharCountContent
            // 
            this.lblCharCountContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCountContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCountContent.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCountContent.Location = new System.Drawing.Point(944, 22);
            this.lblCharCountContent.Name = "lblCharCountContent";
            this.lblCharCountContent.Size = new System.Drawing.Size(104, 20);
            this.lblCharCountContent.TabIndex = 20;
            this.lblCharCountContent.Text = "0/4000";
            this.lblCharCountContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thêm file đáp án:";
            // 
            // flowFilePanel
            // 
            this.flowFilePanel.AutoScroll = true;
            this.flowFilePanel.BackColor = System.Drawing.Color.White;
            this.flowFilePanel.Location = new System.Drawing.Point(15, 634);
            this.flowFilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowFilePanel.Name = "flowFilePanel";
            this.flowFilePanel.Size = new System.Drawing.Size(1033, 162);
            this.flowFilePanel.TabIndex = 22;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(196, 583);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(51, 46);
            this.btnUpload.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUpload.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUpload.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnUpload.TabIndex = 23;
            this.btnUpload.Values.Image = global::QLLopHoc.Properties.Resources.upload;
            this.btnUpload.Values.Text = "";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // saveAnswer
            // 
            this.saveAnswer.Location = new System.Drawing.Point(907, 583);
            this.saveAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveAnswer.Name = "saveAnswer";
            this.saveAnswer.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.saveAnswer.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.saveAnswer.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveAnswer.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveAnswer.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.Size = new System.Drawing.Size(141, 38);
            this.saveAnswer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.saveAnswer.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.saveAnswer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveAnswer.StateCommon.Border.Rounding = 5;
            this.saveAnswer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.saveAnswer.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAnswer.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.saveAnswer.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.saveAnswer.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.saveAnswer.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.saveAnswer.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.saveAnswer.TabIndex = 24;
            this.saveAnswer.Values.Text = "Lưu đáp án";
            this.saveAnswer.Click += new System.EventHandler(this.saveAnswer_Click);
            // 
            // lblPlaceholderContent
            // 
            this.lblPlaceholderContent.AutoSize = true;
            this.lblPlaceholderContent.BackColor = System.Drawing.Color.White;
            this.lblPlaceholderContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholderContent.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceholderContent.Location = new System.Drawing.Point(33, 63);
            this.lblPlaceholderContent.Name = "lblPlaceholderContent";
            this.lblPlaceholderContent.Size = new System.Drawing.Size(254, 25);
            this.lblPlaceholderContent.TabIndex = 25;
            this.lblPlaceholderContent.Text = "Viết câu trả lời cho bài tập....";
            // 
            // ThemDapAnfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 810);
            this.Controls.Add(this.lblPlaceholderContent);
            this.Controls.Add(this.saveAnswer);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.flowFilePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCharCountContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.ckbPublicAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1078, 847);
            this.Name = "ThemDapAnfrm";
            this.Text = "Thêm Đáp Án";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbPublicAnswer;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtContent;
        private System.Windows.Forms.Label lblCharCountContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowFilePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpload;
        private ComponentFactory.Krypton.Toolkit.KryptonButton saveAnswer;
        private System.Windows.Forms.Label lblPlaceholderContent;
    }
}
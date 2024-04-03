namespace QLLopHoc.GUI.Chatbox
{
    partial class Chatboxfrm
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
            this.components = new System.ComponentModel.Container();
            this.timerLoadMess = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.count_letter_lbl = new System.Windows.Forms.Label();
            this.sendMessBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSendMessContainer = new System.Windows.Forms.Panel();
            this.areaChatRTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.MessageBoxContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlSendMessContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLoadMess
            // 
            this.timerLoadMess.Interval = 1500;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.count_letter_lbl);
            this.panel1.Controls.Add(this.sendMessBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(452, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 86);
            this.panel1.TabIndex = 2;
            // 
            // count_letter_lbl
            // 
            this.count_letter_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.count_letter_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.count_letter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.count_letter_lbl.Location = new System.Drawing.Point(0, 0);
            this.count_letter_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.count_letter_lbl.Name = "count_letter_lbl";
            this.count_letter_lbl.Size = new System.Drawing.Size(68, 22);
            this.count_letter_lbl.TabIndex = 5;
            this.count_letter_lbl.Text = "0/300";
            this.count_letter_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sendMessBtn
            // 
            this.sendMessBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sendMessBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendMessBtn.Location = new System.Drawing.Point(0, 52);
            this.sendMessBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendMessBtn.Name = "sendMessBtn";
            this.sendMessBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.OverrideDefault.Back.Image = global::QLLopHoc.Properties.Resources.send;
            this.sendMessBtn.OverrideDefault.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.sendMessBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sendMessBtn.Size = new System.Drawing.Size(68, 34);
            this.sendMessBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.sendMessBtn.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.sendMessBtn.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.sendMessBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sendMessBtn.StateCommon.Border.Rounding = 5;
            this.sendMessBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.sendMessBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sendMessBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(88)))), ((int)(((byte)(212)))));
            this.sendMessBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(88)))), ((int)(((byte)(212)))));
            this.sendMessBtn.TabIndex = 2;
            this.sendMessBtn.Values.Image = global::QLLopHoc.Properties.Resources.send;
            this.sendMessBtn.Values.Text = "";
            // 
            // pnlSendMessContainer
            // 
            this.pnlSendMessContainer.Controls.Add(this.panel1);
            this.pnlSendMessContainer.Controls.Add(this.areaChatRTB);
            this.pnlSendMessContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSendMessContainer.Location = new System.Drawing.Point(8, 477);
            this.pnlSendMessContainer.Name = "pnlSendMessContainer";
            this.pnlSendMessContainer.Size = new System.Drawing.Size(520, 86);
            this.pnlSendMessContainer.TabIndex = 20;
            // 
            // areaChatRTB
            // 
            this.areaChatRTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.areaChatRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaChatRTB.Location = new System.Drawing.Point(0, 0);
            this.areaChatRTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.areaChatRTB.Name = "areaChatRTB";
            this.areaChatRTB.Size = new System.Drawing.Size(520, 86);
            this.areaChatRTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.areaChatRTB.StateCommon.Border.Rounding = 5;
            this.areaChatRTB.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.areaChatRTB.StateCommon.Content.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.areaChatRTB.TabIndex = 1;
            this.areaChatRTB.Text = "";
            // 
            // MessageBoxContainer
            // 
            this.MessageBoxContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBoxContainer.AutoScroll = true;
            this.MessageBoxContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MessageBoxContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MessageBoxContainer.Location = new System.Drawing.Point(8, 15);
            this.MessageBoxContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageBoxContainer.Name = "MessageBoxContainer";
            this.MessageBoxContainer.Padding = new System.Windows.Forms.Padding(15, 0, 8, 0);
            this.MessageBoxContainer.Size = new System.Drawing.Size(520, 438);
            this.MessageBoxContainer.TabIndex = 19;
            this.MessageBoxContainer.WrapContents = false;
            // 
            // Chatboxfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 571);
            this.Controls.Add(this.pnlSendMessContainer);
            this.Controls.Add(this.MessageBoxContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chatboxfrm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Chatboxfrm";
            this.Load += new System.EventHandler(this.Chatboxfrm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlSendMessContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerLoadMess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label count_letter_lbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sendMessBtn;
        private System.Windows.Forms.Panel pnlSendMessContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox areaChatRTB;
        private System.Windows.Forms.FlowLayoutPanel MessageBoxContainer;
    }
}
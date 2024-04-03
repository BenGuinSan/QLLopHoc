namespace QLLopHoc.GUI.Chatbox
{
    partial class OutgoingMess
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
            this.lbl_sent_content = new System.Windows.Forms.Label();
            this.lbl_sent_time = new System.Windows.Forms.Label();
            this.panel_contain_out_mess = new System.Windows.Forms.FlowLayoutPanel();
            this.menu_TinNhan = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.SuspendLayout();
            // 
            // lbl_sent_content
            // 
            this.lbl_sent_content.AutoSize = true;
            this.lbl_sent_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.lbl_sent_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_content.ForeColor = System.Drawing.Color.White;
            this.lbl_sent_content.Location = new System.Drawing.Point(802, 34);
            this.lbl_sent_content.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_sent_content.MaximumSize = new System.Drawing.Size(430, 0);
            this.lbl_sent_content.Name = "lbl_sent_content";
            this.lbl_sent_content.Padding = new System.Windows.Forms.Padding(7);
            this.lbl_sent_content.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sent_content.Size = new System.Drawing.Size(62, 36);
            this.lbl_sent_content.TabIndex = 5;
            this.lbl_sent_content.Text = "hello";
            // 
            // lbl_sent_time
            // 
            this.lbl_sent_time.AutoSize = true;
            this.lbl_sent_time.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_sent_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_sent_time.Location = new System.Drawing.Point(814, 5);
            this.lbl_sent_time.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_sent_time.Name = "lbl_sent_time";
            this.lbl_sent_time.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lbl_sent_time.Size = new System.Drawing.Size(50, 24);
            this.lbl_sent_time.TabIndex = 6;
            this.lbl_sent_time.Text = "12:40";
            this.lbl_sent_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_contain_out_mess
            // 
            this.panel_contain_out_mess.AutoSize = true;
            this.panel_contain_out_mess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_contain_out_mess.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_contain_out_mess.Location = new System.Drawing.Point(3, 3);
            this.panel_contain_out_mess.Name = "panel_contain_out_mess";
            this.panel_contain_out_mess.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel_contain_out_mess.Size = new System.Drawing.Size(872, 74);
            this.panel_contain_out_mess.TabIndex = 7;
            // 
            // menu_TinNhan
            // 
            this.menu_TinNhan.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Copy";
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Delete";
            // 
            // OutgoingMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbl_sent_time);
            this.Controls.Add(this.lbl_sent_content);
            this.Controls.Add(this.panel_contain_out_mess);
            this.Name = "OutgoingMess";
            this.Size = new System.Drawing.Size(878, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sent_content;
        private System.Windows.Forms.Label lbl_sent_time;
        private System.Windows.Forms.FlowLayoutPanel panel_contain_out_mess;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu menu_TinNhan;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
    }
}

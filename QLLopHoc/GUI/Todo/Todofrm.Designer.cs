namespace QLLopHoc.GUI.Todo
{
    partial class Todofrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rightFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.leftFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.rightFlowPanel);
            this.panel1.Controls.Add(this.leftFlowPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 57, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1122, 793);
            this.panel1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(258, 12);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonButton1.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.Size = new System.Drawing.Size(54, 39);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonButton1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonButton1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonButton1.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton1.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 5;
            this.kryptonButton1.Values.Image = global::QLLopHoc.Properties.Resources.refresh;
            this.kryptonButton1.Values.Text = "";
            // 
            // rightFlowPanel
            // 
            this.rightFlowPanel.BackColor = System.Drawing.Color.White;
            this.rightFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightFlowPanel.Location = new System.Drawing.Point(312, 57);
            this.rightFlowPanel.Name = "rightFlowPanel";
            this.rightFlowPanel.Size = new System.Drawing.Size(810, 736);
            this.rightFlowPanel.TabIndex = 4;
            // 
            // leftFlowPanel
            // 
            this.leftFlowPanel.BackColor = System.Drawing.Color.LightGray;
            this.leftFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftFlowPanel.Location = new System.Drawing.Point(12, 57);
            this.leftFlowPanel.Name = "leftFlowPanel";
            this.leftFlowPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.leftFlowPanel.Size = new System.Drawing.Size(300, 736);
            this.leftFlowPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Todofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 793);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Todofrm";
            this.Text = "Todo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel rightFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel leftFlowPanel;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
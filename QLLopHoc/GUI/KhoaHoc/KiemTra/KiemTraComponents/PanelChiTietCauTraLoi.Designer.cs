﻿using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    partial class PanelChiTietCauTraLoi
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
            this.rtbCauTraLoi = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.chkLaDapAn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtbCauTraLoi
            // 
            this.rtbCauTraLoi.Location = new System.Drawing.Point(3, 4);
            this.rtbCauTraLoi.MaxLength = 500;
            this.rtbCauTraLoi.Name = "rtbCauTraLoi";
            this.rtbCauTraLoi.Size = new System.Drawing.Size(450, 35);
            this.rtbCauTraLoi.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.rtbCauTraLoi.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.rtbCauTraLoi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rtbCauTraLoi.StateCommon.Border.Rounding = 5;
            this.rtbCauTraLoi.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbCauTraLoi.TabIndex = 11;
            this.rtbCauTraLoi.Text = "";
            // 
            // chkLaDapAn
            // 
            this.chkLaDapAn.AutoSize = true;
            this.chkLaDapAn.Location = new System.Drawing.Point(480, 13);
            this.chkLaDapAn.Name = "chkLaDapAn";
            this.chkLaDapAn.Size = new System.Drawing.Size(18, 17);
            this.chkLaDapAn.TabIndex = 28;
            this.chkLaDapAn.UseVisualStyleBackColor = true;
            // 
            // PanelChiTietCauTraLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkLaDapAn);
            this.Controls.Add(this.rtbCauTraLoi);
            this.Name = "PanelChiTietCauTraLoi";
            this.Size = new System.Drawing.Size(502, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbCauTraLoi;
        private System.Windows.Forms.CheckBox chkLaDapAn;


        public KryptonRichTextBox RtbCauTraLoi { get => rtbCauTraLoi; set => rtbCauTraLoi = value; }
        public CheckBox ChkLaDapAn { get => chkLaDapAn; set => chkLaDapAn = value; }
    }
}

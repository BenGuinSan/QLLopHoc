using System.Reflection.Emit;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    partial class HocSinhCard
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
            this.btnShow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.lblSubmitAt = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnShow.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnShow.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnShow.Size = new System.Drawing.Size(645, 57);
            this.btnShow.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnShow.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnShow.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnShow.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnShow.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnShow.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.btnShow.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnShow.TabIndex = 1;
            this.btnShow.Values.Text = "";
            // 
            // avatar
            // 
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Location = new System.Drawing.Point(37, 2);
            this.avatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(55, 54);
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            // 
            // lblSubmitAt
            // 
            this.lblSubmitAt.BackColor = System.Drawing.Color.White;
            this.lblSubmitAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitAt.Location = new System.Drawing.Point(130, 28);
            this.lblSubmitAt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubmitAt.Name = "lblSubmitAt";
            this.lblSubmitAt.Size = new System.Drawing.Size(322, 16);
            this.lblSubmitAt.TabIndex = 11;
            // 
            // Name
            // 
            this.Name.AutoEllipsis = true;
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.White;
            this.Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(130, 1);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(179, 21);
            this.Name.TabIndex = 0;
            this.Name.Text = "HocSinhKiemTraPanel";
            // 
            // HocSinhCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Name);
            this.Controls.Add(this.lblSubmitAt);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.Name = "HocSinhCard";
            this.Size = new System.Drawing.Size(645, 57);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnShow;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lblSubmitAt;
        private System.Windows.Forms.Label Name;
 
    }
}

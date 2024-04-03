namespace QLLopHoc.GUI.KhoaHoc
{
    partial class TaoTaiLieufrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_tentailieu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lab_demkitu_tentailieu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_noidungtailieu = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lab_demkitu_noidungtailieu = new System.Windows.Forms.Label();
            this.but_layfile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel_luufile = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tengiangvien = new System.Windows.Forms.Label();
            this.txt_tenchuong = new System.Windows.Forms.Label();
            this.txt_tenlop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_taotailieu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Vui lòng điền tiêu đề của tài liệu (Không quá 50 kí tự):\r\n";
            // 
            // text_tentailieu
            // 
            this.text_tentailieu.Location = new System.Drawing.Point(26, 35);
            this.text_tentailieu.MaxLength = 50;
            this.text_tentailieu.Name = "text_tentailieu";
            this.text_tentailieu.Size = new System.Drawing.Size(700, 34);
            this.text_tentailieu.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.text_tentailieu.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.text_tentailieu.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.text_tentailieu.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.text_tentailieu.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.text_tentailieu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.text_tentailieu.StateCommon.Border.Rounding = 5;
            this.text_tentailieu.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.text_tentailieu.TabIndex = 50;
            // 
            // lab_demkitu_tentailieu
            // 
            this.lab_demkitu_tentailieu.AutoSize = true;
            this.lab_demkitu_tentailieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_demkitu_tentailieu.Location = new System.Drawing.Point(639, 9);
            this.lab_demkitu_tentailieu.Name = "lab_demkitu_tentailieu";
            this.lab_demkitu_tentailieu.Size = new System.Drawing.Size(87, 20);
            this.lab_demkitu_tentailieu.TabIndex = 51;
            this.lab_demkitu_tentailieu.Text = "0/50 kí tự";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Vui lòng nhập nội dung tài liệu(Không quá 300 kí tự):\r\n";
            // 
            // text_noidungtailieu
            // 
            this.text_noidungtailieu.Location = new System.Drawing.Point(25, 109);
            this.text_noidungtailieu.MaxLength = 300;
            this.text_noidungtailieu.Name = "text_noidungtailieu";
            this.text_noidungtailieu.Size = new System.Drawing.Size(700, 250);
            this.text_noidungtailieu.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.text_noidungtailieu.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.text_noidungtailieu.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.text_noidungtailieu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.text_noidungtailieu.StateCommon.Border.Rounding = 5;
            this.text_noidungtailieu.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.text_noidungtailieu.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.text_noidungtailieu.TabIndex = 53;
            this.text_noidungtailieu.Text = "";
            // 
            // lab_demkitu_noidungtailieu
            // 
            this.lab_demkitu_noidungtailieu.AutoSize = true;
            this.lab_demkitu_noidungtailieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_demkitu_noidungtailieu.Location = new System.Drawing.Point(629, 86);
            this.lab_demkitu_noidungtailieu.Name = "lab_demkitu_noidungtailieu";
            this.lab_demkitu_noidungtailieu.Size = new System.Drawing.Size(97, 20);
            this.lab_demkitu_noidungtailieu.TabIndex = 54;
            this.lab_demkitu_noidungtailieu.Text = "0/300 kí tự";
            // 
            // but_layfile
            // 
            this.but_layfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_layfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_layfile.Location = new System.Drawing.Point(26, 362);
            this.but_layfile.Margin = new System.Windows.Forms.Padding(0);
            this.but_layfile.Name = "but_layfile";
            this.but_layfile.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_layfile.OverrideDefault.Border.Rounding = 5;
            this.but_layfile.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_layfile.Size = new System.Drawing.Size(135, 40);
            this.but_layfile.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_layfile.StateCommon.Border.Rounding = 5;
            this.but_layfile.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.but_layfile.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_layfile.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_layfile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_layfile.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.but_layfile.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.but_layfile.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.but_layfile.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_layfile.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_layfile.TabIndex = 55;
            this.but_layfile.Values.Text = "Đính kèm file";
            // 
            // panel_luufile
            // 
            this.panel_luufile.AutoScroll = true;
            this.panel_luufile.BackColor = System.Drawing.Color.LightGray;
            this.panel_luufile.Location = new System.Drawing.Point(25, 405);
            this.panel_luufile.Name = "panel_luufile";
            this.panel_luufile.Padding = new System.Windows.Forms.Padding(5);
            this.panel_luufile.Size = new System.Drawing.Size(700, 227);
            this.panel_luufile.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(737, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Thông tin tài liệu:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_tengiangvien);
            this.panel1.Controls.Add(this.txt_tenchuong);
            this.panel1.Controls.Add(this.txt_tenlop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(742, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 234);
            this.panel1.TabIndex = 58;
            // 
            // txt_tengiangvien
            // 
            this.txt_tengiangvien.AutoSize = true;
            this.txt_tengiangvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tengiangvien.Location = new System.Drawing.Point(12, 192);
            this.txt_tengiangvien.Name = "txt_tengiangvien";
            this.txt_tengiangvien.Size = new System.Drawing.Size(123, 25);
            this.txt_tengiangvien.TabIndex = 9;
            this.txt_tengiangvien.Text = "tengiangvien";
            // 
            // txt_tenchuong
            // 
            this.txt_tenchuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenchuong.Location = new System.Drawing.Point(13, 95);
            this.txt_tenchuong.MaximumSize = new System.Drawing.Size(219, 75);
            this.txt_tenchuong.Name = "txt_tenchuong";
            this.txt_tenchuong.Size = new System.Drawing.Size(210, 75);
            this.txt_tenchuong.TabIndex = 8;
            this.txt_tenchuong.Text = "tenchuong";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.AutoSize = true;
            this.txt_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenlop.Location = new System.Drawing.Point(13, 39);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(65, 25);
            this.txt_tenlop.TabIndex = 7;
            this.txt_tenlop.Text = "tenlop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giảng viên:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chương:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp học:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_taotailieu
            // 
            this.but_taotailieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_taotailieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_taotailieu.Location = new System.Drawing.Point(742, 592);
            this.but_taotailieu.Margin = new System.Windows.Forms.Padding(0);
            this.but_taotailieu.Name = "but_taotailieu";
            this.but_taotailieu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_taotailieu.OverrideDefault.Border.Rounding = 5;
            this.but_taotailieu.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_taotailieu.Size = new System.Drawing.Size(228, 40);
            this.but_taotailieu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.but_taotailieu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(141)))));
            this.but_taotailieu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_taotailieu.StateCommon.Border.Rounding = 5;
            this.but_taotailieu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.but_taotailieu.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.but_taotailieu.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.but_taotailieu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_taotailieu.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.but_taotailieu.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.but_taotailieu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.but_taotailieu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.but_taotailieu.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.but_taotailieu.TabIndex = 59;
            this.but_taotailieu.Values.Text = "Đăng";
            // 
            // TaoTaiLieufrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.but_taotailieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_luufile);
            this.Controls.Add(this.but_layfile);
            this.Controls.Add(this.lab_demkitu_noidungtailieu);
            this.Controls.Add(this.text_noidungtailieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_demkitu_tentailieu);
            this.Controls.Add(this.text_tentailieu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaoTaiLieufrm";
            this.Text = "Tạo tài liệu ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox text_tentailieu;
        private System.Windows.Forms.Label lab_demkitu_tentailieu;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox text_noidungtailieu;
        private System.Windows.Forms.Label lab_demkitu_noidungtailieu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton but_layfile;
        private System.Windows.Forms.FlowLayoutPanel panel_luufile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_tengiangvien;
        private System.Windows.Forms.Label txt_tenchuong;
        private System.Windows.Forms.Label txt_tenlop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton but_taotailieu;
    }
}
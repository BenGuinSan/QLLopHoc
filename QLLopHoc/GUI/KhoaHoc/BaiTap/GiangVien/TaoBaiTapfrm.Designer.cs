﻿namespace QLLopHoc.GUI.KhoaHoc.BaiTap.GiangVien
{
    partial class TaoBaiTapfrm
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
            this.lblPlaceholderTitle = new System.Windows.Forms.Label();
            this.lblCharCountTitle = new System.Windows.Forms.Label();
            this.txtTitle = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblPlaceholderContent = new System.Windows.Forms.Label();
            this.lblCharCountContent = new System.Windows.Forms.Label();
            this.txtContent = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.addAnswer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.flowFilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createHomework = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChuong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpThoiGianBatDau = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpThoiGianKetThuc = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.cbkLateSubmit = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaceholderTitle
            // 
            this.lblPlaceholderTitle.AutoSize = true;
            this.lblPlaceholderTitle.BackColor = System.Drawing.Color.White;
            this.lblPlaceholderTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholderTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholderTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceholderTitle.Location = new System.Drawing.Point(51, 48);
            this.lblPlaceholderTitle.Name = "lblPlaceholderTitle";
            this.lblPlaceholderTitle.Size = new System.Drawing.Size(128, 22);
            this.lblPlaceholderTitle.TabIndex = 10;
            this.lblPlaceholderTitle.Tag = "ádasd";
            this.lblPlaceholderTitle.Text = "Tiêu đề bài tập";
            this.lblPlaceholderTitle.Click += new System.EventHandler(this.lblPlaceholderTitle_Click);
            // 
            // lblCharCountTitle
            // 
            this.lblCharCountTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCountTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCountTitle.Location = new System.Drawing.Point(588, 1);
            this.lblCharCountTitle.Name = "lblCharCountTitle";
            this.lblCharCountTitle.Size = new System.Drawing.Size(97, 30);
            this.lblCharCountTitle.TabIndex = 11;
            this.lblCharCountTitle.Text = "0/200";
            this.lblCharCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 34);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(673, 50);
            this.txtTitle.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTitle.StateCommon.Border.Rounding = 10;
            this.txtTitle.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 8, -1, -1);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.Text = "";
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblPlaceholderContent
            // 
            this.lblPlaceholderContent.AutoSize = true;
            this.lblPlaceholderContent.BackColor = System.Drawing.Color.White;
            this.lblPlaceholderContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaceholderContent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceholderContent.ForeColor = System.Drawing.Color.Gray;
            this.lblPlaceholderContent.Location = new System.Drawing.Point(51, 151);
            this.lblPlaceholderContent.Name = "lblPlaceholderContent";
            this.lblPlaceholderContent.Size = new System.Drawing.Size(156, 22);
            this.lblPlaceholderContent.TabIndex = 15;
            this.lblPlaceholderContent.Text = "Nội dung bài tập...";
            this.lblPlaceholderContent.Click += new System.EventHandler(this.lblPlaceholderContent_Click);
            // 
            // lblCharCountContent
            // 
            this.lblCharCountContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharCountContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCharCountContent.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCountContent.Location = new System.Drawing.Point(615, 114);
            this.lblCharCountContent.Name = "lblCharCountContent";
            this.lblCharCountContent.Size = new System.Drawing.Size(69, 18);
            this.lblCharCountContent.TabIndex = 14;
            this.lblCharCountContent.Text = "0/4000";
            this.lblCharCountContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 135);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContent.MaxLength = 4000;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(673, 322);
            this.txtContent.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtContent.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContent.StateCommon.Border.Rounding = 10;
            this.txtContent.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.StateCommon.Content.Padding = new System.Windows.Forms.Padding(20, 8, -1, -1);
            this.txtContent.TabIndex = 16;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // addAnswer
            // 
            this.addAnswer.Location = new System.Drawing.Point(537, 464);
            this.addAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(148, 30);
            this.addAnswer.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.addAnswer.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.addAnswer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.addAnswer.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.addAnswer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnswer.TabIndex = 20;
            this.addAnswer.Values.Text = "Thêm đáp án";
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(159, 464);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(33, 30);
            this.btnUpload.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnUpload.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnUpload.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnUpload.StateCommon.Content.ShortText.Image = global::QLLopHoc.Properties.Resources.upload;
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Values.Image = global::QLLopHoc.Properties.Resources.upload_16;
            this.btnUpload.Values.Text = "";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tải file bài tập:";
            // 
            // flowFilePanel
            // 
            this.flowFilePanel.AutoScroll = true;
            this.flowFilePanel.BackColor = System.Drawing.Color.White;
            this.flowFilePanel.Location = new System.Drawing.Point(12, 498);
            this.flowFilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowFilePanel.Name = "flowFilePanel";
            this.flowFilePanel.Size = new System.Drawing.Size(673, 142);
            this.flowFilePanel.TabIndex = 17;
            // 
            // createHomework
            // 
            this.createHomework.Location = new System.Drawing.Point(704, 603);
            this.createHomework.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createHomework.Name = "createHomework";
            this.createHomework.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.createHomework.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.createHomework.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createHomework.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.createHomework.OverrideDefault.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.Size = new System.Drawing.Size(267, 38);
            this.createHomework.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.createHomework.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.createHomework.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createHomework.StateCommon.Border.Rounding = 5;
            this.createHomework.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.createHomework.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createHomework.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.createHomework.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(28)))), ((int)(((byte)(212)))));
            this.createHomework.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.createHomework.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createHomework.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.createHomework.TabIndex = 22;
            this.createHomework.Values.Text = "Tạo bài tập";
            this.createHomework.Click += new System.EventHandler(this.createHomework_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.lblClass);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.lblChuong);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.lblTeacher);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.dtpThoiGianBatDau);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.dtpThoiGianKetThuc);
            this.flowLayoutPanel2.Controls.Add(this.cbkLateSubmit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(704, 34);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 562);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin tổng quan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp học:";
            // 
            // lblClass
            // 
            this.lblClass.AutoEllipsis = true;
            this.lblClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(3, 76);
            this.lblClass.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(263, 25);
            this.lblClass.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chương:";
            // 
            // lblChuong
            // 
            this.lblChuong.AutoEllipsis = true;
            this.lblChuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuong.Location = new System.Drawing.Point(3, 144);
            this.lblChuong.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblChuong.Name = "lblChuong";
            this.lblChuong.Size = new System.Drawing.Size(263, 25);
            this.lblChuong.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giáo viên:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoEllipsis = true;
            this.lblTeacher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.Location = new System.Drawing.Point(3, 212);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(263, 25);
            this.lblTeacher.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 247);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Bắt đầu lúc:";
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(3, 282);
            this.dtpThoiGianBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.dtpThoiGianBatDau.MinDate = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(263, 34);
            this.dtpThoiGianBatDau.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpThoiGianBatDau.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpThoiGianBatDau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpThoiGianBatDau.StateCommon.Border.Rounding = 5;
            this.dtpThoiGianBatDau.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGianBatDau.TabIndex = 12;
            this.dtpThoiGianBatDau.ValueChanged += new System.EventHandler(this.dtpThoiGianBatDau_ValueChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 326);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "Kết thúc vào:";
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(3, 361);
            this.dtpThoiGianKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 20);
            this.dtpThoiGianKetThuc.MinDate = this.dtpThoiGianBatDau.Value;
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(263, 34);
            this.dtpThoiGianKetThuc.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpThoiGianKetThuc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpThoiGianKetThuc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpThoiGianKetThuc.StateCommon.Border.Rounding = 5;
            this.dtpThoiGianKetThuc.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThoiGianKetThuc.TabIndex = 13;
            this.dtpThoiGianKetThuc.ValueNullable = new System.DateTime(2024, 11, 23, 10, 35, 0, 0);
            this.dtpThoiGianKetThuc.ValueChanged += new System.EventHandler(this.dtpThoiGianKetThuc_ValueChanged);
            // 
            // cbkLateSubmit
            // 
            this.cbkLateSubmit.AutoSize = true;
            this.cbkLateSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkLateSubmit.Location = new System.Drawing.Point(3, 417);
            this.cbkLateSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkLateSubmit.Name = "cbkLateSubmit";
            this.cbkLateSubmit.Size = new System.Drawing.Size(171, 27);
            this.cbkLateSubmit.TabIndex = 15;
            this.cbkLateSubmit.Text = "Cho phép nộp bù";
            this.cbkLateSubmit.UseVisualStyleBackColor = true;
            // 
            // TaoBaiTapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 654);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.createHomework);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowFilePanel);
            this.Controls.Add(this.lblPlaceholderContent);
            this.Controls.Add(this.lblCharCountContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblPlaceholderTitle);
            this.Controls.Add(this.lblCharCountTitle);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaoBaiTapfrm";
            this.Text = "Tạo bài tập";
            this.Load += new System.EventHandler(this.TaoBaiTapfrm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaceholderTitle;
        private System.Windows.Forms.Label lblCharCountTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtTitle;
        private System.Windows.Forms.Label lblPlaceholderContent;
        private System.Windows.Forms.Label lblCharCountContent;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtContent;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addAnswer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowFilePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton createHomework;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblChuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.Label label14;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.CheckBox cbkLateSubmit;
    }
}
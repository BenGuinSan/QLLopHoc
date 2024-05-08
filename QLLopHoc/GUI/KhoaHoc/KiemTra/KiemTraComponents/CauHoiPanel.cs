using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using QLLopHoc.DTO;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    public partial class CauHoiPanel : UserControl
    {
        private string macauhoi;
        private int vitridapandung;
        private int vitridapanchon = -1;
        private string madapanchon;
        private ArrayList listdapan;
        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Madapanchon { get => madapanchon; set => madapanchon = value; }
        public CauHoiPanel()
        {
            InitializeComponent();


        }
        public CauHoiPanel(CauHoiDTO cauhoi, ArrayList listdapan)
        {
            InitializeComponent();
            this.Macauhoi = cauhoi.Macauhoi;
            this.listdapan = listdapan;
            this.question.Text = cauhoi.Noidung;
            // cautraloi
            this.answer1.Text = (listdapan[0] as CauTraLoiDTO).Noidung;
            this.answer2.Text = (listdapan[1] as CauTraLoiDTO).Noidung;
            this.answer3.Text = (listdapan[2] as CauTraLoiDTO).Noidung;
            this.answer4.Text = (listdapan[3] as CauTraLoiDTO).Noidung;
        }
        public CauHoiPanel(CauHoiDTO cauhoi, ArrayList listdapan, string dapandachon, bool daKetThuc, bool congkhaidapan)
        {
            InitializeComponent();
            this.Macauhoi = cauhoi.Macauhoi;
            this.listdapan = listdapan;
            this.madapanchon = dapandachon;
            this.question.Text = cauhoi.Noidung;
            // cautraloi
            this.answer1.Text = (listdapan[0] as CauTraLoiDTO).Noidung;
            this.answer2.Text = (listdapan[1] as CauTraLoiDTO).Noidung;
            this.answer3.Text = (listdapan[2] as CauTraLoiDTO).Noidung;
            this.answer4.Text = (listdapan[3] as CauTraLoiDTO).Noidung;
            setViTriDapAnDungVaDapAnChon();
            switch (this.vitridapanchon)
            {
                case 0:
                    this.answer1.Checked = true;
                    break;
                case 1:
                    this.answer2.Checked = true;
                    break;
                case 2:
                    this.answer3.Checked = true;
                    break;
                case 3:
                    this.answer4.Checked = true;
                    break;
                default:
                    this.answer1.Checked = false;
                    this.answer2.Checked = false;
                    this.answer3.Checked = false;
                    this.answer4.Checked = false;
                    break;
            }
            if (daKetThuc)
            {
                if (congkhaidapan)
                {
                    switch (this.vitridapanchon)
                    {
                        case 0:
                            this.answer1.ForeColor = System.Drawing.Color.Red;
                            break;
                        case 1:
                            this.answer2.ForeColor = System.Drawing.Color.Red;
                            break;
                        case 2:
                            this.answer3.ForeColor = System.Drawing.Color.Red;
                            break;
                        case 3:
                            this.answer4.ForeColor = System.Drawing.Color.Red;
                            break;
                    }
                    switch (this.vitridapandung)
                    {
                        case 0:
                            this.answer1.ForeColor = System.Drawing.Color.Green;
                            break;
                        case 1:
                            this.answer2.ForeColor = System.Drawing.Color.Green;
                            break;
                        case 2:
                            this.answer3.ForeColor = System.Drawing.Color.Green;
                            break;
                        case 3:
                            this.answer4.ForeColor = System.Drawing.Color.Green;
                            break;
                    }
                }
                this.answer1.CheckedChanged += holdAnswer;
                this.answer2.CheckedChanged += holdAnswer;
                this.answer3.CheckedChanged += holdAnswer;
                this.answer4.CheckedChanged += holdAnswer;
                if (this.madapanchon == string.Empty)
                    this.empty.Visible = true;
            }
        }
        private void setViTriDapAnDungVaDapAnChon()
        {
            int index = 0;
            foreach (CauTraLoiDTO ctl in listdapan)
            {
                if (ctl.Macautraloi.Equals(this.madapanchon))
                {
                    this.vitridapanchon = index;
                }
                if (ctl.Ladapan == 1)
                {
                    this.vitridapandung = index;
                }
                index++;
            }
        }
        private void holdAnswer(object sender, EventArgs e)
        {
            switch (this.vitridapanchon)
            {
                case 0:
                    this.answer1.Checked = true;
                    break;
                case 1:
                    this.answer2.Checked = true;
                    break;
                case 2:
                    this.answer3.Checked = true;
                    break;
                case 3:
                    this.answer4.Checked = true;
                    break;
            }
        }
        public Label getOrder()
        {
            return this.order;
        }
        public KryptonRichTextBox getQuestionTextBox()
        {
            return this.question;
        }
        public RadioButton getAnswer1Radbtn()
        {
            return this.answer1;
        }
        public RadioButton getAnswer2Radbtn()
        {
            return this.answer2;
        }
        public RadioButton getAnswer3Radbtn()
        {
            return this.answer3;
        }
        public RadioButton getAnswer4Radbtn()
        {
            return this.answer4;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "answer1":
                    this.madapanchon = (this.listdapan[0] as CauTraLoiDTO).Macautraloi;
                    break;
                case "answer2":
                    this.madapanchon = (this.listdapan[1] as CauTraLoiDTO).Macautraloi;
                    break;
                case "answer3":
                    this.madapanchon = (this.listdapan[2] as CauTraLoiDTO).Macautraloi;
                    break;
                case "answer4":
                    this.madapanchon = (this.listdapan[3] as CauTraLoiDTO).Macautraloi;
                    break;
            }
        }
    }
}

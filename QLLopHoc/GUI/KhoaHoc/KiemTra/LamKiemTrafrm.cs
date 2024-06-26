﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using QLLopHoc.BUS;
using QLLopHoc.DAO;
using QLLopHoc.DTO;
using QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra
{
    public partial class LamKiemTrafrm : Form
    {
        private const double TOTAL_POINT = 10.0;
        private DeKiemTraDTO dkt;
        private CauHoiBUS chBUS;
        private CauTraLoiBUS ctlBUS;
        private TaiKhoanDTO taikhoanhienhanh;
        private ChiTietDeKiemTraBUS ctdktBUS;
        private BaiLamKiemTraBUS blktBUS;
        public LamKiemTrafrm()
        {
            InitializeComponent();
        }

        public LamKiemTrafrm(DeKiemTraDTO dkt, TaiKhoanDTO taikhoanhienhanh, BaiLamKiemTraBUS blktBUS)
        {
            InitializeComponent();
            this.dkt = dkt;
            this.blktBUS = blktBUS;
            this.chBUS = new CauHoiBUS();
            this.ctlBUS = new CauTraLoiBUS();
            this.ctdktBUS = new ChiTietDeKiemTraBUS();
            this.taikhoanhienhanh = taikhoanhienhanh;
            loadDataIntoForm();
        }

        private void LamKiemTrafrm_Load(object sender, EventArgs e)
        {

        }
        private void ShuffleArrayList(ArrayList list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                ChiTietDeKiemTraDTO value = (ChiTietDeKiemTraDTO)list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private void loadDataIntoForm()
        {
            ArrayList listmacauhoi = this.ctdktBUS.GetDanhSachChiTietDeKiemTraWithMaDeKiemTra(this.dkt.Madekiemtra.ToLower());
            if (this.dkt.Troncauhoi == 1)
                ShuffleArrayList(listmacauhoi);
            ArrayList listcautraloi;
            if (listmacauhoi.Count <= 0)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải đề kiểm tra!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            listcauhoipanel.Controls.Clear();
            int index = 0;
            foreach (ChiTietDeKiemTraDTO ctdkt in listmacauhoi)
            {
                //cauhoi
                CauHoiDTO tmp = this.chBUS.getCauhoiWithMaCauHoi(ctdkt.Macauhoi);
                listcautraloi = this.ctlBUS.getCauTraLoiWithMaCauHoi(tmp.Macauhoi);
                CauHoiPanel chComponent = new CauHoiPanel(tmp, listcautraloi, userChose(tmp.Macauhoi), false, false);
                chComponent.getOrder().Text = "Câu hỏi " + (++index);
                listcauhoipanel.Controls.Add(chComponent);

                // button navigate
                CauHoiNavigate btnNav = new CauHoiNavigate();
                btnNav.getButtonNav().Text = index.ToString();
                btnNav.getButtonNav().Click += new System.EventHandler(this.btnNavigate_Cliked);
                navigatePanel.Controls.Add(btnNav);
            }
            this.lblNumberQuestion.Text = listmacauhoi.Count.ToString();
            this.lblTitleExam.Text = dkt.Tieude;
            this.timeStart.Text = dkt.Thoigianbatdau.ToString("dd/MM/yyyy HH:mm:ss");
            this.timeEnd.Text = dkt.Thoigianketthuc.ToString("dd/MM/yyyy HH:mm:ss");
            this.lblName.Text = taikhoanhienhanh.Hoten;
        }

        private string userChose(string macauhoi)
        {
            string cautraloidachon = string.Empty;
            string sql_str1 = "SELECT madapanchon FROM luuvetbailamkiemtra WHERE email=@email AND madekiemtra=@made AND macauhoi=@macauhoi";
            SqlCommand command = new SqlCommand(sql_str1, DatabaseConnect.GetConnection());
            command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50)).Value = this.taikhoanhienhanh.Email;
            command.Parameters.Add(new SqlParameter("@made", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(this.dkt.Madekiemtra);
            command.Parameters.Add(new SqlParameter("@macauhoi", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(macauhoi);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cautraloidachon = dr["madapanchon"].ToString();
            }
            dr.Close();
            DatabaseConnect.CloseConnection();
            return cautraloidachon;
        }
        private void cleanUpLuuVet()
        {
            string sql_str1 = "DELETE FROM luuvetbailamkiemtra WHERE email=@email AND madekiemtra=@made";
            SqlCommand command = new SqlCommand(sql_str1, DatabaseConnect.GetConnection());
            command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50)).Value = this.taikhoanhienhanh.Email;
            command.Parameters.Add(new SqlParameter("@made", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(this.dkt.Madekiemtra);
            command.ExecuteNonQuery();
            DatabaseConnect.CloseConnection();
        }

        private void insertLuuVet()
        {
            string sql_str2 = "INSERT INTO luuvetbailamkiemtra(email,madekiemtra,macauhoi,madapanchon) VALUES (@email,@made,@macauhoi, @chon)";
            SqlCommand command2 = new SqlCommand(sql_str2, DatabaseConnect.GetConnection());

            foreach (CauHoiPanel cauhoipanel in this.listcauhoipanel.Controls)
            {
                if (cauhoipanel.Madapanchon == null || cauhoipanel.Madapanchon == string.Empty) continue;
                command2.Parameters.Clear();
                command2.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50)).Value = this.taikhoanhienhanh.Email;
                command2.Parameters.Add(new SqlParameter("@made", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(this.dkt.Madekiemtra);
                command2.Parameters.Add(new SqlParameter("@macauhoi", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(cauhoipanel.Macauhoi);
                command2.Parameters.Add(new SqlParameter("@chon", SqlDbType.UniqueIdentifier)).Value = Guid.Parse(cauhoipanel.Madapanchon);
                command2.ExecuteNonQuery();
            }
            DatabaseConnect.CloseConnection();
        }
        public void btnNavigate_Cliked(object sender, EventArgs e)
        {
            int targetChildIndex;
            int.TryParse((sender as KryptonButton).Text, out targetChildIndex);

            if (targetChildIndex >= 0 && targetChildIndex < navigatePanel.Controls.Count)
            {
                Control targetControl = listcauhoipanel.Controls[targetChildIndex - 1];
                // Calculate the scroll position
                int scrollX = targetControl.Left - listcauhoipanel.AutoScrollPosition.X;
                int scrollY = targetControl.Top - listcauhoipanel.AutoScrollPosition.Y;

                // Set the AutoScrollPosition to scroll to the desired position
                listcauhoipanel.AutoScrollPosition = new Point(scrollX, scrollY);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int index = 1;
            StringBuilder str = new StringBuilder();
            str.Append("Câu hỏi số ");
            foreach (CauHoiPanel cauhoipanel in this.listcauhoipanel.Controls)
            {
                if (cauhoipanel.Madapanchon == string.Empty)
                    str.Append(index.ToString() + ", ");
                index++;
            }
            str.Append("chưa chọn câu trả lời. Bạn vẫn muốn nộp bài chứ ?");

            DialogResult isEmptyConfirm = MessageBox.Show(str.ToString(), "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isEmptyConfirm == DialogResult.No) return;

            DialogResult isConfirm = MessageBox.Show("Xác nhận nộp bài kiểm tra ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (isConfirm == DialogResult.No) return;
            this.btnSubmit.Enabled = false;

            // create bailamkt
            DateTime thoigiannop = DateTime.Now;
            string mabailam = Guid.NewGuid().ToString();
            double pointsPerQuestion = TOTAL_POINT / this.listcauhoipanel.Controls.Count;
            double point = 0;
            int socaudung = 0;
            int order = 1;
            ArrayList Bailam = new ArrayList(); // use for chitietbailam
            ChiTietBaiLamKiemTraDTO ctbl;
            foreach (CauHoiPanel cauhoipanel in this.listcauhoipanel.Controls)
            {
                ctbl = new ChiTietBaiLamKiemTraDTO()
                {
                    Mabailamkiemtra = mabailam,
                    Macauhoi = cauhoipanel.Macauhoi,
                    Dapanchon = cauhoipanel.Madapanchon,
                    Thutu = order++
                };
                Bailam.Add(ctbl);
                if (cauhoipanel.Madapanchon != string.Empty && ctlBUS.getCauTraLoiWithMaCauTraLoi(cauhoipanel.Madapanchon).Ladapan == 1)
                {
                    point += pointsPerQuestion;
                    socaudung++;
                }
            }

            BaiLamKiemTra blkt = new BaiLamKiemTra()
            {
                Mabailam = mabailam,
                Madekiemtra = dkt.Madekiemtra,
                Mataikhoan = taikhoanhienhanh.Mataikhoan,
                Diem = float.Parse(Math.Round(point, 2).ToString()),
                Thoigiannop = thoigiannop,
                Socaudung = socaudung,
                Noptre = (thoigiannop > dkt.Thoigianketthuc) ? 1 : 0
            };
            // hinh phat nop tre
            if (blkt.Noptre == 1)
                blkt.Diem = float.Parse(Math.Round((blkt.Diem * this.dkt.Hinhphat) / 100, 2).ToString());
            if (!this.blktBUS.addBaiLam(blkt))
            {
               
                MessageBox.Show("Xảy ra lỗi khi lưu bài làm, vui lòng thử lại !", "Thông báo!", MessageBoxButtons.OK);
                this.btnSubmit.Enabled = true;
                return;
            }

            ChiTietBaiLamKiemTraBUS ctblkt = new ChiTietBaiLamKiemTraBUS();
            ctblkt.AddChiTietBaiLam(Bailam);
           
            MessageBox.Show("Lưu bài làm thành công !", "Thông báo !", MessageBoxButtons.OK);
            this.blktBUS.loadList();
            // clean up
            cleanUpLuuVet();
            this.btnSubmit.Enabled = true;
            this.Close();
        }

    }
}

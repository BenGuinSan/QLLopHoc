using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.BUS;
using QLLopHoc.DTO;

namespace QLLopHoc.GUI.Todo
{
    public partial class Todofrm : Form
    {
        private bool flagBtnClicked;
        private TaiKhoanDTO taikhoanhienhanh;
        private BaiTapBUS btBUS;
        private BaiLamBaiTapBUS blbtBUS;
        private BaiLamKiemTraBUS blktBUS;
        private DeKiemTraBUS ktBUS;
        private ChuongBUS chuongBUS;
        private LopHocBUS lopHocBUS;
        private TaskNotDoneButton btnNot;
        private TaskDoneButton btnDone;
        private ArrayList listClass;
        private ArrayList baitapDxl;
        private ArrayList baitapCxl;
        private ArrayList kiemtraDxl;
        private ArrayList kiemtraCxl;

        public Todofrm(TaiKhoanDTO taikhoanhienhanh, BaiTapBUS btBUS, LopHocBUS lopHocBUS, DeKiemTraBUS dktBUS, ChuongBUS chuongBUS, BaiLamBaiTapBUS blbtBUS, BaiLamKiemTraBUS blktBUS)
        {
            InitializeComponent();
            this.flagBtnClicked = false;
            this.taikhoanhienhanh = taikhoanhienhanh;
            this.btBUS = btBUS;
            this.ktBUS = dktBUS;
            this.lopHocBUS = lopHocBUS;
            this.chuongBUS = chuongBUS;
            this.blbtBUS = blbtBUS;
            this.blktBUS = blktBUS;
        }

        private void Todofrm_Load(object sender, EventArgs e)
        {
            btnNot = new TaskNotDoneButton();
            btnDone = new TaskDoneButton();
            baitapDxl = new ArrayList();
            baitapCxl = new ArrayList();
            kiemtraDxl = new ArrayList();
            kiemtraCxl = new ArrayList();
            listClass = lopHocBUS.GetDanhSachTatCaLopHocByMaTaiKhoan(this.taikhoanhienhanh.Mataikhoan);
            //LoadList();
            //btnNot.btnNotDone().Click += new System.EventHandler(this.btnChuaxuly_Click);
            //btnDone.getBtnDone().Click += new System.EventHandler(this.btnDaxuly_Click);

            leftFlowPanel.Controls.Add(btnNot);
            leftFlowPanel.Controls.Add(btnDone);
        }

      
    }
}

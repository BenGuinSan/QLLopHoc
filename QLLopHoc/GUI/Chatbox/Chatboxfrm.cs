using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLopHoc.GUI.Home.HomeComponents;
using QLLopHoc.DTO;
using QLLopHoc.BUS;

namespace QLLopHoc.GUI.Chatbox
{
    public partial class Chatboxfrm : Form
    {
        
        LopHocDTO lophoc;
        TaiKhoanDTO tk_hienhanh;
        PanelGiaoDienLopHoc gdlh;

        private int charLimit = 300;
        private bool isClickEventAssigned = false;

        // Lớp học mà tài khoản đang đăng nhập chọn
        public Chatboxfrm(PanelGiaoDienLopHoc pnl, LopHocDTO lh, TaiKhoanDTO tk)
        {
            InitializeComponent();
            this.tk_hienhanh = tk;
            this.lophoc = lh;
            gdlh = pnl;

            /*latestMess = group_messages_data.getLatest(lh.Malop.ToUpper());
            timerLoadMess.Start();
            setUp_notify();
            load_message();
            checkAreaChatTextEmpty();*/
        }

        private void Chatboxfrm_Load(object sender, EventArgs e)
        {

        }
    }
}

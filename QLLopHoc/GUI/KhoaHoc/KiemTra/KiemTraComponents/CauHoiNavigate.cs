using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    public partial class CauHoiNavigate : UserControl
    {
        public CauHoiNavigate()
        {
            InitializeComponent();
        }
        public KryptonButton getButtonNav()
        {
            return this.kryptonButton2;
        }
    }
}

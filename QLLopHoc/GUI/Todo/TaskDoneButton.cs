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

namespace QLLopHoc.GUI.Todo
{
    public partial class TaskDoneButton : UserControl
    {
        public TaskDoneButton()
        {
            InitializeComponent();
        }

        public KryptonButton getBtnDone()
        {
            return this.btnDaxuly;
        }

        private void tickPic_Click(object sender, EventArgs e)
        {
            this.btnDaxuly.PerformClick();
        }

        private void lblNotDone_Click(object sender, EventArgs e)
        {
            this.btnDaxuly.PerformClick();
        }
    }
}

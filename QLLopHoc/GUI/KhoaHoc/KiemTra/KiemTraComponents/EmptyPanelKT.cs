﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc.GUI.KhoaHoc.KiemTra.KiemTraComponents
{
    public partial class EmptyPanelKT : UserControl
    {
        public EmptyPanelKT()
        {
            InitializeComponent();
        }
        public EmptyPanelKT(string title)
        {
            InitializeComponent();
            this.title.Text = title;
        }
    }
}

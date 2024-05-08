using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLopHoc.GUI.Todo
{
    public partial class TaskList : UserControl
    {
        private ArrayList tasks;

        public ArrayList Tasks { get => tasks; set => tasks = value; }

        public TaskList()
        {
            InitializeComponent();
            tasks = new ArrayList();
        }

        public FlowLayoutPanel getTaskListPanel()
        {
            return this.taskListPanel;
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            lblTimKiem.Hide();
            if (txtTimKiem.Text.Length == 0)
                lblTimKiem.Show();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchString = RemoveDiacritics(txtTimKiem.Text.ToLower().Trim());
            taskListPanel.Controls.Clear();
            foreach (Control task in this.Tasks)
            {
                if (task is TaskHomeWork)
                {
                    if (RemoveDiacritics((task as TaskHomeWork).Lh.Tenlop.ToLower()).Contains(searchString))
                    {
                        taskListPanel.Controls.Add(task);
                    }
                }
                else
                {
                    if (RemoveDiacritics((task as TaskExam).Lh.Tenlop.ToLower()).Contains(searchString))
                    {
                        taskListPanel.Controls.Add(task);
                    }
                }
            }
        }
        public static string RemoveDiacritics(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder builder = new StringBuilder();

            foreach (char ch in normalized)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(ch);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}

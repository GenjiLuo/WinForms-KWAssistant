using KWAssistant.Data;
using KWAssistant.Properties;
using System;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class NewTaskForm : System.Windows.Forms.Form
    {
        public delegate void AddTask(int id, string keyword);

        public event AddTask AddTaskEvent;

        public NewTaskForm()
        {
            InitializeComponent();
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            var keyword = newTaskTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show(Resources.nullTip, Resources.Tip, MessageBoxButtons.OK);
            }
            else
            {
                AddTaskEvent?.Invoke(Global.Tasks.Count + 1, keyword);
                Close();
            }
        }
    }
}

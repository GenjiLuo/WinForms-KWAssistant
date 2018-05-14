using KWAssistant.Data;
using KWAssistant.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class NewGroupForm : System.Windows.Forms.Form
    {
        public event Action<string> AddNewGroupEvent;  //添加新分组

        public NewGroupForm()
        {
            InitializeComponent();
        }

        private void NewGroupForm_Activated(object sender, EventArgs e)
        {
            newGroupTextBox.Focus();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var name = newGroupTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))    //空名称
            {
                MessageBox.Show(Resources.nullTip, Resources.tip, MessageBoxButtons.OK);
            }
            else if (Global.Groups.Any(s => s.Name == name))    //命名重复
            {
                MessageBox.Show(Resources.existTip, Resources.tip, MessageBoxButtons.OK);
            }
            else
            {
                AddNewGroupEvent?.Invoke(name);
                Close();
            }
        }
    }
}

using KWAssistant.Data;
using KWAssistant.Data.Model;
using KWAssistant.Properties;
using KWAssistant.Util;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class NewGroupForm : System.Windows.Forms.Form
    {
        public delegate void AddNewGroupToView(string name);

        public event AddNewGroupToView AddNewGroupToViewEvent;  //把输入的组名传回主窗体

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
                MessageBox.Show(Resources.nullTip, Resources.Tip, MessageBoxButtons.OK);
            }
            else if (Global.Groups.Any(s => s.Name == name))    //命名重复
            {
                MessageBox.Show(Resources.existTip, Resources.Tip, MessageBoxButtons.OK);
            }
            else
            {
                Global.Groups.Add(new Group { Name = name });
                AddNewGroupToViewEvent?.Invoke(name);
                new Task(() => { FileUtil.SaveKeywords(Config.KeywordFilePath, Global.Groups); }).Start();
                Close();
            }
        }
    }
}

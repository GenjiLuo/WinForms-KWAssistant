using KWAssistant.Data.Model;
using System;
using System.Linq;

namespace KWAssistant.Form
{
    public partial class EditForm : System.Windows.Forms.Form
    {
        private Group _group;

        public event Func<Group> LoadGroupEvent;  //把指定分组信息加载到当前窗口

        public event Action<Group> UpdateGroupEvent;  //更新指定分组信息

        public EditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时，把指定分组的关键词列表读入文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            _group = LoadGroupEvent?.Invoke();
            if (_group?.Keywords == null) return;
            foreach (var keyword in _group.Keywords)
            {
                editTextBox.AppendText(keyword);
                editTextBox.AppendText("\r\n");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var keywords = editTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            _group.Keywords = keywords.ToList();
            UpdateGroupEvent?.Invoke(_group);
            Close();
        }
    }
}

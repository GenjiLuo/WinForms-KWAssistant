using KWAssistant.Data;
using KWAssistant.Data.Model;
using KWAssistant.Util;
using System;
using System.Threading.Tasks;

namespace KWAssistant.Form
{
    public partial class WhiteListForm : System.Windows.Forms.Form
    {
        public WhiteListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时，把白名单列表读到文本框内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WhiteListForm_Load(object sender, EventArgs e)
        {
            foreach (var word in Global.WhiteList)
            {
                WhiteListTextBox.AppendText(word);
                WhiteListTextBox.AppendText("\r\n");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var words = WhiteListTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Global.WhiteList.Clear();
            Global.WhiteList.AddRange(words);
            new Task(() => { FileUtil.SaveList(Config.WhiteListFilePath, Global.WhiteList); }).Start();
            Close();
        }
    }
}

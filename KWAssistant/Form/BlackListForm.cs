using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KWAssistant.Data;
using KWAssistant.Data.Model;
using KWAssistant.Util;

namespace KWAssistant.Form
{
    public partial class BlackListForm : System.Windows.Forms.Form
    {
        public BlackListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时，把黑名单列表读到文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlackListForm_Load(object sender, EventArgs e)
        {
            foreach (var word in Global.BlackList)
            {
                blackListTextBox.AppendText(word);
                blackListTextBox.AppendText("\r\n");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var words = blackListTextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Global.BlackList.Clear();
            Global.BlackList.AddRange(words);
            new Task(() => { FileUtil.SaveList(Config.BlackListFilePath, Global.BlackList); }).Start();
            Close();
        }
    }
}

using KWAssistant.Data;
using KWAssistant.Data.Model;
using KWAssistant.Properties;
using KWAssistant.Util;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class SettingForm : System.Windows.Forms.Form
    {
        public SettingForm()
        {
            InitializeComponent();
            InitData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show(Resources.invalidTip, Resources.tip, MessageBoxButtons.OK);
            }
            else
            {
                var newSetting = new Setting
                {
                    PageMin = (int)pageMin.Value,
                    PageMax = (int)pageMax.Value,
                    IntervalMin = (int)intervalMin.Value,
                    IntervalMax = (int)intervalMax.Value,
                    SearchMin = (int)searchMin.Value,
                    SearchMax = (int)searchMax.Value,
                    ClickMin = (int)clickMin.Value,
                    ClickMax = (int)clickMax.Value,
                    TimeSpent = (int)timeSpent.Value
                };
                Global.Setting = newSetting;
                new Task(() => { FileUtil.SaveSetting(Config.SettingFilePath, newSetting); }).Start();
                Close();
            }
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            pageMin.Value = Global.Setting.PageMin;
            pageMax.Value = Global.Setting.PageMax;
            intervalMin.Value = Global.Setting.IntervalMin;
            intervalMax.Value = Global.Setting.IntervalMax;
            searchMin.Value = Global.Setting.SearchMin;
            searchMax.Value = Global.Setting.SearchMax;
            clickMin.Value = Global.Setting.ClickMin;
            clickMax.Value = Global.Setting.ClickMax;
            timeSpent.Value = Global.Setting.TimeSpent;
        }

        /// <summary>
        /// 检验数字合法性，不接受数字和退格以外的输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 当numericUpDown控件失去焦点时，使其显示的内容和实际的数值一致
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_Leave(object sender, EventArgs e)
        {
            var input = sender as UpDownBase;
            if (input?.Text == string.Empty)
            {
                var num = sender as NumericUpDown;
                input.Text = num?.Value.ToString(CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// 验证数据是否合法
        /// </summary>
        /// <returns></returns>
        private bool IsValid()
        {
            return pageMin.Value <= pageMax.Value
                   && intervalMin.Value <= intervalMax.Value
                   && searchMin.Value <= searchMax.Value
                   && clickMin.Value <= clickMax.Value;
        }
    }
}

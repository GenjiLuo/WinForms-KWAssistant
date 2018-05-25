using System.Diagnostics;
using System.Windows.Forms;

namespace KWAssistant.Form
{
    public partial class AboutForm : System.Windows.Forms.Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel.Text);
            linkLabel.LinkVisited = true;
        }
    }
}

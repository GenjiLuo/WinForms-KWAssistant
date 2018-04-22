using KWAssistant.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using KWAssistant.Data.Model;
using KWAssistant.Properties;
using System.Linq;
using System.Threading.Tasks;
using KWAssistant.Util;

namespace KWAssistant.Form
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置启动窗口的大小
            var screenArea = Screen.GetWorkingArea(this);
            ClientSize = new Size((int)(screenArea.Width * 0.6), (int)(screenArea.Height * 0.6));

            SizeAdaptive();
            InitData();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            SizeAdaptive();
        }

        #region 自定义方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            foreach (var groups in Global.Groups ?? Enumerable.Empty<Group>())
            {
                var parent = new TreeNode { Text = groups.Name };
                foreach (var keyword in groups.Keywords ?? Enumerable.Empty<string>())
                {
                    var child = new TreeNode { Text = keyword };
                    parent.Nodes.Add(child);
                }

                kwTreeView.Nodes.Add(parent);
            }
        }

        /// <summary>
        /// 设置任务列表和日志列表的表头宽度
        /// </summary>
        private void SizeAdaptive()
        {
            //设置任务列表中Status列的列宽
            taskListView.Columns[3].Width =
                taskListView.ClientSize.Width - taskListView.Columns[0].Width - taskListView.Columns[1].Width -
                taskListView.Columns[2].Width;

            //设置日志列表中Url列的列宽
            logListView.Columns[3].Width =
                logListView.ClientSize.Width - logListView.Columns[0].Width - logListView.Columns[1].Width -
                logListView.Columns[2].Width - logListView.Columns[4].Width - logListView.Columns[5].Width;
        }

        /// <summary>
        /// 添加项到任务列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="groupName"></param>
        /// <param name="keyword"></param>
        /// <param name="url"></param>
        /// <param name="status"></param>
        private void AddTaskItem(int id, string groupName, string keyword, string status)
        {
            var record = new Record
            {
                Id = id,
                GroupName = groupName,
                Keyword = keyword,
                Status = Resources.toDoStatus
            };
            Global.Tasks.Add(record);
            var item = new ListViewItem(id.ToString());
            item.SubItems.Add(groupName);
            item.SubItems.Add(keyword);
            item.SubItems.Add(status);
            taskListView.Items.Add(item);
        }
        #endregion

        #region 菜单栏点击事件
        private void whiteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WhiteListForm { StartPosition = FormStartPosition.CenterParent }
                .ShowDialog();
        }

        private void blackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BlackListForm { StartPosition = FormStartPosition.CenterParent }
                .ShowDialog();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingForm { StartPosition = FormStartPosition.CenterParent }
                .ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo
        }
        #endregion

        #region 关键词列表右键菜单事件
        private void kwTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //右键点击不同级别的节点，显示不同的快捷菜单
            if (e.Button != MouseButtons.Right) return;
            if (e.Node.Level == 0)
            {
                editToolStripMenuItem.Visible = true;
                addToTaskToolStripMenuItem.Visible = true;
                deleteGroupToolStripMenuItem.Visible = true;
            }
            else if (e.Node.Level == 1)
            {
                editToolStripMenuItem.Visible = false;
                addToTaskToolStripMenuItem.Visible = true;
                deleteGroupToolStripMenuItem.Visible = false;
            }
            kwTreeView.SelectedNode = e.Node;
        }

        private void kwTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (sender == kwTreeView)
            {
                editToolStripMenuItem.Visible = false;
                addToTaskToolStripMenuItem.Visible = false;
                deleteGroupToolStripMenuItem.Visible = false;

                kwTreeView.SelectedNode = null;
            }
        }

        private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newGroupForm = new NewGroupForm { StartPosition = FormStartPosition.CenterParent };
            newGroupForm.AddNewGroupEvent += name =>
            {
                Global.Groups.Add(new Group { Name = name });
                //持久化
                new Task(() => { FileUtil.SaveKeywords(Config.KeywordFilePath, Global.Groups); }).Start();
                //更新视图
                kwTreeView.Nodes.Add(name);
            };
            newGroupForm.ShowDialog();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kwTreeView.CollapseAll();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kwTreeView.ExpandAll();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var group = Global.Groups[kwTreeView.SelectedNode.Index];
            var editForm = new EditForm { StartPosition = FormStartPosition.CenterParent };
            editForm.LoadGroupEvent += () => group;
            editForm.updateGroupEvent += newGroup =>
            {
                var index = Global.Groups.FindIndex(g => g.Name == newGroup.Name);
                Global.Groups[index] = newGroup;
                //持久化
                new Task(() => { FileUtil.SaveKeywords(Config.KeywordFilePath, Global.Groups); }).Start();
                //更新视图数据
                var nodes = kwTreeView.Nodes[index].Nodes;
                nodes.Clear();
                foreach (var newKeyword in newGroup.Keywords)
                {
                    nodes.Add(newKeyword);
                }
            };
            editForm.ShowDialog();
        }

        private void addToTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectNode = kwTreeView.SelectedNode;
            if (selectNode.Level == 0)  //添加分组到任务列表
            {
                var index = Global.Tasks.Count;
                foreach (TreeNode child in selectNode.Nodes)
                {
                    AddTaskItem(++index, selectNode.Text, child.Text, Resources.toDoStatus);
                }
            }
            else if (selectNode.Level == 1) //添加单个关键词到任务列表
            {
                AddTaskItem(Global.Tasks.Count + 1, selectNode.Parent.Text, selectNode.Text, Resources.toDoStatus);
            }
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectNode = kwTreeView.SelectedNode;
            if (MessageBox.Show(Resources.deleteTip, Resources.Tip, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.Groups.RemoveAt(selectNode.Index);
                kwTreeView.Nodes.Remove(selectNode);
                new Task(() => { FileUtil.SaveKeywords(Config.KeywordFilePath, Global.Groups); }).Start();
            }
        }
        #endregion

        #region 任务列表按钮点击事件
        private void newTaskButton_Click(object sender, EventArgs e)
        {
            var newTaskForm = new NewTaskForm { StartPosition = FormStartPosition.CenterParent };
            newTaskForm.AddTaskEvent += (id, keyword) => { AddTaskItem(id, "", keyword, Resources.toDoStatus); };
            newTaskForm.ShowDialog();
        }

        private void clickModeButton_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void quickModeButton_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            Global.Tasks.Clear();
            taskListView.Items.Clear();
        }
        #endregion
    }
}

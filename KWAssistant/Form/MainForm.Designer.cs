namespace KWAssistant.Form
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.SplitContainer splitContainer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.SplitContainer splitContainer2;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.ColumnHeader columnHeader5;
            System.Windows.Forms.ColumnHeader columnHeader6;
            System.Windows.Forms.ColumnHeader columnHeader7;
            System.Windows.Forms.ColumnHeader columnHeader8;
            System.Windows.Forms.ColumnHeader columnHeader9;
            System.Windows.Forms.ColumnHeader columnHeader10;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
            System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
            this.kwTreeView = new System.Windows.Forms.TreeView();
            this.kwContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.taskListView = new System.Windows.Forms.ListView();
            this.quickModeButton = new System.Windows.Forms.Button();
            this.clickModeButton = new System.Windows.Forms.Button();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.logListView = new System.Windows.Forms.ListView();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentTaskLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.hitsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBox1 = new System.Windows.Forms.GroupBox();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            groupBox2 = new System.Windows.Forms.GroupBox();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            groupBox3 = new System.Windows.Forms.GroupBox();
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            this.kwContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.whiteListToolStripMenuItem,
            this.blackListToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(this.kwTreeView);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // kwTreeView
            // 
            this.kwTreeView.ContextMenuStrip = this.kwContextMenuStrip;
            resources.ApplyResources(this.kwTreeView, "kwTreeView");
            this.kwTreeView.Name = "kwTreeView";
            this.kwTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.kwTreeView_NodeMouseClick);
            this.kwTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kwTreeView_MouseDown);
            // 
            // kwContextMenuStrip
            // 
            this.kwContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kwContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGroupToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addToTaskToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.deleteGroupToolStripMenuItem});
            this.kwContextMenuStrip.Name = "contextMenuStrip1";
            resources.ApplyResources(this.kwContextMenuStrip, "kwContextMenuStrip");
            // 
            // newGroupToolStripMenuItem
            // 
            this.newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            resources.ApplyResources(this.newGroupToolStripMenuItem, "newGroupToolStripMenuItem");
            this.newGroupToolStripMenuItem.Click += new System.EventHandler(this.newGroupToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToTaskToolStripMenuItem
            // 
            this.addToTaskToolStripMenuItem.Name = "addToTaskToolStripMenuItem";
            resources.ApplyResources(this.addToTaskToolStripMenuItem, "addToTaskToolStripMenuItem");
            this.addToTaskToolStripMenuItem.Click += new System.EventHandler(this.addToTaskToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            resources.ApplyResources(this.collapseAllToolStripMenuItem, "collapseAllToolStripMenuItem");
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            resources.ApplyResources(this.expandAllToolStripMenuItem, "expandAllToolStripMenuItem");
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            resources.ApplyResources(this.deleteGroupToolStripMenuItem, "deleteGroupToolStripMenuItem");
            this.deleteGroupToolStripMenuItem.Click += new System.EventHandler(this.deleteGroupToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(splitContainer2, "splitContainer2");
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox3);
            splitContainer2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.loopCheckBox);
            groupBox2.Controls.Add(this.cleanButton);
            groupBox2.Controls.Add(this.stopButton);
            groupBox2.Controls.Add(this.taskListView);
            groupBox2.Controls.Add(this.quickModeButton);
            groupBox2.Controls.Add(this.clickModeButton);
            groupBox2.Controls.Add(this.newTaskButton);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // loopCheckBox
            // 
            resources.ApplyResources(this.loopCheckBox, "loopCheckBox");
            this.loopCheckBox.Name = "loopCheckBox";
            this.loopCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleanButton
            // 
            resources.ApplyResources(this.cleanButton, "cleanButton");
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // taskListView
            // 
            resources.ApplyResources(this.taskListView, "taskListView");
            this.taskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4});
            this.taskListView.FullRowSelect = true;
            this.taskListView.GridLines = true;
            this.taskListView.HideSelection = false;
            this.taskListView.Name = "taskListView";
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(columnHeader4, "columnHeader4");
            // 
            // quickModeButton
            // 
            resources.ApplyResources(this.quickModeButton, "quickModeButton");
            this.quickModeButton.Name = "quickModeButton";
            this.quickModeButton.UseVisualStyleBackColor = true;
            this.quickModeButton.Click += new System.EventHandler(this.quickModeButton_Click);
            // 
            // clickModeButton
            // 
            resources.ApplyResources(this.clickModeButton, "clickModeButton");
            this.clickModeButton.Name = "clickModeButton";
            this.clickModeButton.UseVisualStyleBackColor = true;
            this.clickModeButton.Click += new System.EventHandler(this.clickModeButton_Click);
            // 
            // newTaskButton
            // 
            resources.ApplyResources(this.newTaskButton, "newTaskButton");
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(this.logListView);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // logListView
            // 
            resources.ApplyResources(this.logListView, "logListView");
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            columnHeader6,
            columnHeader7,
            columnHeader8,
            columnHeader9,
            columnHeader10});
            this.logListView.FullRowSelect = true;
            this.logListView.GridLines = true;
            this.logListView.HideSelection = false;
            this.logListView.Name = "logListView";
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            resources.ApplyResources(columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(columnHeader9, "columnHeader9");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(columnHeader10, "columnHeader10");
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            resources.ApplyResources(this.settingToolStripMenuItem, "settingToolStripMenuItem");
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // whiteListToolStripMenuItem
            // 
            this.whiteListToolStripMenuItem.Name = "whiteListToolStripMenuItem";
            resources.ApplyResources(this.whiteListToolStripMenuItem, "whiteListToolStripMenuItem");
            this.whiteListToolStripMenuItem.Click += new System.EventHandler(this.whiteListToolStripMenuItem_Click);
            // 
            // blackListToolStripMenuItem
            // 
            this.blackListToolStripMenuItem.Name = "blackListToolStripMenuItem";
            resources.ApplyResources(this.blackListToolStripMenuItem, "blackListToolStripMenuItem");
            this.blackListToolStripMenuItem.Click += new System.EventHandler(this.blackListToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.Controls.Add(splitContainer1);
            panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(this.statusStrip1);
            panel2.Name = "panel2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1,
            this.currentTaskLabel,
            this.toolStripStatusLabel4,
            toolStripStatusLabel3,
            this.hitsLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // currentTaskLabel
            // 
            this.currentTaskLabel.ForeColor = System.Drawing.Color.Red;
            this.currentTaskLabel.Name = "currentTaskLabel";
            resources.ApplyResources(this.currentTaskLabel, "currentTaskLabel");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            this.toolStripStatusLabel4.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // hitsLabel
            // 
            this.hitsLabel.ForeColor = System.Drawing.Color.Red;
            this.hitsLabel.Name = "hitsLabel";
            resources.ApplyResources(this.hitsLabel, "hitsLabel");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            this.kwContextMenuStrip.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer2)).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button quickModeButton;
        private System.Windows.Forms.Button clickModeButton;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.ListView taskListView;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.TreeView kwTreeView;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.CheckBox loopCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentTaskLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel hitsLabel;
        private System.Windows.Forms.ContextMenuStrip kwContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
    }
}


namespace KWAssistant.Form
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label3;
            this.pageMin = new System.Windows.Forms.NumericUpDown();
            this.pageMax = new System.Windows.Forms.NumericUpDown();
            this.searchMax = new System.Windows.Forms.NumericUpDown();
            this.searchMin = new System.Windows.Forms.NumericUpDown();
            this.clickMax = new System.Windows.Forms.NumericUpDown();
            this.clickMin = new System.Windows.Forms.NumericUpDown();
            this.timeSpent = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            this.toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            this.toolTip1.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            this.toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            this.toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            this.toolTip1.SetToolTip(label6, resources.GetString("label6.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            this.toolTip1.SetToolTip(label7, resources.GetString("label7.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            this.toolTip1.SetToolTip(label9, resources.GetString("label9.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            this.toolTip1.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // pageMin
            // 
            resources.ApplyResources(this.pageMin, "pageMin");
            this.pageMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pageMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageMin.Name = "pageMin";
            this.toolTip1.SetToolTip(this.pageMin, resources.GetString("pageMin.ToolTip"));
            this.pageMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.pageMin.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // pageMax
            // 
            resources.ApplyResources(this.pageMax, "pageMax");
            this.pageMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pageMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageMax.Name = "pageMax";
            this.toolTip1.SetToolTip(this.pageMax, resources.GetString("pageMax.ToolTip"));
            this.pageMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pageMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.pageMax.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // searchMax
            // 
            resources.ApplyResources(this.searchMax, "searchMax");
            this.searchMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.searchMax.Name = "searchMax";
            this.toolTip1.SetToolTip(this.searchMax, resources.GetString("searchMax.ToolTip"));
            this.searchMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.searchMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.searchMax.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // searchMin
            // 
            resources.ApplyResources(this.searchMin, "searchMin");
            this.searchMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.searchMin.Name = "searchMin";
            this.toolTip1.SetToolTip(this.searchMin, resources.GetString("searchMin.ToolTip"));
            this.searchMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.searchMin.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // clickMax
            // 
            resources.ApplyResources(this.clickMax, "clickMax");
            this.clickMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.clickMax.Name = "clickMax";
            this.toolTip1.SetToolTip(this.clickMax, resources.GetString("clickMax.ToolTip"));
            this.clickMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.clickMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.clickMax.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // clickMin
            // 
            resources.ApplyResources(this.clickMin, "clickMin");
            this.clickMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.clickMin.Name = "clickMin";
            this.toolTip1.SetToolTip(this.clickMin, resources.GetString("clickMin.ToolTip"));
            this.clickMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.clickMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.clickMin.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // timeSpent
            // 
            resources.ApplyResources(this.timeSpent, "timeSpent");
            this.timeSpent.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.timeSpent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeSpent.Name = "timeSpent";
            this.toolTip1.SetToolTip(this.timeSpent, resources.GetString("timeSpent.ToolTip"));
            this.timeSpent.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.timeSpent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            this.timeSpent.Leave += new System.EventHandler(this.numericUpDown_Leave);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.toolTip1.SetToolTip(this.saveButton, resources.GetString("saveButton.ToolTip"));
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.toolTip1.SetToolTip(this.cancelButton, resources.GetString("cancelButton.ToolTip"));
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.timeSpent);
            this.Controls.Add(label9);
            this.Controls.Add(this.clickMax);
            this.Controls.Add(this.clickMin);
            this.Controls.Add(label7);
            this.Controls.Add(this.searchMax);
            this.Controls.Add(this.searchMin);
            this.Controls.Add(label6);
            this.Controls.Add(this.pageMax);
            this.Controls.Add(this.pageMin);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "SettingForm";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.pageMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pageMin;
        private System.Windows.Forms.NumericUpDown pageMax;
        private System.Windows.Forms.NumericUpDown searchMax;
        private System.Windows.Forms.NumericUpDown searchMin;
        private System.Windows.Forms.NumericUpDown clickMax;
        private System.Windows.Forms.NumericUpDown clickMin;
        private System.Windows.Forms.NumericUpDown timeSpent;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cancelButton;
    }
}
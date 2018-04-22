namespace KWAssistant.Form
{
    partial class NewTaskForm
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaskForm));
            this.newTaskTextBox = new System.Windows.Forms.TextBox();
            this.newTaskButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // newTaskTextBox
            // 
            resources.ApplyResources(this.newTaskTextBox, "newTaskTextBox");
            this.newTaskTextBox.Name = "newTaskTextBox";
            // 
            // newTaskButton
            // 
            resources.ApplyResources(this.newTaskButton, "newTaskButton");
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // NewTaskForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.newTaskButton);
            this.Controls.Add(this.newTaskTextBox);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newTaskTextBox;
        private System.Windows.Forms.Button newTaskButton;
    }
}
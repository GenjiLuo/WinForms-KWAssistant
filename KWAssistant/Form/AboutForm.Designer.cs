namespace KWAssistant.Form
{
    partial class AboutForm
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = global::KWAssistant.Properties.Resources.g;
            pictureBox1.Location = new System.Drawing.Point(223, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(150, 150);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label2.Location = new System.Drawing.Point(205, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(194, 25);
            label2.TabIndex = 3;
            label2.Text = "百度关键词助手";
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(110, 314);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(399, 15);
            this.linkLabel.TabIndex = 1;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "https://github.com/barry1101/WinForms-KWAssistant";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "by 小窝";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(608, 399);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}
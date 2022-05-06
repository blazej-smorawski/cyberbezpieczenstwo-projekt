namespace projekt
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelKey;
            System.Windows.Forms.Label ivLabel;
            System.Windows.Forms.Label labelMode;
            this.loadData = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.algorithmDropdown = new System.Windows.Forms.ComboBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.saveOutput = new System.Windows.Forms.Button();
            this.debuginfo = new System.Windows.Forms.Button();
            this.ivBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            labelKey = new System.Windows.Forms.Label();
            ivLabel = new System.Windows.Forms.Label();
            labelMode = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new System.Drawing.Point(353, 67);
            labelKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelKey.Name = "labelKey";
            labelKey.Size = new System.Drawing.Size(58, 32);
            labelKey.TabIndex = 7;
            labelKey.Text = "Key:";
            // 
            // ivLabel
            // 
            ivLabel.AutoSize = true;
            ivLabel.Location = new System.Drawing.Point(643, 70);
            ivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ivLabel.Name = "ivLabel";
            ivLabel.Size = new System.Drawing.Size(40, 32);
            ivLabel.TabIndex = 11;
            ivLabel.Text = "IV:";
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.Location = new System.Drawing.Point(13, 67);
            labelMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMode.Name = "labelMode";
            labelMode.Size = new System.Drawing.Size(82, 32);
            labelMode.TabIndex = 12;
            labelMode.Text = "Mode:";
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(11, 13);
            this.loadData.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(150, 47);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "Load Data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(11, 125);
            this.inputText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(777, 978);
            this.inputText.TabIndex = 1;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(795, 125);
            this.outputText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(777, 978);
            this.outputText.TabIndex = 2;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(169, 13);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(150, 47);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(327, 13);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(150, 47);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // algorithmDropdown
            // 
            this.algorithmDropdown.FormattingEnabled = true;
            this.algorithmDropdown.Location = new System.Drawing.Point(103, 64);
            this.algorithmDropdown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.algorithmDropdown.Name = "algorithmDropdown";
            this.algorithmDropdown.Size = new System.Drawing.Size(242, 40);
            this.algorithmDropdown.TabIndex = 5;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(419, 67);
            this.keyBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(216, 39);
            this.keyBox.TabIndex = 6;
            this.keyBox.Text = "1234123412341234";
            // 
            // saveOutput
            // 
            this.saveOutput.Location = new System.Drawing.Point(1370, 13);
            this.saveOutput.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(197, 47);
            this.saveOutput.TabIndex = 8;
            this.saveOutput.Text = "Save Output";
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            // 
            // debuginfo
            // 
            this.debuginfo.Location = new System.Drawing.Point(485, 13);
            this.debuginfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.debuginfo.Name = "debuginfo";
            this.debuginfo.Size = new System.Drawing.Size(150, 47);
            this.debuginfo.TabIndex = 9;
            this.debuginfo.Text = "DEBUG INFO";
            this.debuginfo.UseVisualStyleBackColor = true;
            // 
            // ivBox
            // 
            this.ivBox.Location = new System.Drawing.Point(691, 67);
            this.ivBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ivBox.Name = "ivBox";
            this.ivBox.Size = new System.Drawing.Size(216, 39);
            this.ivBox.TabIndex = 10;
            this.ivBox.Text = "1234123412341234";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1142);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1580, 42);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(0, 32);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(210, 32);
            this.statusLabel.Text = "Loading Complete";
            this.statusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1184);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(labelMode);
            this.Controls.Add(ivLabel);
            this.Controls.Add(this.ivBox);
            this.Controls.Add(this.debuginfo);
            this.Controls.Add(this.saveOutput);
            this.Controls.Add(labelKey);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.algorithmDropdown);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.loadData);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainView";
            this.Text = "Encrypting App";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loadData;
        private TextBox inputText;
        private TextBox outputText;
        private Button encryptButton;
        private Button decryptButton;
        private ComboBox algorithmDropdown;
        private TextBox keyBox;
        private Button saveOutput;
        private Button debuginfo;
        private TextBox ivBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stripStatus;
        private ToolStripStatusLabel statusLabel;
    }
}
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
            System.Windows.Forms.Label labelMode;
            System.Windows.Forms.Label label1;
            this.loadData = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.algorithmDropdown = new System.Windows.Forms.ComboBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.saveOutput = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.swapBufferButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ivTextBox = new System.Windows.Forms.TextBox();
            labelKey = new System.Windows.Forms.Label();
            labelMode = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new System.Drawing.Point(191, 34);
            labelKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelKey.Name = "labelKey";
            labelKey.Size = new System.Drawing.Size(29, 15);
            labelKey.TabIndex = 7;
            labelKey.Text = "Key:";
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.Location = new System.Drawing.Point(6, 34);
            labelMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelMode.Name = "labelMode";
            labelMode.Size = new System.Drawing.Size(41, 15);
            labelMode.TabIndex = 12;
            labelMode.Text = "Mode:";
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(6, 6);
            this.loadData.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(81, 22);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "Load Data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(6, 59);
            this.inputText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(420, 461);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "";
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(428, 59);
            this.outputText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(420, 461);
            this.outputText.TabIndex = 2;
            this.outputText.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(91, 6);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(81, 22);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(176, 6);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(81, 22);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // algorithmDropdown
            // 
            this.algorithmDropdown.FormattingEnabled = true;
            this.algorithmDropdown.Location = new System.Drawing.Point(55, 30);
            this.algorithmDropdown.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.algorithmDropdown.Name = "algorithmDropdown";
            this.algorithmDropdown.Size = new System.Drawing.Size(132, 23);
            this.algorithmDropdown.TabIndex = 5;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(226, 31);
            this.keyBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(118, 23);
            this.keyBox.TabIndex = 6;
            this.keyBox.Text = "1234123412341234";
            // 
            // saveOutput
            // 
            this.saveOutput.Location = new System.Drawing.Point(738, 6);
            this.saveOutput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(106, 22);
            this.saveOutput.TabIndex = 8;
            this.saveOutput.Text = "Save Output";
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatus,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(851, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(105, 17);
            this.statusLabel.Text = "Loading Complete";
            // 
            // swapBufferButton
            // 
            this.swapBufferButton.AccessibleName = "swapBuffersButton";
            this.swapBufferButton.Location = new System.Drawing.Point(263, 6);
            this.swapBufferButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.swapBufferButton.Name = "swapBufferButton";
            this.swapBufferButton.Size = new System.Drawing.Size(81, 22);
            this.swapBufferButton.TabIndex = 15;
            this.swapBufferButton.Text = "Swap buffers";
            this.swapBufferButton.UseVisualStyleBackColor = true;
            this.swapBufferButton.Click += new System.EventHandler(this.swapBufferButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(360, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "show changes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ivTextBox
            // 
            this.ivTextBox.Location = new System.Drawing.Point(372, 31);
            this.ivTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ivTextBox.Name = "ivTextBox";
            this.ivTextBox.Size = new System.Drawing.Size(118, 23);
            this.ivTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(348, 33);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 15);
            label1.TabIndex = 18;
            label1.Text = "IV:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 497);
            this.Controls.Add(label1);
            this.Controls.Add(this.ivTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.swapBufferButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(labelMode);
            this.Controls.Add(this.saveOutput);
            this.Controls.Add(labelKey);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.algorithmDropdown);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.loadData);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private RichTextBox inputText;
        private RichTextBox outputText;
        private Button encryptButton;
        private Button decryptButton;
        private ComboBox algorithmDropdown;
        private TextBox keyBox;
        private Button saveOutput;
        private Button debuginfo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stripStatus;
        private ToolStripStatusLabel statusLabel;
        private Button swapBufferButton;
        private CheckBox checkBox1;
        private TextBox ivTextBox;
    }
}
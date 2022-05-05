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
            this.loadData = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.algorithmDropdown = new System.Windows.Forms.ComboBox();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.saveOutput = new System.Windows.Forms.Button();
            this.debuginfo = new System.Windows.Forms.Button();
            labelKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new System.Drawing.Point(234, 9);
            labelKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelKey.Name = "labelKey";
            labelKey.Size = new System.Drawing.Size(29, 15);
            labelKey.TabIndex = 7;
            labelKey.Text = "Key:";
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
            this.inputText.Location = new System.Drawing.Point(6, 30);
            this.inputText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(420, 489);
            this.inputText.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(428, 30);
            this.outputText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(420, 489);
            this.outputText.TabIndex = 2;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(428, 6);
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
            this.decryptButton.Location = new System.Drawing.Point(512, 6);
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
            this.algorithmDropdown.Location = new System.Drawing.Point(90, 8);
            this.algorithmDropdown.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.algorithmDropdown.Name = "algorithmDropdown";
            this.algorithmDropdown.Size = new System.Drawing.Size(132, 23);
            this.algorithmDropdown.TabIndex = 5;
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(268, 8);
            this.keyBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(158, 23);
            this.keyBox.TabIndex = 6;
            this.keyBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveOutput
            // 
            this.saveOutput.Location = new System.Drawing.Point(740, 6);
            this.saveOutput.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(106, 22);
            this.saveOutput.TabIndex = 8;
            this.saveOutput.Text = "Save Output";
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            // 
            // debuginfo
            // 
            this.debuginfo.Location = new System.Drawing.Point(622, 7);
            this.debuginfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.debuginfo.Name = "debuginfo";
            this.debuginfo.Size = new System.Drawing.Size(81, 22);
            this.debuginfo.TabIndex = 9;
            this.debuginfo.Text = "DEBUG INFO";
            this.debuginfo.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 497);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainView";
            this.Text = "Encrypting App";
            this.Load += new System.EventHandler(this.MainView_Load);
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
    }
}
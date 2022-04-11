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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveOutput = new System.Windows.Forms.Button();
            labelKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(12, 12);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(150, 46);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "Load Data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 64);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(776, 1039);
            this.inputText.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(794, 64);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(776, 1039);
            this.outputText.TabIndex = 2;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(794, 12);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(150, 46);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(950, 12);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(150, 46);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // algorithmDropdown
            // 
            this.algorithmDropdown.FormattingEnabled = true;
            this.algorithmDropdown.Location = new System.Drawing.Point(168, 16);
            this.algorithmDropdown.Name = "algorithmDropdown";
            this.algorithmDropdown.Size = new System.Drawing.Size(242, 40);
            this.algorithmDropdown.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 39);
            this.textBox1.TabIndex = 6;
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new System.Drawing.Point(434, 19);
            labelKey.Name = "labelKey";
            labelKey.Size = new System.Drawing.Size(58, 32);
            labelKey.TabIndex = 7;
            labelKey.Text = "Key:";
            // 
            // saveOutput
            // 
            this.saveOutput.Location = new System.Drawing.Point(1374, 12);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(196, 46);
            this.saveOutput.TabIndex = 8;
            this.saveOutput.Text = "Save Output";
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1115);
            this.Controls.Add(this.saveOutput);
            this.Controls.Add(labelKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.algorithmDropdown);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.loadData);
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
        private TextBox textBox1;
        private Button saveOutput;
    }
}
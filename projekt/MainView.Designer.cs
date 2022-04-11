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
            this.selectFile = new System.Windows.Forms.Button();
            this.plainText = new System.Windows.Forms.TextBox();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(12, 12);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(150, 46);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(12, 64);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.ReadOnly = true;
            this.plainText.Size = new System.Drawing.Size(776, 1039);
            this.plainText.TabIndex = 1;
            this.plainText.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(794, 64);
            this.encryptedText.Multiline = true;
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.ReadOnly = true;
            this.encryptedText.Size = new System.Drawing.Size(776, 1039);
            this.encryptedText.TabIndex = 2;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(168, 12);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(150, 46);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1115);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.selectFile);
            this.Name = "MainView";
            this.Text = "Encrypting App";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectFile;
        private TextBox plainText;
        private TextBox encryptedText;
        private Button encryptButton;
    }
}
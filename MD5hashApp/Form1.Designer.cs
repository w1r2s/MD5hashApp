namespace MD5hashApp
{
    partial class MD5_App
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
            InputTextBox = new TextBox();
            BrowseButton = new Button();
            ChooseFileLabel = new Label();
            InfoButton = new Button();
            VerifyButton = new Button();
            ExitButton = new Button();
            HashBox = new TextBox();
            SecondHashBox = new TextBox();
            CheckSumValue = new Label();
            FileNameLabel = new Label();
            OriginalCheckSum = new Label();
            NameLabel = new Label();
            FileSizeLabel = new Label();
            SizeLabel = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 45);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.ReadOnly = true;
            InputTextBox.Size = new Size(458, 27);
            InputTextBox.TabIndex = 2;
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(476, 45);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(94, 27);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // ChooseFileLabel
            // 
            ChooseFileLabel.AutoSize = true;
            ChooseFileLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseFileLabel.Location = new Point(12, 14);
            ChooseFileLabel.Name = "ChooseFileLabel";
            ChooseFileLabel.Size = new Size(305, 28);
            ChooseFileLabel.TabIndex = 0;
            ChooseFileLabel.Text = "Choose file to compute checksum";
            // 
            // InfoButton
            // 
            InfoButton.Location = new Point(12, 312);
            InfoButton.Name = "InfoButton";
            InfoButton.Size = new Size(94, 29);
            InfoButton.TabIndex = 3;
            InfoButton.Text = "About";
            InfoButton.UseVisualStyleBackColor = true;
            InfoButton.Click += InfoButton_Click;
            // 
            // VerifyButton
            // 
            VerifyButton.Location = new Point(417, 222);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(94, 29);
            VerifyButton.TabIndex = 4;
            VerifyButton.Text = "Verify";
            VerifyButton.UseVisualStyleBackColor = true;
            VerifyButton.Click += VerifyButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(476, 312);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HashBox
            // 
            HashBox.Location = new Point(12, 162);
            HashBox.Name = "HashBox";
            HashBox.ReadOnly = true;
            HashBox.Size = new Size(399, 27);
            HashBox.TabIndex = 6;
            // 
            // SecondHashBox
            // 
            SecondHashBox.Location = new Point(12, 223);
            SecondHashBox.Name = "SecondHashBox";
            SecondHashBox.Size = new Size(399, 27);
            SecondHashBox.TabIndex = 7;
            // 
            // CheckSumValue
            // 
            CheckSumValue.AutoSize = true;
            CheckSumValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckSumValue.Location = new Point(12, 131);
            CheckSumValue.Name = "CheckSumValue";
            CheckSumValue.Size = new Size(253, 28);
            CheckSumValue.TabIndex = 8;
            CheckSumValue.Text = "Current file checksum value:";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameLabel.Location = new Point(12, 75);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(99, 28);
            FileNameLabel.TabIndex = 9;
            FileNameLabel.Text = "File name:";
            // 
            // OriginalCheckSum
            // 
            OriginalCheckSum.AutoSize = true;
            OriginalCheckSum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OriginalCheckSum.Location = new Point(12, 192);
            OriginalCheckSum.Name = "OriginalCheckSum";
            OriginalCheckSum.Size = new Size(254, 28);
            OriginalCheckSum.TabIndex = 10;
            OriginalCheckSum.Text = "Original file checksum value";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(117, 75);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(0, 28);
            NameLabel.TabIndex = 12;
            // 
            // FileSizeLabel
            // 
            FileSizeLabel.AutoSize = true;
            FileSizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileSizeLabel.Location = new Point(12, 103);
            FileSizeLabel.Name = "FileSizeLabel";
            FileSizeLabel.Size = new Size(83, 28);
            FileSizeLabel.TabIndex = 13;
            FileSizeLabel.Text = "File size:";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SizeLabel.Location = new Point(117, 103);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(0, 28);
            SizeLabel.TabIndex = 14;
            // 
            // MD5_App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(SizeLabel);
            Controls.Add(FileSizeLabel);
            Controls.Add(NameLabel);
            Controls.Add(OriginalCheckSum);
            Controls.Add(FileNameLabel);
            Controls.Add(CheckSumValue);
            Controls.Add(SecondHashBox);
            Controls.Add(HashBox);
            Controls.Add(ExitButton);
            Controls.Add(VerifyButton);
            Controls.Add(InfoButton);
            Controls.Add(ChooseFileLabel);
            Controls.Add(BrowseButton);
            Controls.Add(InputTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MD5_App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MD5 Hash Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button BrowseButton;
        private Label ChooseFileLabel;
        private Button InfoButton;
        private Button VerifyButton;
        private Button ExitButton;
        private TextBox HashBox;
        private TextBox SecondHashBox;
        private Label CheckSumValue;
        private Label FileNameLabel;
        private Label OriginalCheckSum;
        private Label NameLabel;
        private Label FileSizeLabel;
        private Label SizeLabel;
    }
}
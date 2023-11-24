namespace MD5hashApp
{
    partial class Form1
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
            label2 = new Label();
            FileNameLabel = new Label();
            label1 = new Label();
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
            // 
            // ChooseFileLabel
            // 
            ChooseFileLabel.AutoSize = true;
            ChooseFileLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseFileLabel.Location = new Point(12, 9);
            ChooseFileLabel.Name = "ChooseFileLabel";
            ChooseFileLabel.Size = new Size(305, 28);
            ChooseFileLabel.TabIndex = 0;
            ChooseFileLabel.Text = "Choose file to compute checksum";
            // 
            // InfoButton
            // 
            InfoButton.Location = new Point(12, 303);
            InfoButton.Name = "InfoButton";
            InfoButton.Size = new Size(94, 29);
            InfoButton.TabIndex = 3;
            InfoButton.Text = "About";
            InfoButton.UseVisualStyleBackColor = true;
            // 
            // VerifyButton
            // 
            VerifyButton.Location = new Point(376, 303);
            VerifyButton.Name = "VerifyButton";
            VerifyButton.Size = new Size(94, 29);
            VerifyButton.TabIndex = 4;
            VerifyButton.Text = "Verify";
            VerifyButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(476, 303);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // HashBox
            // 
            HashBox.Location = new Point(12, 176);
            HashBox.Name = "HashBox";
            HashBox.ReadOnly = true;
            HashBox.Size = new Size(399, 27);
            HashBox.TabIndex = 6;
            // 
            // SecondHashBox
            // 
            SecondHashBox.Location = new Point(12, 237);
            SecondHashBox.Name = "SecondHashBox";
            SecondHashBox.Size = new Size(399, 27);
            SecondHashBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(253, 28);
            label2.TabIndex = 8;
            label2.Text = "Current file checksum value:";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileNameLabel.Location = new Point(12, 106);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(174, 28);
            FileNameLabel.TabIndex = 9;
            FileNameLabel.Text = "File name and size:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(254, 28);
            label1.TabIndex = 10;
            label1.Text = "Original file checksum value";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(label1);
            Controls.Add(FileNameLabel);
            Controls.Add(label2);
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
            Name = "Form1";
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
        private Label label2;
        private Label FileNameLabel;
        private Label label1;
    }
}
using System.Security.Cryptography;
using System.Text;

namespace MD5hashApp
{
    public partial class MD5_App : Form
    {
        public MD5_App()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Choose File";
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.Filter = "Text files (*.TXT)|*.TXT|All Files(*.*)|*.*";
            fileDialog.FilterIndex = 1;
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrEmpty(fileDialog.FileName))
            {
                long size = new FileInfo(fileDialog.FileName).Length;
                InputTextBox.Text = fileDialog.FileName;
                NameLabel.Text = fileDialog.SafeFileName;
                SizeLabel.Text = $"{size} bytes.";

            }
            HashBox.Text = ComputeHash(InputTextBox.Text);
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HashBox.Text))
            {
                MessageBox.Show("Choose file for verification.");
                return;
            }
            if (HashBox.Text == SecondHashBox.Text)
                MessageBox.Show("Checksum is correct.");
            else
                MessageBox.Show("Checksum is incorrect.");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program read selected file, compute hash with MD5 and compares to the hash entered by the user.");
        }
        string ComputeHash(string path)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string text = File.ReadAllText(path);
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }
    }
}
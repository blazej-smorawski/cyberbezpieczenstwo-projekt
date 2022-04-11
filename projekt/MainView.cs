namespace projekt
{
    public partial class MainView : Form
    {
        string inputContent;
        string outputContent;

        public MainView()
        {
            InitializeComponent();
            inputContent = string.Empty;
            outputContent = string.Empty;
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();

                    using StreamReader reader = new StreamReader(fileStream);
                    inputContent = reader.ReadToEnd();
                }
            }

            plainText.Text = inputContent;

            //var formPopup = new Form2();
            //formPopup.Show(this);
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            byte[] plain = System.Text.Encoding.ASCII.GetBytes(inputContent);

            Encryptor encryptor = new TestEncryptor();
            byte[] encrypted = encryptor.encrypt(plain);
  
            outputContent = System.Text.Encoding.ASCII.GetString(encrypted, 0, encrypted.Length);
            encryptedText.Text = outputContent;
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
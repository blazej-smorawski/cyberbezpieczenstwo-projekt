namespace projekt
{
    public partial class MainView : Form
    {
        // List of all cryptographic algorithms available
        List<Crypto> cryptos = new List<Crypto> {new TestCrypto()};

        public MainView()
        {
            InitializeComponent();
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputText.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void saveOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, outputText.Text);
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            byte[] input = System.Text.Encoding.ASCII.GetBytes(inputText.Text);

            Crypto crypto = (Crypto)algorithmDropdown.SelectedValue;
            byte[] encrypted = crypto.encrypt(input);
  
            outputText.Text = System.Text.Encoding.ASCII.GetString(encrypted, 0, encrypted.Length);
        }
        private void decryptButton_Click(object sender, EventArgs e)
        {
            byte[] input = System.Text.Encoding.ASCII.GetBytes(inputText.Text);

            Crypto crypto = (Crypto)algorithmDropdown.SelectedValue;
            byte[] decrypted = crypto.decrypt(input);

            outputText.Text = System.Text.Encoding.ASCII.GetString(decrypted, 0, decrypted.Length);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            // Bindings for the dropdown list, we map algorithms to their names.
            Dictionary<string, Crypto> source = 
                cryptos.Zip(cryptos, (k, v) => new { k.name, v }).ToDictionary(x => x.name, x => x.v);
            bindingSource.DataSource = source;
            algorithmDropdown.DataSource = bindingSource;
            algorithmDropdown.DisplayMember = "Key";
            algorithmDropdown.ValueMember = "Value";
        }
    }
}
using System.Text;
using System.Text.RegularExpressions;

namespace projekt
{
    public partial class MainView : Form
    {
        // List of all cryptographic algorithms available
        List<Crypto> cryptos = new List<Crypto> {new CBCCrypto()};
        byte[] inputData;
        byte[] outputData;

        Encoding ascii = Encoding.ASCII;
        Encoding unicode = Encoding.Unicode;

        public MainView()
        {
            InitializeComponent();
            inputData = new byte[32];
            outputData = new byte[32];
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputData = File.ReadAllBytes(openFileDialog.FileName);
                    inputText.Text = BitConverter.ToString(inputData);
                }
            }
        }

        private void saveOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, outputData);
                }
            }
        }

        private void displayNewOutput(string newText)
        {
            string oldText = outputText.Text;
            outputText.Text = newText;
            outputText.SelectionBackColor = Color.Red;
            for (int i = 0; i < newText.Length; i++)
            {
                if (i >= oldText.Length || newText[i] != oldText[i])
                {
                    outputText.Select(i, 1);
                    outputText.SelectionBackColor = Color.Red;
                }
            }
        }

        private void displayNewInput(string newText)
        {
            string oldText = inputText.Text;
            inputText.Text = newText;
            inputText.SelectionBackColor = Color.Red;
            for (int i = 0; i < newText.Length; i++)
            {
                if (i >= oldText.Length || newText[i] != oldText[i])
                {
                    inputText.Select(i, 1);
                    inputText.SelectionBackColor = Color.Red;
                }
            }
        }

        private byte[] keyModifier(byte[] key)
        {
            byte[] modified = new byte[16];
            
            if(key.Length != 16)
            {
                for(int i = 0; i < modified.Length; i++)
                {
                    if(i < key.Length)
                    {
                        modified[i] = key[i];
                    }
                    else
                    {
                        modified[i] = 0;
                    }
                }
            }
            return modified;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            byte[] input = inputData;
            byte[] key = System.Text.Encoding.ASCII.GetBytes(keyBox.Text);
            key = keyModifier(key);
            //byte[] iv = System.Text.Encoding.ASCII.GetBytes(ivBox.Text);

            Crypto crypto = (Crypto)algorithmDropdown.SelectedValue;
            outputData = crypto.encrypt(input, key);

            displayNewOutput(BitConverter.ToString(outputData));
        }
        private void decryptButton_Click(object sender, EventArgs e)
        {
            // gets encrypted data from the left window
            //byte[] input = inputData;
            byte[] input = inputData;
            byte[] key = System.Text.Encoding.Latin1.GetBytes(keyBox.Text);
            key = keyModifier(key);
            //byte[] iv = System.Text.Encoding.Latin1.GetBytes(ivBox.Text);

            Crypto crypto = (Crypto)algorithmDropdown.SelectedValue;
            outputData = crypto.decrypt(input, key);

            displayNewOutput(BitConverter.ToString(outputData));
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

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            // TODO: remove it in ascii mode
            //inputText.Text = Regex.Replace(inputText.Text, "[^a-fA-F0-9-]", "");
            try
            {
                byte[] converted = Array.ConvertAll(inputText.Text.Split('-'), s => Convert.ToByte(s, 16));
                inputData = converted;
                statusLabel.Text = "Successfully converted input data into bytes";
            }
            catch (Exception)
            {
                statusLabel.Text = "Failed to convert input data into bytes";
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
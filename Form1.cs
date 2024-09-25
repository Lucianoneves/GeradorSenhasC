

namespace geradorSenhasC
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            int length = (int)numPasswordLength.Value;
            bool includeUppercase = chkUppercase.Checked;
            bool includeLowercase = chkLowercase.Checked;
            bool includeNumbers = chKNumbers.Checked;
            bool includeSymbols = chKSymbols.Checked;

            GeradorSenhas generator = new GeradorSenhas(length, includeUppercase, includeLowercase, includeNumbers, includeSymbols);

            txtPassword.Text = generator.GeneratePassword();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Senha copiada para a área de transferência!");

            }
        }
    }
}

using System.Windows.Forms;

namespace SmsSender
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, System.EventArgs e)
        {
            txtComPort.Text = Properties.Settings.Default.comPport;
        }

        private void butCloseSettings_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void butSaveSettings_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.comPport = txtComPort.Text;
            Properties.Settings.Default.Save();
            this.Visible = false;
            MessageBox.Show("Перезагрузите приложение для того, чтобы настройки вступили в силу!");
            this.Close();
        }
    }
}

using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Utils;

namespace WinForms.Examples
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            comboBoxProgressBarStyle.SelectedIndex = 0;
            Utils.Control.Properties.SetText.Sync(labelValue, $"{progressBar.Value} %");
        }

        private void buttonTaskRun_Click(object sender, System.EventArgs e)
        {
            Task.Run(StartProgress);
        }

        private void comboBoxProgressBarStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBoxProgressBarStyle.SelectedIndex)
            {
                case 1:
                    progressBar.SetState(2);
                    break;
                case 2:
                    progressBar.SetState(3);
                    break;
                default:
                    progressBar.SetState(1);
                    break;
            }
        }

        private void StartProgress()
        {
            Utils.ProgressBar.Properties.SetValue.Sync(progressBar, 0);
            Utils.Control.Properties.SetText.Sync(labelValue, $"{progressBar.Value} %");
            while (progressBar.Value < 100)
            {
                Utils.ProgressBar.Properties.SetValue.Sync(progressBar, progressBar.Value + 1, 100);
                Utils.Control.Properties.SetText.Sync(labelValue, $"{progressBar.Value} %");
                System.Threading.Thread.Sleep(100);
            }
            Utils.Control.Properties.SetText.Sync(labelValue, $"{progressBar.Value} %");
        }

        private void buttonStartProgress_Click(object sender, System.EventArgs e)
        {
            StartProgress();
        }
    }
}

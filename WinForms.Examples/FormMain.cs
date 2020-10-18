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
            InvokeControl.SetText(labelValue, $"{progressBar.Value} %");
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
            InvokeProgressBar.SetValue(progressBar, 0);
            InvokeControl.SetText(labelValue, $"{progressBar.Value} %");
            while (progressBar.Value < 100)
            {
                InvokeProgressBar.SetValue(progressBar, progressBar.Value + 1);
                InvokeControl.SetText(labelValue, $"{progressBar.Value} %");
                System.Threading.Thread.Sleep(100);
            }
            InvokeControl.SetText(labelValue, $"{progressBar.Value} %");
        }

        private void buttonStartProgress_Click(object sender, System.EventArgs e)
        {
            StartProgress();
        }
    }
}

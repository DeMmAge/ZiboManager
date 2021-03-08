using System;
using System.IO;
using System.Windows.Forms;
using ZiboManager.Properties;

namespace ZiboManager
{
    public partial class FormMain : Form
    {
        private string ziboPath;

        private FormFolderSelection formSelection = new FormFolderSelection();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.FirstLaunch || !ContentValidator.ValidateAircraft(Settings.Default.ZiboPath))
            {
                ShowSelectPathForm();
            }

            ziboPath = Settings.Default.ZiboPath;
            TryFillAircraftInformation();
        }

        private void ShowSelectPathForm()
        {
            formSelection.ShowDialog();
        }

        private void TryFillAircraftInformation()
        {
            try
            {
                string version = File.ReadAllText(ziboPath + "version.txt");
                labelVersion.Text = $"Version: {version}";
                labelPath.Text = $"Path:\n{ziboPath}";

                if (Directory.Exists(Settings.Default.XplanePath + @"\Resources\plugins\AviTab"))
                {
                    buttonAviatab.Enabled = false;
                    buttonAviatab.Text = "Installed";
                } else
                {
                    InstallAviatab();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                ShowSelectPathForm();
            }
        }

        private void InstallAviatab()
        {

        }

        private void reselectPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSelectPathForm();
        }
    }
}

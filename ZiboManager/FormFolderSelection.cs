using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using ZiboManager.Properties;

namespace ZiboManager
{
    public partial class FormFolderSelection : Form
    {

        private WebClient webClient = new WebClient();
        private CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog() { IsFolderPicker = true };

        private volatile bool downloadCompleted = false;

        public FormFolderSelection()
        {
            InitializeComponent();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadCompleted);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(OnDownloadProgressChanged);
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result != CommonFileDialogResult.Ok)
            {
                return;
            }

            string path = folderBrowserDialog.FileName + "\\";
            if (ContentValidator.ValidateAircraft(path))
            {
                string xplanePath = path;

                while (!xplanePath.EndsWith("X-Plane 11\\"))
                {
                    xplanePath = Path.GetFullPath(Path.Combine(xplanePath, @"..\"));
                }

                Settings.Default.ZiboPath = path;
                Settings.Default.XplanePath = xplanePath;
                Settings.Default.FirstLaunch = false;
                Settings.Default.Save();

                MessageBox.Show("Zibo founded", "Zibo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Zibo not founded in specified folder");
                //AskZiboInstallation();
            }
        }

        private void AskZiboInstallation()
        {
            var installConfirm = MessageBox.Show("Zibo not founded, want to install it?", "Zibo install", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (installConfirm == DialogResult.Yes)
            {
                StartDownload();
            }
        }

        private void StartDownload()
        {
            webClient.DownloadFileAsync(new Uri("https://doc-0k-b0-docs.googleusercontent.com/docs/securesc/inkurslato4p8dtdlkidhu1mtiqeoe1g/clqobolig7nqq3hijlhivldmkggoi7cs/1615074750000/10853509970596282205/11000472171091328256/1DJocBmiFhbnaFu7Uw7XSI6sQXlpdIC7g?e=download&authuser=0"),
                "zibo.zip");
            progressBar.Show();
            labelDownloading.Show();
        }

        private void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled");
                progressBar.Hide();
                labelDownloading.Hide();
            }
            else
            {
                downloadCompleted = true;
                MessageBox.Show("Download completed!");
                progressBar.Hide();
                labelDownloading.Hide();
            }
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void radioButtonAlreadyInstalled_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                labelPath.Text = "Specify your Zibo directory in Aircraft folder:";
            }
            else
            {
                labelPath.Text = "Specify your X-Plane base folder:";
            }
        }
    }
}

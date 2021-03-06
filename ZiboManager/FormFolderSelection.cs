using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiboManager
{
    public partial class FormFolderSelection : Form
    {
        public FormFolderSelection()
        {
            InitializeComponent();
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }
    }
}

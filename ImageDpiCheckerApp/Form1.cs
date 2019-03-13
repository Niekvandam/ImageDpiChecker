using System;
using System.Windows.Forms;

namespace ImageDpiCheckerApp
{
    public partial class DpiChecker : Form
    {
        public DpiChecker()
        {
            InitializeComponent();
            bScanFolder.Enabled = false;
        }

        private void bOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFolder.Text = fbd.SelectedPath.ToString();
                CheckEnableScanButton();
            }
        }

        private void filterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEnableScanButton();
        }

        private void CheckEnableScanButton()
        {
            if (filterListBox.CheckedItems.Count > 0 && selectedFolder.Text != string.Empty)
            {
                bScanFolder.Enabled = true;
            } else
            {
                bScanFolder.Enabled = false;
            }
        }
    }
}

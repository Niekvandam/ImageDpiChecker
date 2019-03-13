using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ImageDpiCheckerApp
{
    public partial class ImageChecker : Form
    {
        public string[] filters;

        public ImageChecker()
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
            if (filterListBox.CheckedItems.Count > 0 && selectedFolder.Text != string.Empty && numTargetDPI.Value > 0)
            {
                bScanFolder.Enabled = true;
            } else
            {
                bScanFolder.Enabled = false;
            }
        }

        private void bScanFolder_Click(object sender, EventArgs e)
        {
        }

        private void numTargetDPI_ValueChanged(object sender, EventArgs e)
        {
            CheckEnableScanButton();
        }
    }
}

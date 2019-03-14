using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImageDpiCheckerApp
{
    public partial class DpiChecker : Form
    {
        public DpiChecker()
        {
            InitializeComponent();
            bScanFolder.Enabled = false;
            numTargetDPI.Maximum = decimal.MaxValue;
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
            }
            else
            {
                bScanFolder.Enabled = false;
            }
        }

        private void bScanFolder_Click(object sender, EventArgs e)
        {
            List<string> filters = new List<string>();
            foreach (object itemChecked in filterListBox.CheckedItems)
            {
                filters.Add(itemChecked.ToString());
            }
            BindDpiDataGrid(filters);
        }

        private void BindDpiDataGrid(List<string> filters)
        {
            var filteredFiles = new List<Tuple<string, string, string, bool>>();
            foreach (var loopedFiles in ImageChecker.GetFilteredFiles(selectedFolder.Text, filters))
            {
                if(Int32.TryParse(loopedFiles.Item3, out int convertedDpi))
                    if (convertedDpi < Convert.ToDouble(numTargetDPI.Value))
                    {
                        filteredFiles.Add(loopedFiles);
                    }
            }

            dpiDataGrid.DataSource = filteredFiles;
            dpiDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dpiDataGrid.Columns[0].HeaderText = "File Path";
            dpiDataGrid.Columns[1].HeaderText = "File Extension";
            dpiDataGrid.Columns[2].HeaderText = "DPI";
            dpiDataGrid.Columns[3].HeaderText = "Is Image";
        }

        private void numTargetDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnableScanButton();
        }
    }
}

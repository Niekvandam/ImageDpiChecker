using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDpiCheckerApp
{
    public partial class DpiChecker : Form
    {
        public bool checkDpi;

        public DpiChecker()
        {
            InitializeComponent();
            bScanFolder.Enabled = false;
            numTargetDPI.Maximum = decimal.MaxValue;
            numTargetDPI.Value = 300;
            filterListBox.SetItemChecked(0, true);
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

        private bool CheckEnableScanButton()
        {
            if (filterListBox.CheckedItems.Count > 0 && selectedFolder.Text != string.Empty && Directory.Exists(selectedFolder.Text) && numTargetDPI.Value > 0)
            {
                bScanFolder.Enabled = true;
                return true;
            }
            else
            {
                bScanFolder.Enabled = false;
                return false;
            }
        }

        private void BindDpiDataGrid(List<string> filters)
        {
            ImageChecker ch = new ImageChecker();
            dpiDataGrid.DataSource = null;
            dpiDataGrid.Rows.Clear();
            dpiDataGrid.Refresh();
            var filteredFiles = new List<Tuple<string, string, string, bool, string>>();
            Parallel.Invoke(() => { var allFiles = ch.GetFilteredFiles(selectedFolder.Text, filters); });
            foreach (var loopedFiles in ch.GetFilteredFiles(selectedFolder.Text, filters))
            {
                if (checkDpi)
                {
                    if (Int32.TryParse(loopedFiles.Item3, out int convertedDpi))
                        if (convertedDpi < Convert.ToDouble(numTargetDPI.Value))
                        {
                            filteredFiles.Add(loopedFiles);
                        }
                }
                else
                {
                    filteredFiles.Add(loopedFiles);
                }
            }
            dpiDataGrid.DataSource = filteredFiles;
            dpiDataGrid.Columns[0].HeaderText = "File Path";
            dpiDataGrid.Columns[1].HeaderText = "File Extension";
            dpiDataGrid.Columns[2].HeaderText = "DPI";
            dpiDataGrid.Columns[3].HeaderText = "Is Image";
            dpiDataGrid.Columns[4].HeaderText = "Scanner";
            amountFilesFound.Text = String.Format("Found {0} files in :", filteredFiles.Count, selectedFolder.Text);
            hrefToFolder.Text = selectedFolder.Text;
        }

        private void numTargetDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckEnableScanButton();
        }


        /// <summary>
        /// Als we handmatig een path invoeren dan controleren we wel even of de map bestaat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectedFolder_TextChanged(object sender, EventArgs e)
        {
            CheckEnableScanButton();
        }

        /* Als we dubbelklikken op een geselecteerde regel dan openen we dat bestand met behulp van het gekoppelde programma.
        ** explorer doet dat standaard voor ons dus zetten we het pad en bestandsnaam als parameter achter explorer.exe
        ** Deze staat standaard in het zoekpad dus doen wat dat lekker quick and dirty */
        private void dpiDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                OpenExplorer(Convert.ToString(selectedFolder.Text) + "\\" + Convert.ToString(dpiDataGrid[e.ColumnIndex, e.RowIndex].Value));
            }
        }

        /// <summary>
        /// Als we dubbelklikken op de getoonde directorie openen we de directory in de explere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hrefToFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenExplorer(Convert.ToString(selectedFolder.Text));
        }

        private void ignoreDpi_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                checkDpi = false;
                numTargetDPI.Enabled = false;
            }
            else
            {
                checkDpi = true;
                numTargetDPI.Enabled = true;
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

        public void OpenExplorer(string targetPath)
        {
            string cmd = "explorer.exe";
            Process.Start(cmd, targetPath);
        }
    }
}

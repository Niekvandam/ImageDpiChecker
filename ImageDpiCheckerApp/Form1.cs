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

        private void CheckEnableScanButton()
        {
            if (filterListBox.CheckedItems.Count > 0 && selectedFolder.Text != string.Empty && Directory.Exists(selectedFolder.Text) && numTargetDPI.Value > 0)
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
            ImageChecker ch = new ImageChecker();
            dpiDataGrid.DataSource = null;
            dpiDataGrid.Rows.Clear();
            dpiDataGrid.Refresh();
            var filteredFiles = new List<Tuple<string, string, string, bool, string>>();
            Parallel.Invoke(() => { var allFiles = ch.GetFilteredFiles(selectedFolder.Text, filters); });
            foreach (var loopedFiles in ch.GetFilteredFiles(selectedFolder.Text, filters))
            {
                if(Int32.TryParse(loopedFiles.Item3, out int convertedDpi))
                    if (convertedDpi < Convert.ToDouble(numTargetDPI.Value))
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

        /* Als we dubbelklikken op een geselecteerde regel dan openen we dat bestand met behulp van het gekoppelde programma.
        ** explorer doet dat standaard voor ons dus zetten we het pad en bestandsnaam als parameter achter explorer.exe
        ** Deze staat standaard in het zoekpad dus doen wat dat lekker quick and dirty */
        private void dpiDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string cmd = "explorer.exe";
            string ShowFolder = Convert.ToString(selectedFolder.Text) + "\\" + Convert.ToString(dpiDataGrid[e.ColumnIndex, e.RowIndex].Value);
                       
           // Console.WriteLine(folder);
            if (e.ColumnIndex == 0)
            {
                Process.Start(cmd, ShowFolder);
            }
        }

        private void selectedFolder_TextChanged(object sender, EventArgs e)
        {
           CheckEnableScanButton();
        }
    }
}

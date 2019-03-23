using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDpiCheckerApp
{
    public partial class DpiChecker : Form
    {
        private bool sortDirection;
        private int previousIndex;
        public bool checkDpi = true;

        public DpiChecker()
        {
            InitializeComponent();
            bScanFolder.Enabled = false;
            numTargetDPI.Maximum = decimal.MaxValue;
            numTargetDPI.Value = 300;
            labelScanning.Text = "Niek van Dam - Contentscanner 2019©";
            labelScanning.Visible = true;
            filterListBox.SetItemChecked(0, true);
            dpiDataGrid.AutoGenerateColumns = true;
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
            var filteredFiles = new List<ScannedFile>();
           // var allFiles = new List<Tuple<string, string, string, bool, string>>();

            foreach (var loopedFiles in ch.GetFilteredFiles(selectedFolder.Text, filters))
            {
                if (checkDpi)
                {
                    if (loopedFiles.IsImage)
                    {
                       // if (float.TryParse(loopedFiles.Dpi, out float convertedDpi))
                       // {
                            if (loopedFiles.Dpi < numTargetDPI.Value)
                            {
                                filteredFiles.Add(loopedFiles);
                            }
                        //}
                    }
                }
                else
                {
                    filteredFiles.Add(loopedFiles);
                }
            }
            dpiDataGrid.DataSource =  filteredFiles;

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
            //if (e.KeyCode == Keys.Enter) {
            //    bScanFolder_Click(sender, new EventArgs());
                
            //}
                
        }

        /* Als we dubbelklikken op een geselecteerde regel dan openen we dat bestand met behulp van het gekoppelde programma.
        ** explorer doet dat standaard voor ons dus zetten we het pad en bestandsnaam als parameter achter explorer.exe
        ** Deze staat standaard in het zoekpad dus doen wat dat lekker quick and dirty */
        private void dpiDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                OpenExplorer(Convert.ToString(dpiDataGrid[0, e.RowIndex].Value));
            }
           
        }

      
     
        private void ignoreDpi_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
            {
                checkDpi = false;
                numTargetDPI.Enabled = false;
                targetDPI.ForeColor = Color.Gray;

            }
            else
            {
                checkDpi = true;
                numTargetDPI.Enabled = true;
                targetDPI.ForeColor = Color.Black;
            }
        }

        private void bScanFolder_Click(object sender, EventArgs e)
        {
            labelScanning.Text = "Scanning directory contents. This coud take a while. Please be patient!";
            labelScanning.Visible = true;
            labelScanning.Refresh();
            List<string> filters = new List<string>();
            foreach (object itemChecked in filterListBox.CheckedItems)
            {
                filters.Add(itemChecked.ToString());
            }
            BindDpiDataGrid(filters);
            labelScanning.Visible = false;
            labelScanning.Refresh();

        }

        public void OpenExplorer(string targetPath)
        {
            string cmd = "explorer.exe";
            string filePath = "\"" + targetPath + "\"";
            Process.Start(cmd, filePath);
        }

        private void hrefToFolder_MouseClick(object sender, MouseEventArgs e)
        {
            OpenExplorer(Convert.ToString(selectedFolder.Text));
        }

        /// <summary>
        /// When we press right mousebutton in datagrid there will be a info window if the file is a pdf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpiDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // obsolete
           /*
            if (e.RowIndex >= 0 && Convert.ToString(dpiDataGrid[2, e.RowIndex].Value).ToLower() == ".pdf")
            { 
                if (e.Button == MouseButtons.Right)
                {
                    dpiDataGrid.CurrentCell = dpiDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string FileName = "Hmmmm";
                    
                    // if (e.ColumnIndex == 0)
                    // {
                    FileName = (Convert.ToString(selectedFolder.Text) + "\\" + Convert.ToString(dpiDataGrid[1, e.RowIndex].Value));
                    // }
                    PopupForm popup = new PopupForm(FileName,  Convert.ToString(dpiDataGrid[3, e.RowIndex].Value));

                    DialogResult dialogresult = popup.ShowDialog();


                    popup.Dispose();


                }
            }*/
        }

        private void DpiChecker_Load(object sender, EventArgs e)
        {

        }

        private void selectedFolder_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && bScanFolder.Enabled)
            {

                bScanFolder_Click(sender, new EventArgs());
            }
        }

        public List<ScannedFile> SortData(List<ScannedFile> list, string column, bool ascending)
        {
            return ascending ?
                list.OrderBy(_ => _.GetType().GetProperty(column).GetValue(_)).ToList() :
                list.OrderByDescending(_ => _.GetType().GetProperty(column).GetValue(_)).ToList();
        }

        private void dpiDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == previousIndex)
                sortDirection ^= true;

            dpiDataGrid.DataSource = dpiDataGrid.DataSource = SortData(
        (List<ScannedFile>)dpiDataGrid.DataSource, dpiDataGrid.Columns[e.ColumnIndex].Name, sortDirection);

            previousIndex = e.ColumnIndex;
        }
    }
}

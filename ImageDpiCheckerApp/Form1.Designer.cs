using System;

namespace ImageDpiCheckerApp
{
    partial class DpiChecker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bOpenFolder = new System.Windows.Forms.Button();
            this.selectedFolder = new System.Windows.Forms.TextBox();
            this.filterListBox = new System.Windows.Forms.CheckedListBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.dpiDataGrid = new System.Windows.Forms.DataGridView();
            this.bScanFolder = new System.Windows.Forms.Button();
            this.numTargetDPI = new System.Windows.Forms.NumericUpDown();
            this.targetDPI = new System.Windows.Forms.Label();
            this.amountFilesFound = new System.Windows.Forms.Label();
            this.hrefToFolder = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ignoreDpi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelException = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dpiDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetDPI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOpenFolder
            // 
            this.bOpenFolder.Location = new System.Drawing.Point(316, 20);
            this.bOpenFolder.Name = "bOpenFolder";
            this.bOpenFolder.Size = new System.Drawing.Size(51, 20);
            this.bOpenFolder.TabIndex = 0;
            this.bOpenFolder.Text = "Browse";
            this.bOpenFolder.UseVisualStyleBackColor = true;
            this.bOpenFolder.Click += new System.EventHandler(this.bOpenFolder_Click);
            // 
            // selectedFolder
            // 
            this.selectedFolder.AcceptsReturn = true;
            this.selectedFolder.Location = new System.Drawing.Point(73, 20);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Size = new System.Drawing.Size(237, 20);
            this.selectedFolder.TabIndex = 1;
            this.selectedFolder.TextChanged += new System.EventHandler(this.selectedFolder_TextChanged);
            // 
            // filterListBox
            // 
            this.filterListBox.CheckOnClick = true;
            this.filterListBox.FormattingEnabled = true;
            this.filterListBox.Items.AddRange(new object[] {
            "Pdf",
            "Tiff",
            "Jpg",
            "Png"});
            this.filterListBox.Location = new System.Drawing.Point(372, 33);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.Size = new System.Drawing.Size(137, 64);
            this.filterListBox.TabIndex = 2;
            this.filterListBox.SelectedIndexChanged += new System.EventHandler(this.filterListBox_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(373, 16);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(140, 13);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Select file extensions to filter";
            // 
            // dpiDataGrid
            // 
            this.dpiDataGrid.AllowUserToAddRows = false;
            this.dpiDataGrid.AllowUserToDeleteRows = false;
            this.dpiDataGrid.AllowUserToResizeRows = false;
            this.dpiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dpiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dpiDataGrid.Location = new System.Drawing.Point(6, 19);
            this.dpiDataGrid.Name = "dpiDataGrid";
            this.dpiDataGrid.ReadOnly = true;
            this.dpiDataGrid.Size = new System.Drawing.Size(505, 212);
            this.dpiDataGrid.TabIndex = 4;
            this.dpiDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dpiDataGrid_CellContentDoubleClick);
            // 
            // bScanFolder
            // 
            this.bScanFolder.Location = new System.Drawing.Point(12, 118);
            this.bScanFolder.Name = "bScanFolder";
            this.bScanFolder.Size = new System.Drawing.Size(75, 23);
            this.bScanFolder.TabIndex = 5;
            this.bScanFolder.Text = "Scan Folder";
            this.bScanFolder.UseVisualStyleBackColor = true;
            this.bScanFolder.Click += new System.EventHandler(this.bScanFolder_Click);
            // 
            // numTargetDPI
            // 
            this.numTargetDPI.Location = new System.Drawing.Point(119, 67);
            this.numTargetDPI.Name = "numTargetDPI";
            this.numTargetDPI.Size = new System.Drawing.Size(75, 20);
            this.numTargetDPI.TabIndex = 6;
            this.numTargetDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTargetDPI_KeyPress);
            // 
            // targetDPI
            // 
            this.targetDPI.AutoSize = true;
            this.targetDPI.Location = new System.Drawing.Point(6, 71);
            this.targetDPI.Name = "targetDPI";
            this.targetDPI.Size = new System.Drawing.Size(108, 13);
            this.targetDPI.TabIndex = 7;
            this.targetDPI.Text = "Maximum dpi to show";
            // 
            // amountFilesFound
            // 
            this.amountFilesFound.AutoSize = true;
            this.amountFilesFound.Location = new System.Drawing.Point(154, 128);
            this.amountFilesFound.Name = "amountFilesFound";
            this.amountFilesFound.Size = new System.Drawing.Size(0, 13);
            this.amountFilesFound.TabIndex = 8;
            // 
            // hrefToFolder
            // 
            this.hrefToFolder.AutoSize = true;
            this.hrefToFolder.Location = new System.Drawing.Point(264, 128);
            this.hrefToFolder.Name = "hrefToFolder";
            this.hrefToFolder.Size = new System.Drawing.Size(0, 13);
            this.hrefToFolder.TabIndex = 9;
            this.hrefToFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hrefToFolder_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder to scan";
            // 
            // ignoreDpi
            // 
            this.ignoreDpi.AutoSize = true;
            this.ignoreDpi.Location = new System.Drawing.Point(9, 51);
            this.ignoreDpi.Name = "ignoreDpi";
            this.ignoreDpi.Size = new System.Drawing.Size(107, 17);
            this.ignoreDpi.TabIndex = 11;
            this.ignoreDpi.Text = "Ignore target DPI";
            this.ignoreDpi.UseVisualStyleBackColor = true;
            this.ignoreDpi.CheckedChanged += new System.EventHandler(this.ignoreDpi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ignoreDpi);
            this.groupBox1.Controls.Add(this.selectedFolder);
            this.groupBox1.Controls.Add(this.numTargetDPI);
            this.groupBox1.Controls.Add(this.targetDPI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bOpenFolder);
            this.groupBox1.Controls.Add(this.filterListBox);
            this.groupBox1.Controls.Add(this.filterLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 103);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Folder Parameter Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelException);
            this.groupBox2.Controls.Add(this.dpiDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 244);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelException.Location = new System.Drawing.Point(83, 107);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(368, 15);
            this.labelException.TabIndex = 14;
            this.labelException.Text = "ERROR IN SEARCH - COULD NOT FILL ARRAY DUE TO RIGHTS ISSUE";
            this.labelException.Visible = false;
            // 
            // DpiChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 403);
            this.Controls.Add(this.hrefToFolder);
            this.Controls.Add(this.amountFilesFound);
            this.Controls.Add(this.bScanFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DpiChecker";
            this.Text = "DpiChecker";
            ((System.ComponentModel.ISupportInitialize)(this.dpiDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetDPI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 

        #endregion

        private System.Windows.Forms.Button bOpenFolder;
        private System.Windows.Forms.TextBox selectedFolder;
        private System.Windows.Forms.CheckedListBox filterListBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.DataGridView dpiDataGrid;
        private System.Windows.Forms.Button bScanFolder;
        private System.Windows.Forms.NumericUpDown numTargetDPI;
        private System.Windows.Forms.Label targetDPI;
        private System.Windows.Forms.Label amountFilesFound;
        private System.Windows.Forms.LinkLabel hrefToFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ignoreDpi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelException;
    }
}


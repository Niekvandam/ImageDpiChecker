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
            ((System.ComponentModel.ISupportInitialize)(this.dpiDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetDPI)).BeginInit();
            this.SuspendLayout();
            // 
            // bOpenFolder
            // 
            this.bOpenFolder.Location = new System.Drawing.Point(12, 22);
            this.bOpenFolder.Name = "bOpenFolder";
            this.bOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.bOpenFolder.TabIndex = 0;
            this.bOpenFolder.Text = "Open Folder";
            this.bOpenFolder.UseVisualStyleBackColor = true;
            this.bOpenFolder.Click += new System.EventHandler(this.bOpenFolder_Click);
            // 
            // selectedFolder
            // 
            this.selectedFolder.Location = new System.Drawing.Point(12, 51);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.ReadOnly = true;
            this.selectedFolder.Size = new System.Drawing.Size(265, 20);
            this.selectedFolder.TabIndex = 1;
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
            this.filterListBox.Location = new System.Drawing.Point(308, 22);
            this.filterListBox.Name = "filterListBox";
            this.filterListBox.Size = new System.Drawing.Size(137, 64);
            this.filterListBox.TabIndex = 2;
            this.filterListBox.SelectedIndexChanged += new System.EventHandler(this.filterListBox_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(305, 6);
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
            this.dpiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dpiDataGrid.Location = new System.Drawing.Point(12, 152);
            this.dpiDataGrid.Name = "dpiDataGrid";
            this.dpiDataGrid.ReadOnly = true;
            this.dpiDataGrid.Size = new System.Drawing.Size(433, 191);
            this.dpiDataGrid.TabIndex = 4;
            // 
            // bScanFolder
            // 
            this.bScanFolder.Location = new System.Drawing.Point(12, 123);
            this.bScanFolder.Name = "bScanFolder";
            this.bScanFolder.Size = new System.Drawing.Size(75, 23);
            this.bScanFolder.TabIndex = 5;
            this.bScanFolder.Text = "Scan Folder";
            this.bScanFolder.UseVisualStyleBackColor = true;
            this.bScanFolder.Click += new System.EventHandler(this.bScanFolder_Click);
            // 
            // numTargetDPI
            // 
            this.numTargetDPI.Location = new System.Drawing.Point(13, 97);
            this.numTargetDPI.Name = "numTargetDPI";
            this.numTargetDPI.Size = new System.Drawing.Size(120, 20);
            this.numTargetDPI.TabIndex = 6;
            this.numTargetDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTargetDPI_KeyPress);
            // 
            // targetDPI
            // 
            this.targetDPI.AutoSize = true;
            this.targetDPI.Location = new System.Drawing.Point(12, 78);
            this.targetDPI.Name = "targetDPI";
            this.targetDPI.Size = new System.Drawing.Size(59, 13);
            this.targetDPI.TabIndex = 7;
            this.targetDPI.Text = "Target DPI";
            // 
            // DpiChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.targetDPI);
            this.Controls.Add(this.numTargetDPI);
            this.Controls.Add(this.bScanFolder);
            this.Controls.Add(this.dpiDataGrid);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.selectedFolder);
            this.Controls.Add(this.bOpenFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DpiChecker";
            this.Text = "DpiChecker";
            ((System.ComponentModel.ISupportInitialize)(this.dpiDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetDPI)).EndInit();
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
    }
}


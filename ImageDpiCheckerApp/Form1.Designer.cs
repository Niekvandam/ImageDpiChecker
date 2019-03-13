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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bScanFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.dpi,
            this.isImage,
            this.fileType});
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(433, 191);
            this.dataGridView1.TabIndex = 4;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "File Name";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // dpi
            // 
            this.dpi.HeaderText = "Dpi";
            this.dpi.Name = "dpi";
            this.dpi.ReadOnly = true;
            // 
            // isImage
            // 
            this.isImage.HeaderText = "Is image";
            this.isImage.Name = "isImage";
            this.isImage.ReadOnly = true;
            // 
            // fileType
            // 
            this.fileType.HeaderText = "File Type";
            this.fileType.Name = "fileType";
            this.fileType.ReadOnly = true;
            // 
            // bScanFolder
            // 
            this.bScanFolder.Location = new System.Drawing.Point(12, 123);
            this.bScanFolder.Name = "bScanFolder";
            this.bScanFolder.Size = new System.Drawing.Size(75, 23);
            this.bScanFolder.TabIndex = 5;
            this.bScanFolder.Text = "Scan Folder";
            this.bScanFolder.UseVisualStyleBackColor = true;
            // 
            // DpiChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.bScanFolder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterListBox);
            this.Controls.Add(this.selectedFolder);
            this.Controls.Add(this.bOpenFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DpiChecker";
            this.Text = "DpiChecker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpenFolder;
        private System.Windows.Forms.TextBox selectedFolder;
        private System.Windows.Forms.CheckedListBox filterListBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileType;
        private System.Windows.Forms.Button bScanFolder;
    }
}


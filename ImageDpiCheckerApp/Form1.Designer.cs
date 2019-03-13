namespace ImageDpiCheckerApp
{
    partial class Form1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.filterLabel = new System.Windows.Forms.Label();
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
            this.selectedFolder.Size = new System.Drawing.Size(265, 20);
            this.selectedFolder.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Pdf",
            "Tiff",
            "Jpg",
            "Png"});
            this.checkedListBox1.Location = new System.Drawing.Point(315, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(137, 64);
            this.checkedListBox1.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(312, 6);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(140, 13);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Select file extensions to filter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.selectedFolder);
            this.Controls.Add(this.bOpenFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpenFolder;
        private System.Windows.Forms.TextBox selectedFolder;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label filterLabel;
    }
}


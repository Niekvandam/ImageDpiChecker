namespace ImageDpiCheckerApp
{
    partial class PopupForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBox_Maker = new System.Windows.Forms.TextBox();
            this.textBox_Versie = new System.Windows.Forms.TextBox();
            this.textBox_Auteur = new System.Windows.Forms.TextBox();
            this.textBox_Producent = new System.Windows.Forms.TextBox();
            this.Label_Versie = new System.Windows.Forms.Label();
            this.label_Maker = new System.Windows.Forms.Label();
            this.label_auteur = new System.Windows.Forms.Label();
            this.label_Producent = new System.Windows.Forms.Label();
            this.textBox_Creation = new System.Windows.Forms.TextBox();
            this.label_Creation = new System.Windows.Forms.Label();
            this.labelDPI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_File = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(269, 179);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // textBox_Maker
            // 
            this.textBox_Maker.Enabled = false;
            this.textBox_Maker.Location = new System.Drawing.Point(129, 41);
            this.textBox_Maker.Name = "textBox_Maker";
            this.textBox_Maker.Size = new System.Drawing.Size(220, 20);
            this.textBox_Maker.TabIndex = 1;
            // 
            // textBox_Versie
            // 
            this.textBox_Versie.Enabled = false;
            this.textBox_Versie.Location = new System.Drawing.Point(128, 15);
            this.textBox_Versie.Name = "textBox_Versie";
            this.textBox_Versie.Size = new System.Drawing.Size(220, 20);
            this.textBox_Versie.TabIndex = 2;
            // 
            // textBox_Auteur
            // 
            this.textBox_Auteur.Enabled = false;
            this.textBox_Auteur.Location = new System.Drawing.Point(128, 67);
            this.textBox_Auteur.Name = "textBox_Auteur";
            this.textBox_Auteur.Size = new System.Drawing.Size(220, 20);
            this.textBox_Auteur.TabIndex = 3;
            // 
            // textBox_Producent
            // 
            this.textBox_Producent.Enabled = false;
            this.textBox_Producent.Location = new System.Drawing.Point(128, 93);
            this.textBox_Producent.Name = "textBox_Producent";
            this.textBox_Producent.Size = new System.Drawing.Size(220, 20);
            this.textBox_Producent.TabIndex = 4;
            // 
            // Label_Versie
            // 
            this.Label_Versie.AutoSize = true;
            this.Label_Versie.Location = new System.Drawing.Point(9, 22);
            this.Label_Versie.Name = "Label_Versie";
            this.Label_Versie.Size = new System.Drawing.Size(60, 13);
            this.Label_Versie.TabIndex = 5;
            this.Label_Versie.Text = "PDF-Versie";
            // 
            // label_Maker
            // 
            this.label_Maker.AutoSize = true;
            this.label_Maker.Location = new System.Drawing.Point(9, 48);
            this.label_Maker.Name = "label_Maker";
            this.label_Maker.Size = new System.Drawing.Size(37, 13);
            this.label_Maker.TabIndex = 6;
            this.label_Maker.Text = "Maker";
            // 
            // label_auteur
            // 
            this.label_auteur.AutoSize = true;
            this.label_auteur.Location = new System.Drawing.Point(9, 74);
            this.label_auteur.Name = "label_auteur";
            this.label_auteur.Size = new System.Drawing.Size(38, 13);
            this.label_auteur.TabIndex = 7;
            this.label_auteur.Text = "Auteur";
            // 
            // label_Producent
            // 
            this.label_Producent.AutoSize = true;
            this.label_Producent.Location = new System.Drawing.Point(9, 100);
            this.label_Producent.Name = "label_Producent";
            this.label_Producent.Size = new System.Drawing.Size(56, 13);
            this.label_Producent.TabIndex = 8;
            this.label_Producent.Text = "Producent";
            this.label_Producent.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_Creation
            // 
            this.textBox_Creation.Enabled = false;
            this.textBox_Creation.Location = new System.Drawing.Point(128, 119);
            this.textBox_Creation.Name = "textBox_Creation";
            this.textBox_Creation.Size = new System.Drawing.Size(220, 20);
            this.textBox_Creation.TabIndex = 10;
            // 
            // label_Creation
            // 
            this.label_Creation.AutoSize = true;
            this.label_Creation.Location = new System.Drawing.Point(9, 126);
            this.label_Creation.Name = "label_Creation";
            this.label_Creation.Size = new System.Drawing.Size(81, 13);
            this.label_Creation.TabIndex = 11;
            this.label_Creation.Text = "Aanmaakdatum";
            this.label_Creation.Click += new System.EventHandler(this.label_Creation_Click);
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDPI.Location = new System.Drawing.Point(73, 188);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(53, 18);
            this.labelDPI.TabIndex = 12;
            this.labelDPI.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "resolutie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Creation);
            this.groupBox1.Controls.Add(this.textBox_Creation);
            this.groupBox1.Controls.Add(this.label_Producent);
            this.groupBox1.Controls.Add(this.label_auteur);
            this.groupBox1.Controls.Add(this.label_Maker);
            this.groupBox1.Controls.Add(this.Label_Versie);
            this.groupBox1.Controls.Add(this.textBox_Producent);
            this.groupBox1.Controls.Add(this.textBox_Auteur);
            this.groupBox1.Controls.Add(this.textBox_Versie);
            this.groupBox1.Controls.Add(this.textBox_Maker);
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 150);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File info";
            // 
            // label_File
            // 
            this.label_File.AutoSize = true;
            this.label_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_File.Location = new System.Drawing.Point(7, 9);
            this.label_File.Name = "label_File";
            this.label_File.Size = new System.Drawing.Size(41, 13);
            this.label_File.TabIndex = 16;
            this.label_File.Text = "label1";
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(373, 220);
            this.Controls.Add(this.label_File);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.buttonClose);
            this.Name = "PopupForm";
            this.Text = "Fileinfo";
            this.Load += new System.EventHandler(this.PopupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBox_Maker;
        private System.Windows.Forms.TextBox textBox_Versie;
        private System.Windows.Forms.TextBox textBox_Auteur;
        private System.Windows.Forms.TextBox textBox_Producent;
        private System.Windows.Forms.Label Label_Versie;
        private System.Windows.Forms.Label label_Maker;
        private System.Windows.Forms.Label label_auteur;
        private System.Windows.Forms.Label label_Producent;
        private System.Windows.Forms.TextBox textBox_Creation;
        private System.Windows.Forms.Label label_Creation;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_File;
    }
}
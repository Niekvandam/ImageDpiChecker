using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace ImageDpiCheckerApp
{
    public partial class PopupForm : Form
    {
        public PopupForm(string file, string dpi)
        {
            InitializeComponent();
            label_File.Text = file;
            try
            {
                PdfReader reader = new PdfReader(file);
                labelDPI.Text = dpi;
                textBox_Maker.Text = GetPDFFileinfo(reader, "Creator");
                textBox_Versie.Text = "1."+reader.PdfVersion.ToString();
                textBox_Producent.Text = GetPDFFileinfo(reader, "Producer");
                //textBox_Creation.Text = DateTime.ParseExact(reader.Info["CreationDate"], "dd-MM-yyy HH:mm:ss", CultureInfo.InvariantCulture).ToString();
                textBox_Creation.Text = GetPDFFileinfo(reader, "CreationDate");
                textBox_Auteur.Text = GetPDFFileinfo(reader, "Author");

               
            }
            catch (System.Exception e) {

            }
           //reader.close();

        }

    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PopupForm_Load(object sender, EventArgs e)
        {

          
        }

        private void label_Creation_Click(object sender, EventArgs e)
        {

        }

        public string GetPDFFileinfo(PdfReader reader, string item)
        {
            string strValue = "unknown";
            //PdfReader reader = new PdfReader(filePath);
            try
            {
                strValue = reader.Info[item];
                //reader.Info[item];
            }
            catch (System.Exception e)
            {
                return strValue;
            }

            return strValue;
        }
    }
}


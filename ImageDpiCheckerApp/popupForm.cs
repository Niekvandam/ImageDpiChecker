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
                textBox_Maker.Text = reader.Info["Creator"];
                textBox_Versie.Text = "1."+reader.PdfVersion.ToString();
                textBox_Producent.Text = reader.Info["Producer"];
                textBox_Creation.Text = DateTime.ParseExact(reader.Info["CreationDate"], "dd-MM-yyy HH:mm:ss", CultureInfo.InvariantCulture).ToString();
                textBox_Creation.Text = reader.Info["CreationDate"];
                textBox_Auteur.Text = reader.Info["Author"];

               
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
    }
}

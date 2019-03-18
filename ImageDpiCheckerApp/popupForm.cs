using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public PopupForm(string file)
        {
            InitializeComponent();
            label_File.Text = file;
            try
            {
                PdfReader reader = new PdfReader(file);
            
                textBox_Maker.Text = reader.Info["Creator"];
                textBox_Versie.Text = "1."+reader.PdfVersion.ToString();
                textBox_Producent.Text = reader.Info["Producer"];
                textBox_Auteur.Text = reader.Info["Author"];

                textBox_Auteur.Text = reader.Info["CreationDate"];
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

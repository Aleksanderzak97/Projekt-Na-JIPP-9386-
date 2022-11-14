using Projekt_Na_JIPP_9386_finalny.Klasy_Postaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Na_JIPP_9386_finalny
{
    public partial class Opispostaci : Form
    {
        public Opispostaci()
        {
            InitializeComponent();
        }

        private void Opispostaci_Load(object sender, EventArgs e)
        {
            Gracz g1 = new Gracz();
            g1 = ZapisPlików.WczytajGracza();
            labelnickopis.Text = g1.Nazwa;
            labelplecopis.Text = g1.Płeć.ToString();
            labelklasaopis.Text = g1.Klasa.ToString();
            labelzdrowieopis.Text = g1.Zdrowie.ToString();
            labelatakopis.Text = g1.Siła.ToString();
            

            if (this.labelklasaopis.Text == "Wojownik" && this.labelplecopis.Text == "Mężczyzna")
                pictureBoxopisbohater.Image = Properties.Resources.wojownik;
            
            if (this.labelklasaopis.Text == "Wojownik" && this.labelplecopis.Text == "Kobieta")
                pictureBoxopisbohater.Image = Properties.Resources.wojownikkobieta;
            
            if (this.labelklasaopis.Text == "Mag" && this.labelplecopis.Text == "Mężczyzna")
                pictureBoxopisbohater.Image = Properties.Resources.mag;
            
            if (this.labelklasaopis.Text == "Mag" && this.labelplecopis.Text == "Kobieta")
                pictureBoxopisbohater.Image = Properties.Resources.magkobieta;
            
            if (this.labelklasaopis.Text == "Łucznik" && this.labelplecopis.Text == "Mężczyzna")
                pictureBoxopisbohater.Image = Properties.Resources.łucznik;
            
            if (this.labelklasaopis.Text == "Łucznik" && this.labelplecopis.Text == "Kobieta")
                pictureBoxopisbohater.Image = Properties.Resources.archerkobieta;
            
            if (this.labelklasaopis.Text == "Kapłan" && this.labelplecopis.Text == "Mężczyzna")
                pictureBoxopisbohater.Image = Properties.Resources.kapłan;
            
            if (this.labelklasaopis.Text == "Kapłan" && this.labelplecopis.Text == "Kobieta")
                pictureBoxopisbohater.Image = Properties.Resources.pirestkobieta;
            
        }

        private void buttontworzeniepowrot_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm Menuglowne = new MenuForm();
            Menuglowne.Show();
        }
    }
}

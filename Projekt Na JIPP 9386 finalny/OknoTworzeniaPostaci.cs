using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Projekt_Na_JIPP_9386_finalny.Klasy_Postaci;

namespace Projekt_Na_JIPP_9386_finalny
{
    public partial class tworzeniepostaciform : Form
    {
        
        private PictureBox wojownikPicBox;
        private PictureBox wojownikkobietaPicBox;
        private PictureBox magPicBox;
        private PictureBox magkobietaPicBox;
        private PictureBox łucznikPicBox;
        private PictureBox łucznikkobietaPicBox;
        private PictureBox kapłankPicBox;
        private PictureBox kapłankaPicBox;
        public tworzeniepostaciform()
        {
            wojownikPicBox = new PictureBox();
            wojownikPicBox.Image = Properties.Resources.wojownik;
            wojownikPicBox.Width = 250;
            wojownikPicBox.Height = 400;
            wojownikPicBox.BackColor = Color.Transparent;
            wojownikPicBox.Left = 300;
            wojownikPicBox.Top = 20;
            this.Controls.Add(wojownikPicBox);
            wojownikPicBox.Hide();

            wojownikkobietaPicBox = new PictureBox();
            wojownikkobietaPicBox.Image = Properties.Resources.wojownikkobieta;
            wojownikkobietaPicBox.Width = 250;
            wojownikkobietaPicBox.Height = 400;
            wojownikkobietaPicBox.BackColor = Color.Transparent;
            wojownikkobietaPicBox.Left = 300;
            wojownikkobietaPicBox.Top = 20;
            this.Controls.Add(wojownikkobietaPicBox);
            wojownikkobietaPicBox.Hide();

            magPicBox = new PictureBox();
            magPicBox.Image = Properties.Resources.mag;
            magPicBox.Width = 250;
            magPicBox.Height = 400;
            magPicBox.BackColor = Color.Transparent;
            magPicBox.Left = 300;
            magPicBox.Top = 20;
            this.Controls.Add(magPicBox);
            magPicBox.Hide();

            magkobietaPicBox = new PictureBox();
            magkobietaPicBox.Image = Properties.Resources.magkobieta;
            magkobietaPicBox.Width = 250;
            magkobietaPicBox.Height = 400;
            magkobietaPicBox.BackColor = Color.Transparent;
            magkobietaPicBox.Left = 300;
            magkobietaPicBox.Top = 20;
            this.Controls.Add(magkobietaPicBox);
            magkobietaPicBox.Hide();

            łucznikPicBox = new PictureBox();
            łucznikPicBox.Image = Properties.Resources.łucznik;
            łucznikPicBox.Width = 250;
            łucznikPicBox.Height = 400;
            łucznikPicBox.BackColor = Color.Transparent;
            łucznikPicBox.Left = 300;
            łucznikPicBox.Top = 20;
            this.Controls.Add(łucznikPicBox);
            łucznikPicBox.Hide();

            łucznikkobietaPicBox = new PictureBox();
            łucznikkobietaPicBox.Image = Properties.Resources.archerkobieta;
            łucznikkobietaPicBox.Width = 250;
            łucznikkobietaPicBox.Height = 400;
            łucznikkobietaPicBox.BackColor = Color.Transparent;
            łucznikkobietaPicBox.Left = 300;
            łucznikkobietaPicBox.Top = 20;
            this.Controls.Add(łucznikkobietaPicBox);
            łucznikkobietaPicBox.Hide();

            kapłankPicBox = new PictureBox();
            kapłankPicBox.Image = Properties.Resources.kapłan;
            kapłankPicBox.Width = 250;
            kapłankPicBox.Height = 400;
            kapłankPicBox.BackColor = Color.Transparent;
            kapłankPicBox.Left = 300;
            kapłankPicBox.Top = 20;
            this.Controls.Add(kapłankPicBox);
            kapłankPicBox.Hide();

            kapłankaPicBox = new PictureBox();
            kapłankaPicBox.Image = Properties.Resources.pirestkobieta;
            kapłankaPicBox.Width = 250;
            kapłankaPicBox.Height = 400;
            kapłankaPicBox.BackColor = Color.Transparent;
            kapłankaPicBox.Left = 300;
            kapłankaPicBox.Top = 20;
            this.Controls.Add(kapłankaPicBox);
            kapłankaPicBox.Hide();
            InitializeComponent();
        }

        private void tworzeniepostacibutton_Click(object sender, EventArgs e)
        {
           
            
            string nazwa = textBoxnick.Text;
            string nazwap = "Złowrogi Wróg";
            
            if (String.IsNullOrEmpty(textBoxnick.Text) || textBoxnick.Text[0] == ' ')
            {
                MessageBox.Show("Musisz nazwać swojego Bohatera");
                return;
            }

            wPłcie wPłciew = new wPłcie();
            wPłciew = wPłcie.Nieznana;
            if (this.radioButtonmezczyzna.Checked)
                wPłciew = wPłcie.Mężczyzna;
            else if (this.radioButtonkobieta.Checked)
                wPłciew = wPłcie.Kobieta;
            else
            {
                MessageBox.Show("Musisz wybrać płeć.");
                return;
            }
            wPłcie wrogPłec = new wPłcie();
            wrogPłec = wPłcie.Nieznana;

            wKlasy klasyw;
            if (this.comboBoxklasy.Text == "Wojownik")
                klasyw = wKlasy.Wojownik;
            else if (this.comboBoxklasy.Text == "Mag")
                klasyw = wKlasy.Mag;
            else if (this.comboBoxklasy.Text == "Łucznik")
                klasyw = wKlasy.Łucznik;
            else if (this.comboBoxklasy.Text == "Kapłan")
                klasyw = wKlasy.Kapłan;
            else
            {
                MessageBox.Show("Musisz wybrać klase swojej postaci");
                return;
            }
            wKlasy klasawroga = new wKlasy();
            klasawroga = wKlasy.Nieznana;
            
            
            Gracz gracz1 = new Gracz(nazwa, wPłciew, klasyw);
            Przeciwnik przeciwnik1 = new Przeciwnik(nazwap,wrogPłec,klasawroga);

            string output;
            output = String.Format("Stworzyłeś nową postać.\n" + "Twoja nazwa to: {0}\nTwoja płeć to: {1}\n" + "Twoja klasa to: {2}.",
                gracz1.Nazwa, gracz1.Płeć.ToString(), gracz1.Klasa.ToString());
            MessageBox.Show(output, "Udało się");
            ZapisPlików.ZachowajPostac(gracz1);
            ZapisPlików.ZachowajPrzeciwnika(przeciwnik1);
            Dane_Postaci statystyki = new Dane_Postaci();
            statystyki.Show();
            this.Close();



            //Wojownik
            //Mag
            //Łucznik
            //Kapłan
            

            
        }

        private void buttontworzeniepowrot_Click(object sender, EventArgs e)
        {
            MenuForm Menuglowne = new MenuForm();
            Menuglowne.Show();
            this.Hide();
        }

        private void tworzeniepostaciform_Load(object sender, EventArgs e)
        {

        }
        
        private void comboBoxklasy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.comboBoxklasy.Text == "Wojownik" && this.radioButtonmezczyzna.Checked)
                wojownikPicBox.Show();
            if (this.comboBoxklasy.Text != "Wojownik" || !this.radioButtonmezczyzna.Checked)
                wojownikPicBox.Hide();               
            if (this.comboBoxklasy.Text == "Wojownik" && this.radioButtonkobieta.Checked)
                wojownikkobietaPicBox.Show();
            if (this.comboBoxklasy.Text != "Wojownik" || !this.radioButtonkobieta.Checked)
                wojownikkobietaPicBox.Hide();
            if (this.comboBoxklasy.Text == "Mag" && this.radioButtonmezczyzna.Checked)
                magPicBox.Show();
            if (this.comboBoxklasy.Text != "Mag" || !this.radioButtonmezczyzna.Checked)
                magPicBox.Hide();
            if (this.comboBoxklasy.Text == "Mag" && this.radioButtonkobieta.Checked)
                magkobietaPicBox.Show();
            if (this.comboBoxklasy.Text != "Mag" || !this.radioButtonkobieta.Checked)
                magkobietaPicBox.Hide();
            if (this.comboBoxklasy.Text == "Łucznik" && this.radioButtonmezczyzna.Checked)
                łucznikPicBox.Show();
            if (this.comboBoxklasy.Text != "Łucznik" || !this.radioButtonmezczyzna.Checked)
                łucznikPicBox.Hide();
            if (this.comboBoxklasy.Text == "Łucznik" && this.radioButtonkobieta.Checked)
                łucznikkobietaPicBox.Show();
            if (this.comboBoxklasy.Text != "Łucznik" || !this.radioButtonkobieta.Checked)
                łucznikkobietaPicBox.Hide();
            if (this.comboBoxklasy.Text == "Kapłan" && this.radioButtonmezczyzna.Checked)
                kapłankPicBox.Show();
            if (this.comboBoxklasy.Text != "Kapłan" || !this.radioButtonmezczyzna.Checked)
                kapłankPicBox.Hide();
            if (this.comboBoxklasy.Text == "Kapłan" && this.radioButtonkobieta.Checked)
                kapłankaPicBox.Show();
            if (this.comboBoxklasy.Text != "Kapłan" || !this.radioButtonkobieta.Checked)
                kapłankaPicBox.Hide();
           

        }
        
        private void groupBoxplci_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonmezczyzna_CheckedChanged(object sender, EventArgs e)
        {
            if (this.comboBoxklasy.Text == "Wojownik" && this.radioButtonmezczyzna.Checked)
                wojownikPicBox.Show();
            if (this.comboBoxklasy.Text != "Wojownik" || !this.radioButtonmezczyzna.Checked)
                wojownikPicBox.Hide();
            if (this.comboBoxklasy.Text == "Mag" && this.radioButtonmezczyzna.Checked)
                magPicBox.Show();
            if (this.comboBoxklasy.Text != "Mag" || !this.radioButtonmezczyzna.Checked)
                magPicBox.Hide();
            if (this.comboBoxklasy.Text == "Łucznik" && this.radioButtonmezczyzna.Checked)
                łucznikPicBox.Show();
            if (this.comboBoxklasy.Text != "Łucznik" || !this.radioButtonmezczyzna.Checked)
                łucznikPicBox.Hide();
            if (this.comboBoxklasy.Text == "Kapłan" && this.radioButtonmezczyzna.Checked)
                kapłankPicBox.Show();
            if (this.comboBoxklasy.Text != "Kapłan" || !this.radioButtonmezczyzna.Checked)
                kapłankPicBox.Hide();
        }
        
        private void radioButtonkobieta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.comboBoxklasy.Text == "Wojownik" && this.radioButtonkobieta.Checked)
                wojownikkobietaPicBox.Show();
            if (this.comboBoxklasy.Text != "Wojownik" || !this.radioButtonkobieta.Checked)
                wojownikkobietaPicBox.Hide();
            if (this.comboBoxklasy.Text == "Mag" && this.radioButtonkobieta.Checked)
                magkobietaPicBox.Show();
            if (this.comboBoxklasy.Text != "Mag" || !this.radioButtonkobieta.Checked)
                magkobietaPicBox.Hide();
            if (this.comboBoxklasy.Text == "Łucznik" && this.radioButtonkobieta.Checked)
                łucznikkobietaPicBox.Show();
            if (this.comboBoxklasy.Text != "Łucznik" || !this.radioButtonkobieta.Checked)
                łucznikkobietaPicBox.Hide();
            if (this.comboBoxklasy.Text == "Kapłan" && this.radioButtonkobieta.Checked)
                kapłankaPicBox.Show();
            if (this.comboBoxklasy.Text != "Kapłan" || !this.radioButtonkobieta.Checked)
                kapłankaPicBox.Hide();
        }
    }
}

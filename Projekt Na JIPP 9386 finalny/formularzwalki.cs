using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_Na_JIPP_9386_finalny.Klasy_Postaci;

namespace Projekt_Na_JIPP_9386_finalny
{

    public partial class formularzwalki : Form
    {
        
        int t = 0;
        int x = 0;
        int y = 0;
        int atak = 0;
        int atakprzeciwnika;
        Bitmap obrazekmieczbohatera = new Bitmap(Projekt_Na_JIPP_9386_finalny.Properties.Resources.miecz_bohatera);
        Bitmap obrazekmieczprzeciwnika = new Bitmap(Projekt_Na_JIPP_9386_finalny.Properties.Resources.miecz_przeciwnika);
        Gracz g1 = new Gracz();
        Przeciwnik p1 = new Przeciwnik();

        public formularzwalki()
        {
            
            g1 = ZapisPlików.WczytajGracza();
            p1 = ZapisPlików.WczytajPrzeciwnika();
            
            atakprzeciwnika = p1.Siła;
            if (g1.Klasa == wKlasy.Wojownik)
            {
                atak = g1.Siła;
            }
            else if (g1.Klasa == wKlasy.Mag)
            {
                atak = g1.Inteligencja;
            }
            else if (g1.Klasa == wKlasy.Łucznik)
            {
                atak = g1.Zręczność;
            }
            else if (g1.Klasa == wKlasy.Kapłan)
            {
                atak = g1.Inteligencja;
            }


            InitializeComponent();
            
        }

        private void buttonataku_Click(object sender, EventArgs e)
        {

            t++;
            
            
            
            
           
            int zdrowieprzeciwnika = p1.Zdrowie;
            int zdrowiebohatera = g1.Zdrowie;
            //int atakprzeciwnika = p1.Siła;
            int Pozostalezdrowieprzeciwnika;
            int Pozostalezdrowiebohatera;
            
           
            timermiecze.Start();
            
            Pozostalezdrowieprzeciwnika = zdrowieprzeciwnika - atak *t;
            
            

            if (Pozostalezdrowieprzeciwnika <= 0)
            {
                progressBarprzeciwnik.Value = 0;
                MessageBox.Show("Wygrałeś");
                this.Close();
                MenuForm Menuglowne = new MenuForm();
                Menuglowne.Show();
            }
            else
            {
                progressBarprzeciwnik.Value = Pozostalezdrowieprzeciwnika;
            }

            Pozostalezdrowiebohatera = zdrowiebohatera - atakprzeciwnika * t;

            if (Pozostalezdrowiebohatera <= 0)
            {
                progressBarbohater.Value = 0;
                MessageBox.Show("Przegrałeś");
                this.Close();
                MenuForm Menuglowne = new MenuForm();
                Menuglowne.Show();
            }
            else if (progressBarprzeciwnik.Value != 0)
            {
                progressBarbohater.Value = Pozostalezdrowiebohatera;
            }

            Refresh();
            
        }
      
        private void formularzwalki_Load(object sender, EventArgs e)
        {
            Gracz g1 = new Gracz();
            g1 = ZapisPlików.WczytajGracza();
            progressBarbohater.Value = g1.Zdrowie;
            progressBarbohater.Maximum = g1.Zdrowie;
            labelbohaternazwa.Text = g1.Nazwa;
            labelbohaterplec.Text = g1.Płeć.ToString();
            labelbohaterklasa.Text = g1.Klasa.ToString();
            labelbohaterzdrowie.Text = g1.Zdrowie.ToString();
            if (g1.Klasa == wKlasy.Wojownik)
            {
                labelbohateratak.Text = g1.Siła.ToString();
            }
            else if (g1.Klasa == wKlasy.Mag)
            {
                labelbohateratak.Text = g1.Inteligencja.ToString();
            }
            else if (g1.Klasa == wKlasy.Łucznik)
            {
                labelbohateratak.Text = g1.Zręczność.ToString();
            }
            else if (g1.Klasa == wKlasy.Kapłan)
            {
                labelbohateratak.Text = g1.Inteligencja.ToString();
            }

            Przeciwnik p1 = new Przeciwnik();
            p1 = ZapisPlików.WczytajPrzeciwnika();
            progressBarprzeciwnik.Value = p1.Zdrowie;
            progressBarprzeciwnik.Maximum = p1.Zdrowie;
            
            labelprzeciwniknazwa.Text = p1.Nazwa;
            labelprzeciwnikplec.Text = p1.Płeć.ToString();
            labelprzeciwnikklasa.Text = p1.Klasa.ToString();
            labelprzeciwnikzdrowie.Text = p1.Zdrowie.ToString();
            labelprzeciwnikatak.Text = p1.Siła.ToString();
            pictureBoxwalkaprzeciwnik.Image = Properties.Resources.wróg;

            if (this.labelbohaterklasa.Text == "Wojownik" && this.labelbohaterplec.Text == "Mężczyzna")
                pictureBoxwalkabohater.Image = Properties.Resources.wojownik;
            
            if (this.labelbohaterklasa.Text == "Wojownik" && this.labelbohaterplec.Text == "Kobieta")
                pictureBoxwalkabohater.Image = Properties.Resources.wojownikkobieta;
            
            if (this.labelbohaterklasa.Text == "Mag" && this.labelbohaterplec.Text == "Mężczyzna")
                pictureBoxwalkabohater.Image = Properties.Resources.mag;
            
            if (this.labelbohaterklasa.Text == "Mag" && this.labelbohaterplec.Text == "Kobieta")
                pictureBoxwalkabohater.Image = Properties.Resources.magkobieta;
            
            if (this.labelbohaterklasa.Text == "Łucznik" && this.labelbohaterplec.Text == "Mężczyzna")
                pictureBoxwalkabohater.Image = Properties.Resources.łucznik;
           
            if (this.labelbohaterklasa.Text == "Łucznik" && this.labelbohaterplec.Text == "Kobieta")
                pictureBoxwalkabohater.Image = Properties.Resources.archerkobieta;
            
            if (this.labelbohaterklasa.Text == "Kapłan" && this.labelbohaterplec.Text == "Mężczyzna")
                pictureBoxwalkabohater.Image = Properties.Resources.kapłan;
            
            if (this.labelbohaterklasa.Text == "Kapłan" && this.labelbohaterplec.Text == "Kobieta")
                pictureBoxwalkabohater.Image = Properties.Resources.pirestkobieta;
            


        }

        private void progressBarbohater_Click(object sender, EventArgs e)
        {
            
        }

        private void timermiecze_Tick(object sender, EventArgs e)
        {
            y -= 10;
            x += 10;
            if (x + 400 > 500)
            {
                timermiecze.Stop();
                timermiecze2.Enabled = true;
            }
            this.Refresh();
        }

        private void timermiecze2_Tick(object sender, EventArgs e)
        {
            y += 10;
            x -= 10;
            if (x + 120 <= 200)
            {
                timermiecze2.Stop();
            }
            this.Refresh();
        }
        private void formularzwalki_Paint(object sender, PaintEventArgs e)
        {
            var m = e.Graphics.Transform;
            
            e.Graphics.TranslateTransform(progressBarbohater.Location.X +230+ x, 210);
            e.Graphics.RotateTransform(x * 3.5F);
            e.Graphics.DrawImage(obrazekmieczbohatera, -35, -35, 70F, 70F);
           
            
            e.Graphics.Transform = m;
            e.Graphics.TranslateTransform(progressBarprzeciwnik.Location.X -50 + y, 210);
            e.Graphics.RotateTransform(y * 3.5F);
            e.Graphics.DrawImage(obrazekmieczprzeciwnika, -35, -35, 70F, 70F);
            
            
        }

        private void buttonwalkapowrot_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm Menuglowne = new MenuForm();
            Menuglowne.Show();
        }
    }
}

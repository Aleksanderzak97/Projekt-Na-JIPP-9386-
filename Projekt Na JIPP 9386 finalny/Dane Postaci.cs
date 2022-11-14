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
    public partial class Dane_Postaci : Form
    {
        public Dane_Postaci()
        {
            InitializeComponent();
        }

        private void Dane_Postaci_Load(object sender, EventArgs e)
        {
            Gracz g1 = new Gracz();
            g1 = ZapisPlików.WczytajGracza();
            labelnickdane.Text = g1.Nazwa;
            labelplecdane.Text = g1.Płeć.ToString();
            labelklasadane.Text = g1.Klasa.ToString();
            labeldanezdrowie.Text = g1.Zdrowie.ToString();
            

        }

        private void danebutton_Click(object sender, EventArgs e)
        {
            MenuForm dowalki = new MenuForm();
            dowalki.Show();
            this.Hide();
        }
    }
}

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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        
        private void Zamykanie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void przycisktworzeniapostaci_Click(object sender, EventArgs e)
        {
            tworzeniepostaciform tworzeniepostaci = new tworzeniepostaciform();
            
            tworzeniepostaci.Show();
            this.Hide();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonpojedynek_Click(object sender, EventArgs e)
        {
            formularzwalki formularzwalk = new formularzwalki();

            formularzwalk.Show();
            this.Hide();
        }

        private void buttonopispostaci_Click(object sender, EventArgs e)
        {
            Opispostaci opispostaci = new Opispostaci();

            opispostaci.Show();
            this.Hide();

        }
    }
}

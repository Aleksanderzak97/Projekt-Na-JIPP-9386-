using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojaKontrolka
{
    //[DefaultEvent("Click")]
    public partial class UserControl1: UserControl
    {
        //public delegate void MyControlClickEvent(object sender, EventArgs e);
        
        public string Nazwa
        {
            get { return MojPrzycisk.Text; }
            set { MojPrzycisk.Text = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
            
            
        }

        private void MojPrzycisk_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
    }
}

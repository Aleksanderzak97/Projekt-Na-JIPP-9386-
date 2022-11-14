using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Na_JIPP_9386_finalny.Klasy_Postaci
{
    public class Wojownik : Właściwości
    {
        Random rand = new Random();

        public Wojownik() :base()
        {

        }
        public Wojownik(string nazwa, wPłcie płcie) : base()
        {
            Nazwa = nazwa;
            Płeć = płcie;
            _siła = rand.Next(4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Na_JIPP_9386_finalny.Klasy_Postaci
{
    public class Kapłan : Właściwości
    {
        public Kapłan() : base()
        {

        }
        public Kapłan(string nazwa, wPłcie płcie) : base()
        {
            Nazwa = nazwa;
            Płeć = płcie;
            _inteligencja = rand.Next(10, 20);
        }
        public Kapłan(string nazwa, wPłcie płcie, int zdrowie, int siła, int zręczność, int inteligencja)
        {
            _nazwa = nazwa;
            _płcie = płcie;
            _zdrowie = zdrowie;
            _siła = siła;
            _zręczność = zręczność;
            _inteligencja = inteligencja;
        }
    }
}

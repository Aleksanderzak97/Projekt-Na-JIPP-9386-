using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Na_JIPP_9386_finalny.Klasy_Postaci
{
    public class Gracz : Właściwości
    {
        Random rand = new Random();

        public Gracz() : base()
        {

        }
        public Gracz(string nazwa, wPłcie płciek, wKlasy klasyw) : base()
        {

            //polimorfizm
            Nazwa = nazwa;
            Płeć = płciek;
            Klasa = klasyw;
            if (klasyw == wKlasy.Wojownik)
            {
                _zdrowie = 20;
                _siła = 20;
                _zręczność = rand.Next(4);
                _inteligencja = -5;

            }
            else if (klasyw == wKlasy.Mag)
            {
                _zdrowie = 5;
                _siła = -5;
                _zręczność = rand.Next(12);
                _inteligencja = 20;
            }
            else if (klasyw == wKlasy.Łucznik)
            {
                _zdrowie = 12;
                _siła = 4;
                _zręczność = 20;
                _inteligencja = 5;
            }
            else if (klasyw == wKlasy.Kapłan)
            {
                _zdrowie = 12;
                _siła = -5;
                _zręczność = 3;
                _inteligencja = 20;
            }



        }
        public Gracz(string nazwa, wPłcie płciek, wKlasy klasyw, int zdrowie, int siła, int zręczność, int inteligencja)
        {
            Nazwa = nazwa;
            Płeć = płciek;
            Klasa = klasyw;
            Zdrowie = zdrowie;
            Siła = siła;
            Zręczność = zręczność;
            Inteligencja = inteligencja;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Na_JIPP_9386_finalny.Klasy_Postaci
{
    public class Przeciwnik : Właściwości
    {
        Random rand = new Random();

        public Przeciwnik() : base()
        {

        }
        public Przeciwnik(string nazwa, wPłcie płciek, wKlasy klasyw) : base()
        {

            //polimorfizm
            Nazwa = "Złowrogi wróg";
            Płeć = płciek;
            Klasa = klasyw;
            _zdrowie = rand.Next(25,30);
            _siła = rand.Next(1, 5);
            
           
        }
        public Przeciwnik(string nazwa, wPłcie płciek, wKlasy klasyw, int zdrowie, int siła, int zręczność, int inteligencja)
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
   


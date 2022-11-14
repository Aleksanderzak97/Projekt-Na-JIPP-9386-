using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Na_JIPP_9386_finalny.Klasy_Postaci
{

    public enum wPłcie { Mężczyzna, Kobieta, Nieznana }
    public enum wKlasy {Wojownik, Mag, Łucznik, Kapłan, Nieznana }
    
    public abstract class Właściwości
    {
        protected Random rand;
        protected string _nazwa;
        protected wPłcie _płcie;
        protected wKlasy _klasy;
        protected int _zdrowie, _siła, _zręczność, _inteligencja;
        protected int _zdrowieilosc, _siłailosc, _zręcznośćilosc, _inteligencjailosc;

       
        public string Nazwa
        {
            get { return _nazwa; }
            set { _nazwa = value; }
        }
        public wPłcie Płeć
        {
            get { return _płcie; }
            set {_płcie = value; }
        }
        public wKlasy Klasa
        {
            get { return _klasy; }
            set {_klasy = value; }
        }
        public int Zdrowie
        {
            get { return _zdrowie + _zdrowieilosc; }
            set { _zdrowie = value; }

        }
        public int Siła
        {
            get { return _siła + _siłailosc; }
            set { _siła = value; }

        }
        public int Zręczność
        {
            get { return _zręczność + _zręcznośćilosc; }
            set { _zręczność = value; }

        }
        public int Inteligencja
        {
            get { return _inteligencja + _inteligencjailosc; }
            set { _inteligencja = value; }

        }

        public Właściwości()
        {
            Nazwa = "";
            Płeć = wPłcie.Nieznana;
            Klasa = wKlasy.Nieznana;
            Zdrowie = 0;
            Siła = 0;
            Zręczność = 0;
            Inteligencja = 0;
        }


    }
}

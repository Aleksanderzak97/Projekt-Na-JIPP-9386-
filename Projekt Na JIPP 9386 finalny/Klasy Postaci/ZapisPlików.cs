using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Projekt_Na_JIPP_9386_finalny.Klasy_Postaci
{
    internal class ZapisPlików
    {
        private static String FolderUstawien
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "Projekt na JIPP 9386");
                folder = Path.Combine(folder, "Ustawienia Postaci");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }

        private static String PlikZapisuGracza
        {
            get
            {
                return Path.Combine(FolderUstawien, "Gracz.xml");
            }
        }
        private static String PlikZapisuPrzeciwnika
        {
            get
            {
                return Path.Combine(FolderUstawien, "Przeciwnik.xml");
            }
        }

        private static Gracz DomyslneGracz
        {
            get
            {
                return new Gracz
                {
                    Nazwa = "",
                    Płeć = wPłcie.Nieznana,
                    Klasa = wKlasy.Nieznana,
                    Zdrowie = 0,
                    Siła = 0,
                    Zręczność = 0,
                    Inteligencja = 0,

                };
            }
        }
        private static Przeciwnik DomyslnePrzeciwnik
        {
            get
            {
                return new Przeciwnik
                {
                    Nazwa = "Złowrogi wróg",
                    Płeć = wPłcie.Nieznana,
                    Klasa = wKlasy.Nieznana,
                    Zdrowie = 25,
                    Siła = 5,
                    Zręczność = 2,
                    Inteligencja = 0,

                };
            }
        }
        public static Gracz WczytajGracza()
        {
            if (!File.Exists(PlikZapisuGracza))
                return DomyslneGracz;
            using (Stream stream = File.OpenRead(PlikZapisuGracza))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Gracz));
                return (Gracz)ser.Deserialize(stream);
            }
        }
        public static Przeciwnik WczytajPrzeciwnika()
        {
            if (!File.Exists(PlikZapisuPrzeciwnika))
                return DomyslnePrzeciwnik;
            using (Stream streamp = File.OpenRead(PlikZapisuPrzeciwnika))
            {
                XmlSerializer serp = new XmlSerializer (typeof(Przeciwnik));
                return (Przeciwnik)serp.Deserialize(streamp);
            }
        }
        public static void ZachowajPostac(Gracz gracz)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(PlikZapisuGracza, FileMode.Create), Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(gracz.GetType());
                ser.Serialize(sw, gracz);
            }


        }
        public static void ZachowajPrzeciwnika(Przeciwnik przeciwnik)
        {
            using (StreamWriter ws = new StreamWriter(File.Open(PlikZapisuPrzeciwnika, FileMode.Create), Encoding.UTF8))
            {
                XmlSerializer res = new XmlSerializer(przeciwnik.GetType());
                res.Serialize(ws, przeciwnik);
            }
        }

    }
}

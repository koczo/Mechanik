using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Mechanik.Rejestr;
using System.IO;
using Mechanik.Properties;
using System.Xml;

namespace Mechanik.Pojazdy
{

    public class Auto
    {
        
        public string NrRej { get; set; }
        public Marka.Typ Marka { get; set; }
        public string Model { get; set; }
        public string Kolor { get; set; }
        public string NrKolor { get; set; }
        public String Opis { get; set; }

        public Auto(string nrRej, Marka.Typ marka, string model, string kolor, string nrKolor, string opis)
        {
            NrRej = nrRej;
            Marka = marka;
            Model = model;
            Kolor = kolor;
            NrKolor = nrKolor;
            Opis = opis;

        }

        public Auto()
        {

        }

        public static List<Auto> ReadFromXML (string path)
        {
            List<Auto> auta = new List<Auto>();

            DataSet ds = new DataSet();

            if (File.Exists(path))
            {
                ds.ReadXml(path);
                if (ds.Tables.Count>0)
                {

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {

                        auta.Add(new Auto
                            (r[0].ToString(),
                            r[1].ToString().ConvertToEnum<Mechanik.Pojazdy.Marka.Typ>(),
                            r[2].ToString(),
                            r[3].ToString(),
                            r[4].ToString(),
                            r[5].ToString()
                            ));

                    }
                    ds.Dispose();  
                }
            }
            return auta;
        }

        public static bool Exists(List<Auto> auta, string rej)
        {
            bool e = false;
            foreach (var a in auta)
            {
                if (a.NrRej.ConvertToLower() == rej.ConvertToLower())
                {
                    e = true;
                    break;
                }
            }
            return e;
        }

        public static void Write(List<Auto> auta)
        {
            //Reg r = new Reg(); 
            XDocument xml = new XDocument(
                      new XElement("dane",
                          from auto in auta
                          select new XElement("pojazd",
                           new XElement("numer_rej", auto.NrRej),
                           new XElement("marka", auto.Marka),
                           new XElement("model", auto.Model),
                           new XElement("kolor", auto.Kolor),
                           new XElement("numer_kol", auto.NrKolor),
                           new XElement("opis", auto.Opis)
                           )));

            xml.Save(Settings.Default.PATH);
           
        }

        public static void Edit(string nrRej)
        {

            XDocument xml = XDocument.Load(Settings.Default.PATH);

            var query = from nr in xml.Elements("pojazd")
                        where nr.Value == nrRej
                        select nr;

                      //new XElement("dane",
                      //    from auto in auta
                      //    select new XElement("pojazd",
                      //     new XElement("numer_rej", auto.NrRej),
                      //     new XElement("marka", auto.Marka),
                      //     new XElement("model", auto.Model),
                      //     new XElement("kolor", auto.Kolor),
                      //     new XElement("numer_kol", auto.NrKolor),
                      //     new XElement("opis", auto.Opis)
                      //     )));

            xml.Save(Settings.Default.PATH);
           
        }

        public static void FillList(List<Auto> auto)
        {
            ListView listViewCar = new ListView();
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Recenzija
    {
        int proizvodID;
        int recezent;
        string naslov;
        string sadrzajRecenzije;
        string slika;

        public Recenzija ()
        {

        }
        public Recenzija(int proizvodID, int recezent, string naslov, string sadrzajRecenzije, string slika)
        {
            this.proizvodID = proizvodID;
            this.recezent = recezent;
            this.naslov = naslov;
            this.sadrzajRecenzije = sadrzajRecenzije;
            this.slika = slika;
        }

        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public int Recezent { get => recezent; set => recezent = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public string SadrzajRecenzije { get => sadrzajRecenzije; set => sadrzajRecenzije = value; }
        public string Slika { get => slika; set => slika = value; }

        public override string ToString()
        {
            return $"{ProizvodID},{Recezent},{Naslov},{SadrzajRecenzije},{Slika}";
        }

        public static Recenzija FromString(string input)
        {
            string[] vrednosti = input.Split(',');
            Recenzija recenzija = new Recenzija
            {
                proizvodID = int.Parse(vrednosti[0]),
                recezent = int.Parse(vrednosti[1]),
                naslov = vrednosti[2],
                sadrzajRecenzije = vrednosti[3],
                slika = vrednosti[4],
            };
            return recenzija;
        }
    }
}
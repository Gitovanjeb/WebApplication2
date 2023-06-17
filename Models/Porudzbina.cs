using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Porudzbina
    {
        int proizvodID;
        int kolicina;
        string kupac;
        DateTime datumPorudzbine;
        string status;

        public Porudzbina ()
        {

        }
        public Porudzbina(int proizvodID, int kolicina, string kupac, DateTime datumPorudzbine, string status)
        {
            this.proizvodID = proizvodID;
            this.kolicina = kolicina;
            this.kupac = kupac;
            this.datumPorudzbine = datumPorudzbine;
            this.status = status;
        }

        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public string Kupac { get => kupac; set => kupac = value; }
        public DateTime DatumPorudzbine { get => datumPorudzbine; set => datumPorudzbine = value; }
        public string Status { get => status; set => status = value; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace vezbanjeNasl
{
    class radnik
    {
        public string ime;
        public string prezime;
        public string jmbg;

        public double zarada;
        public radnik(string ime, string prezime, string jmbg, double zarada)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.zarada = zarada;
        }
        public virtual double godisnjaPlata()
        {
            return zarada * 12;
        }
    }
}

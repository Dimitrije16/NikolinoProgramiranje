using System;
using System.Collections.Generic;
using System.Text;

namespace vezbanjeNasl
{
    class programer : radnik
    {
        public double bonus;
        public programer(string ime, string prezime,
            string jmbg, double zarada, double bonus)
            : base(ime, prezime, jmbg, zarada)
        {
            this.bonus = bonus;
        }

        public override double godisnjaPlata()
        {
            return base.godisnjaPlata() + bonus / 100 * base.godisnjaPlata();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studienverlaufsplaner
{
    public class Modul
    {
        public string name;
        public bool bestanden = false;
        public double note;
        public double cp;
        public double gewichtung;
        public Modul(string ggName, double ggCp, double ggGewichtung)
        {
            name = ggName;
            cp = ggCp;
            gewichtung = ggGewichtung;
        }
    }
}

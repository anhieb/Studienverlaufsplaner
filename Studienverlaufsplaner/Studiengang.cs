using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studienverlaufsplaner
{
    class Studiengang
    {
        public string name;
        public List<Modul> module = new List<Modul>();
        public Studiengang(string NameStdg)
        {
            switch (NameStdg)
            {
                case "Intelligent Systems Design":
                    loadISDModuls();

                    break;
                default:
                        break;
                    
            }
            
        }

        private void loadISDModuls()
        {
            module.Add(new Modul("Grundlagen der Informatik 1", 8, 1));
            module.Add(new Modul("Mathematik 1", 6, 1));
        }
    }
}

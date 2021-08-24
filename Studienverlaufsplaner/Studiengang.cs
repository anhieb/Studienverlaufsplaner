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
            //Semester 1:
            module.Add(new Modul("Grundlagen der Informatik 1", 8, 1));
            module.Add(new Modul("Mathematik 1", 6, 1));
            module.Add(new Modul(" Naturwissenschaftliche Grundlagen", 9, 1));
            module.Add(new Modul("Technisches Englisch", 4, 1));
            module.Add(new Modul("Personal Skills 1", 3, 1));

            //Semester 2:
            module.Add(new Modul("Grundlagen der Informatik", 8, 1));
            module.Add(new Modul("Mathematik 2", 5, 1));
            module.Add(new Modul("System Modellierung", 5, 1));
            module.Add(new Modul("Elektrotechnik", 5, 1));
            module.Add(new Modul("Technisches Englisch 2", 4, 1));
            module.Add(new Modul("Personal Skills 2", 3, 1));

            //Semester 3:
            module.Add(new Modul("Embedded Systems", 8, 1));
            module.Add(new Modul("Praktische Informatik", 5, 1));
            module.Add(new Modul("Betriebssysteme und Netzwerke", 5, 1));
            module.Add(new Modul("Mathematik und System Analyse",5 , 1));
            module.Add(new Modul("Technisches Englisch 3", 4, 1));
            module.Add(new Modul("Personal Skills 3", 3, 1));

            //Semester 4:
            module.Add(new Modul("Software Design", 6, 1));
            module.Add(new Modul("Computer Security", 5, 1));
            module.Add(new Modul("Datenbanken", 4, 1));
            module.Add(new Modul("Studienschwerpunkt 1",8 , 1));
            module.Add(new Modul("Corporate Management", 4, 1));
            module.Add(new Modul("Personal Skills 4",3 , 1));

            //Semester 5:
            module.Add(new Modul("Praxis-/ Auslandssemester", 30, 1));

            //semester 6:
            module.Add(new Modul("Projektarbeit", 13, 1));
            module.Add(new Modul("Artificial Intelligence",4 , 1));
            module.Add(new Modul("Studienschwerpunkt 2", 6, 1));
            module.Add(new Modul("Entrepreneurial Finance", 4, 1));
            module.Add(new Modul("Personal Skills 5",3 , 1));

            //Semester 7:
            module.Add(new Modul("Bachelorarbeit",14 , 1.5));
            module.Add(new Modul("Ausewählte Gebiete der Safety und Security",4 , 1));
            module.Add(new Modul("Ausgewählte anwendungen und praxisfelder",4 , 1));
            module.Add(new Modul("Studienschwerpunkt 3", 8, 1));




        }
    }
}

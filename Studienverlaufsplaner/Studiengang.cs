using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studienverlaufsplaner
{
    public class Studiengang
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

                case "Energietechnik und Ressourcenoptimierung":
                    loadETRModuls();

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

        private void loadETRModuls()
        {
            //Semester 1:
            module.Add(new Modul("Nachhaltige Ressourcenwirtschaft und Energieversorgung",4, 1));
            module.Add(new Modul("Grundlagen Mathematik und Mechanik",10, 1));
            module.Add(new Modul("Naturwissenschaftliche Grundlagen",9, 1));
            module.Add(new Modul("Unternehmensführung 1",3.5, 1));
            module.Add(new Modul("Steuerungskompetenzen 1",3.5, 1));

            //Semester 2:
            module.Add(new Modul("Grundlagen Mathematik und Elektrotechnik",9, 1));
            module.Add(new Modul("Grundlagen Energie- und Stoffumwaldung",8, 1));
            module.Add(new Modul("Grundlagen Werkstoffe und Mechanik",6, 1));
            module.Add(new Modul("Unternehmensführung 2",3.5, 1));
            module.Add(new Modul("Steuerungskompetenzen 2",3.5, 1));

            //Semester 3:
            module.Add(new Modul("Mathematik und Elektromaschinen",10, 1));
            module.Add(new Modul("Wärme- und Strömungstechnik",12, 1));
            module.Add(new Modul("Konstruktionslehre",5, 1));
            module.Add(new Modul("Steuerungskompetenzen 3",6, 1));

            //Semester 4:
            module.Add(new Modul("Energiesysteem: Infrastruktur und Handelsmärkte",10, 1));
            module.Add(new Modul("Energieprozesstechnik",10, 1));
            module.Add(new Modul("Studienschwerpunkte 1",6, 1));
            module.Add(new Modul("Steuerungskompetenzen 3",4, 1));

            //Semester 5:
            module.Add(new Modul("Praxis-/ Auslandssemester",30, 1));

            //Semester 6:
            module.Add(new Modul("Projektarbeit einschließl. Projektseminar",16, 1));
            module.Add(new Modul("Studienschwerpunkte 2a",6, 1));
            module.Add(new Modul("Studienschwerpunkte 2b",5, 1));
            module.Add(new Modul("Steuerungskompetenzen 4",4, 1));

            //Semester 7:
            module.Add(new Modul("Bachelorarbeit einschließl. Bachelorseminar",14, 1));
            module.Add(new Modul("Studienschwerpunkte 3a",6, 1));
            module.Add(new Modul("Studienschwerpunkte 3b",5, 1));
            module.Add(new Modul("Produktgestaltung ",5, 1));

        }

    }
}

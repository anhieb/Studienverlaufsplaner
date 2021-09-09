using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Studienverlaufsplaner
{
    /// <summary>
    /// Interaktionslogik für Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        Studiengang studiengang;

        public Page3(Studiengang stdg)
        {
            studiengang = stdg;

            InitializeComponent();

            calculate();
            updateUi();
        }

        double durchschnittsnote = 7;
        int anzahlBestanden = 0;
        List<string> nichtBestanden = new List<string>();

        private void calculate()
        {
            double zwischenberechnung = 0;

            for(int i = 0; i < studiengang.module.Count; i++)
            {
                if ( studiengang.module.ToArray()[i].bestanden)
                {
                    anzahlBestanden++;
                    zwischenberechnung += studiengang.module.ToArray()[i].note * studiengang.module.ToArray()[i].cp *
                    studiengang.module.ToArray()[i].gewichtung;
                }
                else
                {
                    nichtBestanden.Add(studiengang.module.ToArray()[i].name);
                }

            }

            //durchschnittsnote = zwischenberechnung / anzahlBestanden;
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2(""));
        }

        private void updateUi()
        {
            Fortschrittstext.Text = anzahlBestanden.ToString() + " von " + 
                studiengang.module.Count.ToString() 
                + " Module sind bestanden und du kannst die Mitschriften aus dem Fenster schmeissen";
            Fortschrittsbalken.Value = anzahlBestanden;
            Fortschrittsbalken.Maximum = studiengang.module.Count;
            
            foreach(string modulname in nichtBestanden)
            {
                Label labelname = new Label();
                labelname.Content = modulname;
                offeneModule.Items.Add(labelname);
            }
        }
    }
}


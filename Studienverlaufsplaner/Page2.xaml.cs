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
    /// Interaktionslogik für Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        Studiengang studiengang;


        public Page2(string stdgauswahl)
        {
            InitializeComponent();
            studiengang = new Studiengang(stdgauswahl);
            
            int Modulnr = 0;
            List<RowDefinition> rows = new List<RowDefinition>();

            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();

            MeinGrid.ColumnDefinitions.Add(col1);
            MeinGrid.ColumnDefinitions.Add(col2);
            MeinGrid.ColumnDefinitions.Last().Width = new GridLength(200);
            MeinGrid.ShowGridLines = true;

            List<Label> ModuleNames = new List<Label>();
            List<TextBox> KarlMarxs = new List<TextBox>();


            foreach (Modul modul in studiengang.module)
            {
                // hier dieses Modul der Liste hinzufügen
                    //neue Zeile ins Grid
                rows.Add(new RowDefinition());
                MeinGrid.RowDefinitions.Add(rows.ToArray()[Modulnr]);
                //Neues Label für den Modul Namen
                KarlMarxs.Add(new TextBox());
                ModuleNames.Add(new Label());
                ModuleNames.ToArray()[Modulnr].Content = modul.name;
                //Label ins Grid
                Grid.SetRow(KarlMarxs.ToArray()[Modulnr], Modulnr);
                Grid.SetRow(ModuleNames.ToArray()[Modulnr], Modulnr);
                Grid.SetColumn(KarlMarxs.ToArray()[Modulnr], 1);
                Grid.SetColumn(ModuleNames.ToArray()[Modulnr], 0);

                MeinGrid.Children.Add(ModuleNames.ToArray()[Modulnr]);
                MeinGrid.Children.Add(KarlMarxs.ToArray()[Modulnr]);

                Modulnr++;
            }
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}

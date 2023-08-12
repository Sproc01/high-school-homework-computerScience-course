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

namespace bindingListView
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public class Persona
    {
        public string Nome { get; }
        public string Cognome { get; }
        public int Peso { get; }

        public Persona(string n, string c, int p)
        {
            Nome = n;
            Cognome=c;
            Peso = p;
        }
    }
    public partial class MainWindow : Window
    {
        List<Persona> pers = new List<Persona>();
        public MainWindow()
        {
            InitializeComponent();
            
            pers.Add(new Persona("A", "A", 20));
            pers.Add(new Persona("B", "B", 30));
            pers.Add(new Persona("C", "C", 40));
            pers.Add(new Persona("D", "D", 50));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listview.ItemsSource = pers;
            listview.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(listview.SelectedItem!=null)
            {
                Windowview form = new Windowview((Persona)listview.SelectedItem);
                form.Show();
            }
        }
    }
}

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

namespace Wpf_Lista
{
    class Persona
    {
        string _nome;
        string _cognome;
        
        public Persona(string n, string c)
        {
            _nome = n;
            Cognome = c;
        }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public override string ToString()
        { return string.Format($"{_nome} {_cognome}"); }

    }
    public partial class MainWindow : Window
    {
        List<Persona> persone = new List<Persona>();
        public MainWindow()
        { InitializeComponent(); }

        private void Carica_Click(object sender, RoutedEventArgs e)
        { Lista1.ItemsSource = persone; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            persone.Add(new Persona("Federico", "Melon"));
            persone.Add(new Persona("Antonio", "Borsetto"));
        }

        private void Modifica_Click(object sender, RoutedEventArgs e)
        {
            if (Lista1.SelectedIndex != -1)
            {
                Persona individuo = (Persona)Lista1.Items[Lista1.SelectedIndex];
                individuo.Nome = "Gino";
                Lista2.ItemsSource = null;
                Lista2.ItemsSource = persone;
            }
        }

        private void Cancella_Click(object sender, RoutedEventArgs e)
        {
            if (Lista1.SelectedIndex != -1)
            { 
                //persone.RemoveAt(Lista1.SelectedIndex);
                persone.RemoveAt(Lista1.Items.IndexOf(Lista1.SelectedItem));
                
            }
            Lista2.ItemsSource = null;
            Lista2.ItemsSource = persone;
        }

        private void Lista1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Lista1.SelectedIndex != -1)
            {
                Persona individuo = (Persona)Lista1.Items[Lista1.SelectedIndex];
                individuo.Nome = "Gino";
                Lista1.ItemsSource = null;
                Lista1.ItemsSource = persone;
            }
        }
    }
}

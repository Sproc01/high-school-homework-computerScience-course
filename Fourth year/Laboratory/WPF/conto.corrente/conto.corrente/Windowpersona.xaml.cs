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
using System.Windows.Shapes;
using library;

namespace conto.corrente
{
    /// <summary>
    /// Logica di interazione per Windowpersona.xaml
    /// </summary>
    public partial class Windowpersona : Window
    {
        Persona p;
        public Windowpersona(string n)
        {
            InitializeComponent();
            txtnome.Text = n;
            if (n != "")//focus su textbox libera
                txtntelefono.Focus();
            else
                txtnome.Focus();
        }

        public Persona returnper()//metodo per ritornare la persona
        {
            return p;
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {//controllo dati corretti
            if (txtnome.Text != "" && txtntelefono.Text != "")
            {
                if (txtntelefono.Text.Length == 10)
                {
                    p = new Persona(txtnome.Text, txtntelefono.Text);
                    DialogResult = true;
                }
            else
                MessageBox.Show("Dati errati, numero telefono troppo corto", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
               MessageBox.Show("Dati errati", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnannulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void txtntelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {//controllo caratteri
            char i = e.Text[0];
            e.Handled = !char.IsDigit(i);
        }
    }
}

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
using libraryflotta;

namespace FlottaNavale
{
    /// <summary>
    /// Logica di interazione per WindowModificaIncarico.xaml
    /// </summary>
    public partial class WindowModificaIncarico : Window
    {
        Incarico incarico;
        public WindowModificaIncarico(Incarico i)
        {
            InitializeComponent();
            incarico = i;//assegnazione riferimento
            txtnomecom.Text = i.Com.Nome;
            txtnomenave.Text = i.Nav.Nome;
            dtfine.SelectedDate = DateTime.Now;//valore di default
        }
        private void btnannulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            if (dtfine.SelectedDate >= incarico.DataInizio)//controllo input corretto
            {
                incarico.DataFine= (DateTime)dtfine.SelectedDate;
                DialogResult = true;
            }
            else
                MessageBox.Show("Data finale minore della data iniziale", "Impossibile", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

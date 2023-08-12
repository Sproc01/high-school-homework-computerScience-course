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
using libraryAlloggioVilla;

namespace EreditarietàAllVill
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool creatovilla;
        bool creatoalloggio;
        Villa villa;
        Alloggio alloggio;

        public MainWindow()
        {
            InitializeComponent();
            btnvisualizza.Visibility = Visibility.Hidden;
            btnelimina.Visibility = Visibility.Hidden;
            txtmetriquadrigiardino.Visibility = Visibility.Hidden;
            txtbmetrigiardino.Visibility = Visibility.Hidden;
        }

        private void btnelimina_Click(object sender, RoutedEventArgs e)
        {
            txtcodice.Text = "";
            txtcodice.IsReadOnly = false;
            txtmetriquadrialloggio.Text = "";
            txtmetriquadrialloggio.IsReadOnly = false;
            txtmetriquadrigiardino.Text = "";
            txtmetriquadrigiardino.IsReadOnly = false;
            txtnumeropersone.Text = "";
            txtnumeropersone.IsReadOnly = false;
            txtbdensità.Text = "";
            txtbcostoalloggio.Text = "";
            txtbacqua.Text = "";
            btnelimina.Visibility = Visibility.Hidden;
            btnvisualizza.Visibility = Visibility.Hidden;
            btncrea.Visibility = Visibility.Visible;
        }

        private void btncrea_Click(object sender, RoutedEventArgs e)
        {
            if (txtcodice.Text != "" && txtmetriquadrialloggio.Text != "" && txtnumeropersone.Text != "")
            {

                creatoalloggio = false;
                creatovilla = false;
                btncrea.Visibility = Visibility.Hidden;
                btnelimina.Visibility = Visibility.Visible;
                btnvisualizza.Visibility = Visibility.Visible;
                int codice;
                double metriquadrigiardino;
                int numpersone;
                double metriquadrialloggio;
                codice = Convert.ToInt32(txtcodice.Text);
                metriquadrialloggio = Convert.ToDouble(txtmetriquadrialloggio.Text);
                numpersone = Convert.ToInt32(txtnumeropersone.Text);
                if (creavillachecked.IsChecked==false)
                {
                    alloggio = new Alloggio(codice, metriquadrialloggio, numpersone);
                    creatoalloggio = true;
                }
                else
                {
                    metriquadrigiardino = Convert.ToInt32(txtmetriquadrigiardino.Text);
                    villa = new Villa(numpersone, metriquadrialloggio, codice, metriquadrigiardino);
                    creatovilla = true;
                }
                txtmetriquadrialloggio.IsReadOnly = true;
                txtmetriquadrigiardino.IsReadOnly = true;
                txtnumeropersone.IsReadOnly = true;
                txtcodice.IsReadOnly = true;
            }
            else
                MessageBox.Show("Impossibile creare elemento", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnvisualizza_Click(object sender, RoutedEventArgs e)
        {
            if(creatovilla)
            {
                txtbacqua.Text = "Costo Acqua:" + villa.CalcoloCostoAcqua().ToString();
                txtbcostoalloggio.Text = "Costo Alloggio:" + villa.CalcoloCostoAlloggio().ToString();
                txtbdensità.Text = "Densità:" + villa.Densità().ToString();
            }
            if(creatoalloggio)
            {
                txtbacqua.Text = "Costo Acqua:" + alloggio.CalcoloCostoAcqua().ToString();
                txtbcostoalloggio.Text = "Costo Alloggio:" + alloggio.CalcoloCostoAlloggio().ToString();
                txtbdensità.Text = "Densità:" + alloggio.Densità().ToString();
            }
        }

        private void txtcodice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char i = e.Text[0];
            e.Handled = !char.IsDigit(i);
        }

        private void txtmetriquadrialloggio_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char i = e.Text[0];
            bool trovata = false;
            if (sender == txtmetriquadrialloggio)
            {
                for (int j = 0; j < txtmetriquadrialloggio.Text.Length && !trovata; j++)
                {
                    if (txtmetriquadrialloggio.Text[j] == ',')
                        trovata = true;
                }
            }
            else
            {
                for (int j = 0; j < txtmetriquadrigiardino.Text.Length && !trovata; j++)
                {
                    if (txtmetriquadrigiardino.Text[j] == ',')
                        trovata = true;
                }
            }
            if (!trovata)
                e.Handled = !char.IsDigit(i) && i != ',';
            else
                e.Handled = !char.IsDigit(i);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtmetriquadrigiardino.Visibility = Visibility.Visible;
            txtbmetrigiardino.Visibility = Visibility.Visible;
            btncrea.Content = "Crea Villa";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btncrea.Content = "Crea Alloggio";
            txtmetriquadrigiardino.Visibility = Visibility.Hidden;
            txtbmetrigiardino.Visibility = Visibility.Hidden;
        }
    }
}

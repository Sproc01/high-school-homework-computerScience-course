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
using Triangoloclass;

namespace triangolomain
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btncalcola.Visibility = Visibility.Hidden;
            txtarea.Visibility = Visibility.Hidden;
            txtperimetro.Visibility = Visibility.Hidden;
            lbarea.Visibility = Visibility.Hidden;
            lbrisu.Visibility= Visibility.Hidden;
            lbperimetro.Visibility= Visibility.Hidden;
            txbterzo.Visibility = Visibility.Hidden;
            txtterzo.Visibility = Visibility.Hidden;
            txtsecondo.Visibility = Visibility.Hidden;
            txbsecondo.Visibility= Visibility.Hidden;
            txtprimo.Visibility = Visibility.Hidden;
            txbprimo.Visibility = Visibility.Hidden;
        }

        private void cmbtipo_DropDownClosed(object sender, EventArgs e)
        {
            txtperimetro.Clear();
            txtarea.Clear();
            txtprimo.Clear();
            txtsecondo.Clear();
            txtterzo.Clear();
            txbterzo.Visibility = Visibility.Visible;
            txtterzo.Visibility = Visibility.Visible;
            txtsecondo.Visibility = Visibility.Visible;
            txbsecondo.Visibility = Visibility.Visible;
            txtprimo.Visibility = Visibility.Visible;
            txbprimo.Visibility = Visibility.Visible;
            switch (((ComboBox)sender).Text)
            {
                case "Equilatero":
                    txbsecondo.Visibility = Visibility.Hidden;
                    txtsecondo.Visibility = Visibility.Hidden;
                    txtterzo.Visibility = Visibility.Hidden;
                    txbterzo.Visibility = Visibility.Hidden;
                    txbprimo.Text = "Misura dei 3 lati";
                    break;
                case "Scaleno":
                    txbprimo.Text = "Misura primo lato";
                    txbsecondo.Text = "Misura secondo lato";
                    txbterzo.Text = "Misura terzo lato";
                    break;
                case "Isoscele":
                    txtterzo.Visibility = Visibility.Hidden;
                    txbterzo.Visibility = Visibility.Hidden;
                    txbsecondo.Text = "Misura della base";
                    txbprimo.Text = "Misura dei lati obliqui";
                    break;
            }
            txtarea.Visibility = Visibility.Visible;
            txtperimetro.Visibility = Visibility.Visible;
            lbarea.Visibility = Visibility.Visible;
            lbrisu.Visibility = Visibility.Visible;
            lbperimetro.Visibility = Visibility.Visible;
            btncalcola.Visibility = Visibility.Visible;
        }

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            txtperimetro.Clear();
            txtarea.Clear();
            double l1, l2, l3;
            Triangolo p;
            switch (cmbtipo.Text)
            {
                case "Equilatero":
                    if (txtprimo.Text != "")
                    {
                        l1 = Convert.ToDouble(txtprimo.Text);
                        p = new Triangolo(l1);
                        txtarea.Text = p.GetArea().ToString();
                        txtperimetro.Text = p.Getperimetro().ToString();
                    }
                    else
                        MessageBox.Show("Non hai inserito i dati", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case "Scaleno":
                    if (txtprimo.Text != "")
                    {
                        l1 = Convert.ToDouble(txtprimo.Text);
                        l2 = Convert.ToDouble(txtsecondo.Text);
                        l3 = Convert.ToDouble(txtterzo.Text);
                        if (l1 < l2 + l3 && l2 < l1 + l3 && l3 < l2 + l1)
                        {
                            p = new Triangolo(l1, l2, l3);
                            txtarea.Text = p.GetArea().ToString();
                            txtperimetro.Text = p.Getperimetro().ToString();
                        }
                        else
                            MessageBox.Show("Non è un triangolo","Errore",MessageBoxButton.OK,MessageBoxImage.Error);
                    }
                    else
                        MessageBox.Show("Non hai inserito i dati", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case "Isoscele":
                    if (txtprimo.Text != "")
                    {
                        l1 = Convert.ToDouble(txtprimo.Text);
                        l2 = Convert.ToDouble(txtsecondo.Text);
                        if (l1 < l2 * 2 && l2 < l2 + l1)
                        {
                            p = new Triangolo(l1, l2);
                            txtarea.Text = p.GetArea().ToString();
                            txtperimetro.Text = p.Getperimetro().ToString();
                        }
                        else
                            MessageBox.Show("Non è un triangolo", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                        MessageBox.Show("Non hai inserito i dati", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }
    }
}

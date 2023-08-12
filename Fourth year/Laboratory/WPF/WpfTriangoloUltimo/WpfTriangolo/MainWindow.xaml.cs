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
using Triangolo;


namespace WpfTriangolo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }
        Triangolo1 triangolo;

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {            
                          
        }

        private void rdEqui_Click(object sender, RoutedEventArgs e)
        {
            lblArea.Text = "Area : ";
            lblPerim.Text = "Perimetro : ";
            double Lato;            
            if (Controllo(txtlato1.Text))
            {
                Lato = Convert.ToDouble(txtlato1.Text);
                triangolo = new Triangolo1(Lato);
                lblArea.Text += triangolo.GetArea().ToString();
                lblPerim.Text += triangolo.GetPerimetro().ToString();
            }
            else
                MessageBox.Show("Errore inserimento dati", "Triangolo", MessageBoxButton.OK);
        }
        private void rdIso_Click(object sender, RoutedEventArgs e)
        {
            lblArea.Text = "Area : ";
            lblPerim.Text = "Perimetro : ";
            double Lato1;
            double Lato2;
            //Triangolo1 triangolo;

            if (Controllo(txtlato1.Text) && Controllo(txtlato2.Text))
            {
                Lato1 = Convert.ToDouble(txtlato1.Text);
                Lato2 = Convert.ToDouble(txtlato2.Text);
                try
                {
                    triangolo = new Triangolo1(Lato1, Lato2);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                    return;
                }
                lblArea.Text += triangolo.GetArea().ToString();
                lblPerim.Text += triangolo.GetPerimetro().ToString();                
            }
            else
                MessageBox.Show("Errore inserimento dati", "Triangolo", MessageBoxButton.OK);   
        }
        
        private void rdSca_Click(object sender, RoutedEventArgs e)
        {
            lblArea.Text = "Area : ";
            lblPerim.Text = "Perimetro : ";
            double Lato1;
            double Lato2;
            double Lato3;
            
            if (Controllo(txtlato1.Text) && Controllo(txtlato2.Text) && Controllo(txtlato3.Text))
            {
                Lato1 = Convert.ToDouble(txtlato1.Text);
                Lato2 = Convert.ToDouble(txtlato2.Text);
                Lato3 = Convert.ToDouble(txtlato3.Text);
                try
                {
                    triangolo = new Triangolo1(Lato1, Lato2, Lato3);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                    return;
                }
                lblArea.Text += triangolo.GetArea().ToString();
                lblPerim.Text += triangolo.GetPerimetro().ToString();
            }
            else
                MessageBox.Show("Errore inserimento dati", "Triangolo", MessageBoxButton.OK);
        }

        public bool Controllo(string L)
        {
            bool ok = false;
            for (int i = 0; i < L.Length && !ok; i++)
            {
                if (Convert.ToChar(L[i]) >= 48 && Convert.ToChar(L[i]) <= 57)
                    ok = true;
                if (!ok && Convert.ToChar(L[i]) == 44)
                    ok = true;
            }
                return ok;
        }

        private void txtlato1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnTipo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtlato1_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }

        private void txtlato1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtlato1.Text != null)
            {
                if (triangolo != null)
                {
                    try
                    {
                        triangolo.SetLato1(Convert.ToDouble(txtlato1.Text));
                        SetTipo(triangolo.GetTipoTriangolo());
                    }
                    catch
                    {
                        MessageBox.Show("Errore inserimento dati.");
                    }
                }
                //else MessageBox.Show("Non è stata ancora creato un triangolo.", "Triangolo");
            }
            

        }
        public void SetTipo(TipoTriangolo t)
        {
            switch(t)
            {
                case TipoTriangolo.equilatero: rdEqui.IsChecked = true;break;
                case TipoTriangolo.isoscele:rdIso.IsChecked = true;break;
                case TipoTriangolo.scaleno:rdSca.IsChecked = true;break;
            }
        }

        private void txtlato2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtlato2.Text != null)
            {
                if (triangolo != null)
                {
                    try
                    {
                        triangolo.SetLato2(Convert.ToDouble(txtlato2.Text));
                        SetTipo(triangolo.GetTipoTriangolo());
                    }
                    catch
                    {
                        MessageBox.Show("Errore inserimento dati.");
                    }
                }
            }
        }

        private void txtlato3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtlato3.Text != null)
            {
                if (triangolo != null)
                {
                    try
                    {
                        triangolo.SetLato3(Convert.ToDouble(txtlato3.Text));
                        SetTipo(triangolo.GetTipoTriangolo());
                    }
                    catch
                    {
                        MessageBox.Show("Errore inserimento dati.");
                    }
                }
            }
        }
    }
}

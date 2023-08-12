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


namespace CardGame
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Carta cartaG1;
        Carta cartaG2;
        
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private Carta PescaCarta()
        {
            return new Carta(RandomizeType(), RandomizeValue());
        }

        public int RandomizeValue()
        {
            return r.Next(2, 14);
        }

        public TipoSeme RandomizeType()
        {
            return (TipoSeme)r.Next(0, 3);
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewPlayerWindow window = new NewPlayerWindow();
            if ((bool)window.ShowDialog())
            {
                lblNameG1.Content = window.G1Name;
                lblNameG2.Content = window.G2Name;
                lblPointsG1.Content = "0";
                lblPointsG2.Content = "0";
            }

        }

        private void btnEstrai1_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.CurrentDirectory+"/Playing Cards";
            BitmapImage img1 = new BitmapImage();
            BitmapImage img2 = new BitmapImage();

            do
            {
                img1.BeginInit();
                cartaG1 = PescaCarta();
                img1.UriSource = new Uri(path + $"/{cartaG1.Valore}{cartaG1.Seme}.png");
                pbG1.Source = img1;
                img1.EndInit();

                img2.BeginInit();
                cartaG2 = PescaCarta();
                img2.UriSource = new Uri(path + $"/{cartaG2.Valore}{cartaG2.Seme}.png");
                pbG2.Source = img2;
                img2.EndInit();
            } while (pbG1.Source == pbG2.Source);


            if (cartaG1 > cartaG2)
            {
                MessageBox.Show($"Ha vinto {lblNameG1.Content}");
                lblPointsG1.Content = (Convert.ToInt32(lblPointsG1.Content) + 1).ToString();
            }
            else
            {
                MessageBox.Show($"Ha vinto {lblNameG2.Content}");
                lblPointsG2.Content = (Convert.ToInt32(lblPointsG2.Content) + 1).ToString();
            }
            pbG1.Source = null;
            pbG2.Source = null;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnNewGame_Click(sender, e);
        }
    }

    public enum TipoSeme { quadri, cuori, fiori, picche }

    class Carta
    {
        
        public TipoSeme Seme { get; private set; }
        public int Valore { get; private set; }

        public Carta(TipoSeme seme, int valore)
        {
            Seme = seme;
            Valore = valore;
        }

       

        public static bool operator >(Carta c1, Carta c2)
        {
            if (c1.Valore > c2.Valore)
                return true;

            if (c1.Valore == c2.Valore)
            {
                if (c1.Seme == TipoSeme.cuori && c2.Seme != TipoSeme.cuori)
                    return true;
                if (c1.Seme == TipoSeme.quadri && c2.Seme != TipoSeme.cuori)
                    return true;
                if (c1.Seme == TipoSeme.fiori && (c2.Seme != TipoSeme.cuori && c2.Seme != TipoSeme.quadri))
                    return true;
                if (c1.Seme == TipoSeme.picche && c2.Seme == TipoSeme.picche)
                    return true;
            }
            return false;
        }

        public static bool operator <(Carta c1, Carta c2)
        { return !(c1.Valore > c2.Valore); }
    }
}

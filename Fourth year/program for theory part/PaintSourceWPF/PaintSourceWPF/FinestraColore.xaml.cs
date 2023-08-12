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

namespace PaintSourceWPF
{
    /// <summary>
    /// Logica di interazione per FinestraColore.xaml
    /// </summary>
    public partial class FinestraColore : Window
    {
        public FinestraColore()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Annulla_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        internal Color GetColore()
        {
            byte r;
            byte g;
            byte b;
            try
            {
                r = Convert.ToByte(Rosso.Text);
                if (r < 0 || r > 255)
                    r = 0;
            }
            catch { r = 0; }
            try
            {
                g = Convert.ToByte(Verde.Text);
                if (g < 0 || g > 255)
                    g = 0;
            }
            catch { g = 0; }
            try
            {
                b = Convert.ToByte(Blue.Text);
                if (b < 0 || b > 255)
                    b = 0;
            }
            catch { b = 0; }
            return Color.FromRgb(r, g, b);
        }
    }
}

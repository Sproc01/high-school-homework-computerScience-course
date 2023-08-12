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
    /// Logica di interazione per WindowRotta.xaml
    /// </summary>
    public partial class WindowRotta : Window
    {
        public List<Posizione> lista { get; private set; }
        public WindowRotta()
        {
            InitializeComponent();
            imgMappa.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "\\europe.jpg"));
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Annulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void paintSurface_MouseDown(object sender, MouseButtonEventArgs e)
        {           
            Line line = new Line();
            line.StrokeThickness = 10;
            line.Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            line.StrokeEndLineCap = PenLineCap.Round;
            line.StrokeStartLineCap = PenLineCap.Round;
            //line.X1 = 
            //line.Y1 = T.Location.Y;
            //line.X2 = T1.Location.X;
            //line.Y2 = T1.Location.Y;
            paintSurface.Children.Add(line);
            lista.Add(new Posizione(line.X1, line.Y1));
        }
    }
}

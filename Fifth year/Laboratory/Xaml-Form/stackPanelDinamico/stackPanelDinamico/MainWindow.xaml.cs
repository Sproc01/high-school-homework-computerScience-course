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

namespace stackPanelDinamico
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cont=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            cont++;
            Button btn2 = new Button();
            btn2.Content = "n°:" +cont;
            btn2.Background = Brushes.AliceBlue;
            btn2.Height = 100;
            stk1.Children.Add(btn2);//aggiunge in maniera dinamica i nuovi bottoni
        }
    }
}

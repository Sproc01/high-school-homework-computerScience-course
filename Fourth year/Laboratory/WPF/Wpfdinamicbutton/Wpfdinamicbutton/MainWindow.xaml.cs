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

namespace Wpfdinamicbutton
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hai premuto il bottone");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Button btn = new Button();
            btn.Content = "Btn code behind";
            btn.Width = 100;
            btn.Height = 20;
            btn.Click += Btn_Click;
            C1.Children.Add(btn);
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hai premuto il bottone");
            t1.Text = "efe efe";
            //throw new NotImplementedException();
        }
    }
}

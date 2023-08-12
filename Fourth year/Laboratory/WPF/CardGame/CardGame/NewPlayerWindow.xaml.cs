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

namespace CardGame
{
    /// <summary>
    /// Logica di interazione per NewPlayerWindow.xaml
    /// </summary>
    public partial class NewPlayerWindow : Window
    {
        public NewPlayerWindow()
        {
            InitializeComponent();
        }
        public string G1Name { get; private set; }
        public string G2Name { get; private set; }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameG1.Text != "" && txtNameG2.Text != "")
            {
                G1Name = txtNameG1.Text;
                G2Name = txtNameG2.Text;
                DialogResult = true;
            }
            else
                MessageBox.Show("Uno dei due campi è vuoto");
        }

        private void btnAnnulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}

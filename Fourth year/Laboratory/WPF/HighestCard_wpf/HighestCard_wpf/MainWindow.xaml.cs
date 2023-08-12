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
using System.IO;

namespace HighestCard_wpf
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HighestCardGame game;
        public MainWindow()
        {
            InitializeComponent();
            game = new HighestCardGame();
        }

        private void BtnPesca_Click(object sender, RoutedEventArgs e)
        {
            //imgCard1.Source = null;
            //imgCard2.Source = null;
            game.ResetGame();
            game.DrawCard();
            string appPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString()).ToString()).ToString();
            imgCard1.Source = new BitmapImage(new Uri(string.Format("{0}\\img\\{1}_of_{2}.png", appPath, game.player1.Value, game.player1.CardType)));
            imgCard2.Source = new BitmapImage(new Uri(string.Format("{0}\\img\\{1}_of_{2}.png", appPath, game.player2.Value, game.player2.CardType)));
            lblContents.Content = string.Format("{0}\n{1}", game.CardString(), game.StringWinner());
        }
    }
}

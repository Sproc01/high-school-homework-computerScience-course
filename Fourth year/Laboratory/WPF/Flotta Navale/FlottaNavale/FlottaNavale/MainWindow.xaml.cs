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
using libraryflotta;
using flottanavale;

namespace FlottaNavale
{
    /// <summary>
    /// Michele Sprocatti 4E
    /// Nome richiesto obbligatoriamente
    /// Logica di interazione per MainWindow.xaml
    /// Bottone aggiungi permette di aggiungere navi e comandanti
    /// Crea incarico permette di creare l'incarico
    /// doppio click sulle liste permette di fare la modifica dell'elemento selezionato
    /// per terminare l'incarico si fa doppio click sulla lista degli incarichi
    /// Non sono accettati omonimi nei comandanti e nelle navi
    /// la data di fine dell'incarico deve essere maggiore della data di inizio
    /// per effettuare la modifica bisogna settare a checked "abilita modifca"
    /// se la nave e il comandante hanno un incarico non possono essere modificati
    /// se la nave è in cantiere può essere modifcata a parte il nome, se è varata può essere modificato solo lo stato, se è demolita nulla
    /// se il comandnate è in servizio si può modificare lo stato e il num. di telefono, se è in pensione o licenziato non si può modificare
    /// cancella sia della nave e del comandante
    /// salvattaggio e apertura file
    /// </summary>
    public partial class MainWindow : Window
    {
        Flotta flotta;
        public MainWindow(string s)
        {
            InitializeComponent();
            flotta = new Flotta();
            if (s != "")
            {
                flotta.Nomeflotta = s;
                Title += "." + flotta.Nomeflotta;
            }
            else
                btnapri_Click(null, null);
        }

        private void btnaddnave_Click(object sender, RoutedEventArgs e)
        {//aggiunta nave
            WindowNave form = new WindowNave();
            form.ShowDialog();
            Nave n;
            int i;
            if ((bool)form.DialogResult)//controllo se input corretto
            {
                n = form.Nave;
                i = flotta.Ricercanav(n.Nome);//no omonimi
                if (i == -1)
                {
                    flotta.Addnave(n);
                    aggiornaliste();
                }
                else
                    MessageBox.Show("Elemento già presente", "Impossibile", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }
        private void btnaddcomandante_Click(object sender, RoutedEventArgs e)
        {//aggiunta comandante
            Windowcomandante form = new Windowcomandante();
            form.ShowDialog();
            Comandante c;
            int i;
            if ((bool)form.DialogResult)//controllo se input corretto
            {
                c = form.Comandante;
                i = flotta.Ricercacom(c.Nome);//no omonimi
                if (i == -1)
                {
                    flotta.Addcomandante(c);
                    aggiornaliste();
                }
                else
                    MessageBox.Show("Elemento già presente", "Impossibile", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }

        private void listboxnavi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {//modifica e cancella della nave
            int i = listboxnavi.SelectedIndex;
            if(i!=-1)
            {
                if (flotta.controllonave(flotta.listnavi[i]))//controllo se si possono effettuare modifiche
                {
                    Nave n = flotta.GetNave(i);
                    WindowNave form = new WindowNave(n);
                    form.ShowDialog();
                    if (form.DialogResult == true)
                    {
                        if (form.Nave != null)
                            flotta.listnavi[i] = form.Nave;//modifica
                        else
                            flotta.removenav(n);//rimozione
                        aggiornaliste();
                    }
                }
                else
                    MessageBox.Show("La nave ha un incarico assegnato", "Impossibile", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void listboxcomandanti_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {//modifica e cancella del comandante
            int i = listboxcomandanti.SelectedIndex;
            if(i!=-1)
            {
                if (flotta.controllocom(flotta.listcomandanti[i]))//controllo se si possono effettuare modifiche
                {
                    Comandante c = flotta.GetComandante(i);
                    Windowcomandante form = new Windowcomandante(c);
                    form.ShowDialog();
                    if (form.DialogResult == true)
                    {
                        if (form.Comandante != null)
                            flotta.listcomandanti[i] = form.Comandante;//modifica
                        else
                            flotta.removecom(c);//rimozione
                        aggiornaliste();
                    }
                }
                else
                    MessageBox.Show("Il comandante ha un incarico assegnato","Impossibile",MessageBoxButton.OK,MessageBoxImage.Error);

            }
        }
        private void aggiornaliste()//aggiornamento listbox dopo modifiche ad una lista
        {
            Title = "Flotta."+flotta.Nomeflotta;
            listboxnavi.ItemsSource = null;
            listboxnavi.ItemsSource = flotta.listnavi;
            listboxcomandanti.ItemsSource = null;
            listboxcomandanti.ItemsSource = flotta.listcomandanti;
            listboxincarichi.ItemsSource = null;
            listboxincarichi.ItemsSource = flotta.listincarichi;
        }

        private void btncreaincarico_Click(object sender, RoutedEventArgs e)
        {//crea incarico
            List<Nave> listnavi = flotta.NaviLibere;
            List<Comandante> listcom = flotta.ComandantiLiberi;
            if (listcom.Count != 0 && listnavi.Count != 0)
            {
                WindowIncarichi form = new WindowIncarichi(listcom, listnavi);
                form.ShowDialog();
                if ((bool)form.DialogResult)
                {
                    flotta.Addincarico(form.Incarico);
                    aggiornaliste();
                }
            }
            else
                MessageBox.Show("Impossibile creare incarico, non ci sono navi e/o comandanti liberi", "Impossibile", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void listboxincarichi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {//terminazione incarico
            int i = listboxincarichi.SelectedIndex;
            if (i != -1)
            {
                if (flotta.listincarichi[i].DataFine == default(DateTime))
                {
                    WindowModificaIncarico form = new WindowModificaIncarico(flotta.listincarichi[i]);
                    form.ShowDialog();
                    if ((bool)form.DialogResult)
                    {
                        aggiornaliste();
                    }
                }
                else
                    MessageBox.Show("Incarico già terminato", "Impossibile", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnsalva_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.DefaultExt = ".flf"; 
            dlg.Filter = "Flotta documents (.flf)|*.flf";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                SerializzatoreBINARY serBin = new SerializzatoreBINARY(filename, flotta );
                serBin.Serializza();
                MessageBoxResult ris=MessageBox.Show("Vuoi chiudere questa flotta?","Chiusura", MessageBoxButton.YesNo);
                if(ris==MessageBoxResult.Yes)
                {
                    Windowopen win = new Windowopen();
                    this.Close();//chiusura finestra
                    win.Show();//avvio nuovo finestra
                }

            }
        }

        private void btnapri_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".flf"; 
            dlg.Filter = "Flotta documents (.flf)|*.flf";
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                SerializzatoreBINARY serBin = new SerializzatoreBINARY(filename, flotta);
                flotta = (Flotta)serBin.DeSerializza();
                aggiornaliste();
            }
        }
    }
}

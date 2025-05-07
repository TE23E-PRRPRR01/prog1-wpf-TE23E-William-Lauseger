using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KontaktApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        // skriv ut titel, förnamn och efternamn
        string titel = txbTitel.Text;
        string förnamn = txbFörnamn.Text;
        string efternamn = txbEfternamn.Text;

        // Lägg till ålder
        string ålderText = txbÅlder.Text;

        // Kolla om användaren har skrivit herr/fru
        if (titel != "Herr" && titel != "Fru")
        {
            txbResultat.Text = "Felaktig titel! Ange Herr eller Fru";
        }
        else
        {
           bool success = int.TryParse(ålderText, out int ålder);
           if (success)
           {
                txbResultat.Text = $"Titel: {titel}\n Förnamn: {förnamn}\n Efternamn: {efternamn}\n Ålder: {ålder}\n";
           }
           else
           {
                txbResultat.Text = "Ålder saknas!";
           }
        }
    }
    
}
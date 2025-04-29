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

namespace NamnApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickKör(object sender, RoutedEventArgs e)
    {
        // Läs av förnamn
        string förnamn = txbFörnamn.Text;
        string Efternamn = txbEfternamn.Text;

        // Plocka fram initialen
        char initial = förnamn[0];
        char initial2 = Efternamn[0];

        // Skriv ut initialen
        // "Initialen är x."
        txbResultat.Text = $"Initialen är {initial}.{initial2}.";
    }
}
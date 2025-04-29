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

namespace BokstavsApp;

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
        // Läs av förnamn
        string förnamn = txbNamn.Text;
        string index = txbIndex.Text;

        // Omvandla index till tal
        int.TryParse(index, out int indexTal);

        // Ta fram bokstav
        char namn = förnamn[indexTal];

        // Skriv ut index
        txbResultat.Text = $"Bokstaven i {förnamn} på index {indexTal} är {namn}";
    }
}
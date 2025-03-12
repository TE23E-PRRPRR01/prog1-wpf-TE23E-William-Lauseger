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

namespace JulklappsApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // våra variablar
    int maxJulklappar = 0;
    List<string> listajulklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        // Koppla list till listbox
        lsbJulklappar.ItemsScourse = listajulklappar;

        // Lås gränssnitt
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;
    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        // läs av rutan
        string antal = txbAntal.Text;

        // första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "Vg ange ett heltal!";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";

                // Lås gränssnitt
                stpMax.IsEnabled = false;
                stpInmatning.IsEnabled = true;
                stpListan.IsEnabled = true;
            }
            else
            {
                txbStatus.Text = "Vg ange ett heltal!";
            }
        }
    }

    private void KlickLäggtill(object sender, RoutedEventArgs e)
    {
        // Läs av textrutorna
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text;

        listajulklappar.Add($"{julklapp} till {mottagare}");
        lsbJulklappar.Items.Refresh();

    }

    private void KlickBytut(object sender, RoutedEventArgs e)
    {

    }
}
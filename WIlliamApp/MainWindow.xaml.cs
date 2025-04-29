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

namespace WIlliamApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickJämför(object sender, RoutedEventArgs e)
    {
        // Läs av textrutorna
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // Omvandla till heltal
        int.TryParse(tal1, out int heltal1);  
        int.TryParse(tal2, out int heltal2);  

        // Jämför talen
        if (heltal1 > heltal2)
        {
            txbResultat.Text = $"{tal1} är störst";
        }
        else if (heltal2 > heltal1)
        {
            txbResultat.Text = $"{tal2} är störst";
        }
        else
        {
            txbResultat.Text = "Talen är lika";
        }
    }
}
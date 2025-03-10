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

namespace BrannbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Skapa variablerna för lagen
    int poänginne = 0;
    int poängute = 0;

    public MainWindow()
    {
        InitializeComponent();

    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {

        // Lägg till 5 poäng
        poänginne += 5;

        // Skriv ut poängen
        txbInne.Text = $"{poänginne}";

        // Vad är klockan
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistorik.Text += $"\n{nu.ToString("HH:mm:ss")} Lag inne +5, Totalt: {poänginne}";
    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        
        // Lägg till 2 poäng
        poängute += 2;

        // Skriv ut poängen
        txbUte.Text = $"{poängute}";

        // Vad är klockan
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistorik.Text += $"\n{nu.ToString("HH:mm:ss")} Lag ute +2, Totalt: {poängute}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        
        // Lägg till 3 poäng
        poängute += 3;

        // Skriv ut poängen
        txbUte.Text = $"{poängute}";

        // Vad är klockan
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistorik.Text += $"\n{nu.ToString("HH:mm:ss")} Lag ute +3, Totalt: {poängute}";
    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        
        // Lägg till 1 poäng
        poänginne += 1;

        // Skriv ut poängen
        txbInne.Text = $"{poänginne}";

        // Vad är klockan
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistorik.Text += $"\n{nu.ToString("HH:mm:ss")} Lag inne +1, Totalt: {poänginne}";
    }
}
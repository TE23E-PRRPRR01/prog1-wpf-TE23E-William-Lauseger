using System.Net.Http;
using System.Security.Cryptography.Xml;
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

namespace KrypterarApp;

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
        // Stoppa in och skriv ut text
        string inputText = txbInput.Text;

        // Läs in nyckeln
        string nyckelText = txbNyckel.Text;

        // Omvandla nyckeln till tal
        bool ok = int.TryParse(nyckelText, out int nyckel);

        // Rensa txbOutput
        txbOutput.Clear();

        // Skriv if sats för att kolla om ok är sant och att nyckeln är mellan 1-25
        if (!ok || nyckel < 1 || nyckel > 25)
        {
            txbOutput.Text = "Nyckeln måste vara ett heltal mellan 1 och 9.";
            return;
        }

        // Skapa foreach loop som går igenom tecken
        foreach (var bokstav in inputText)
        {
            // Lägg till ASCII-värde och kryptering
            int ascii = (int)bokstav;
            int krypteradAscii = ascii + nyckel;
            char bokstavKrypterad = (char)krypteradAscii;

            // Bearbetning av tecknet c
            txbOutput.Text += $"{bokstavKrypterad}";

            // Loopa alla tecken
            if (char.IsLetter(bokstav))
            {
                txbOutput.Text += "#";
            }
            else
            {
                //krypterad += bokstav;
            }

            // 
        }
    }
}
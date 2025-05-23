﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Slumpa fram ett tal 1-1000
    int slumptal = Random.Shared.Next(1, 1001);
    List<int> listaGissningar = [];

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        // Läs av ruta gissning
        string input = txbGissning.Text;

        // konvertera till ett heltal
        bool lyckades = int.TryParse(input, out int gissning);

        // Lyckades konverteringen?
        if (lyckades)
        {
            // Lagra i listan
            listaGissningar.Add(gissning);

            // Jämföra gissning med slumptal
            if (gissning == slumptal)
            {
                txbResultat.Text = $"Din gissning var rätt ({gissning})";
            }
            else if (gissning > slumptal)
            {
                txbResultat.Text = $"Din gissning var hög ({gissning})";
            }
            else
            {
                txbResultat.Text = $"Din gissning var för låg ({gissning})";
            }
        }
        else
        {
            txbResultat.Text = "Ogiltig inmatning. Vg försök igen!";
        }
    }

    private void KlickFacit(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = $"Rätt svar är {slumptal}";
    }

    private void KlickGissningar(object sender, RoutedEventArgs e)
    {
        // Skriv ut alla gissningar som finns i listan
        // Istora rutan txbHistorik
        foreach (var tal in listaGissningar)
        {
            txbHistorik.Text += $"{tal}\n";
        }
    }

    private void KlickSpelaigen(object sender, RoutedEventArgs e)
    {
        slumptal = Random.Shared.Next(1, 1001);

        listaGissningar = [];

        // Rensa Gränssnittet
        txbGissning.Text = "";
        txbResultat.Text = "";
        txbGissningar.Text = "";
    }
}
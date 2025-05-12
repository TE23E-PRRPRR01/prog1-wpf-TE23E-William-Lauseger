using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodApp;

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
        // Omvandla tid till int och skriv ut resten
        string namn = txbNamn.Text;
        string ingrediens = txbIngredienser.Text;
        string tidText = txbTid.Text;
        int.TryParse(tidText, out int tid);

        // Skriv ut resultatet

        // Om huvudingrediensen inte är fisk eller kött ska det stå obs ovanlig ingrediens
        if (ingrediens == "Kött" || ingrediens == "Fisk" || ingrediens == "fisk" || ingrediens == "kött")
        {
            txbResultat.Text = $" Namn: {namn}\n Ingrediens: {ingrediens}\n Tid: {tid} min \n";
        }
        else
        {
            txbResultat.Text = $" Namn: {namn}\n Ingrediens: {ingrediens}\n Tid: {tid} min \n OBS! Ovanlig ingrediens \n";
        }
    }

    // Rensa alla fält
    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = "";
    }

    List<String> receptLista = [];

    private void KlickSpara(object sender, RoutedEventArgs e)
    {
        receptLista.Add(txbResultat.Text);
        txbAntal.Text = $"Antal recept: {receptLista.Count}";
    }
}
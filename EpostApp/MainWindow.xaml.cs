using System.Net;
using System.Net.Mail;
using System.Windows;

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        // Läs av epost & meddelande
        string epost = txbEpost.Text;
        string meddelande = txbMeddelande.Text;

        // Koppla upp på en mail server
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("user", "xxx");

        // Sanitycheck
        if (epost != "" && meddelande != "")
        {
            smtp.Send("", epost, "Epost från appen", "meddelande");
            lblStatus.Content = "Meddelandet har skickats";
        }
        else
        {
            lblStatus.Content = "Fel! Något av fälten är tomma.";

        }
    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        // Läs av epost & meddelande
        string epost = txbEpost.Text;
    }
}
using System.Windows;

namespace myGisApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button_EXIT_Click(object sender, RoutedEventArgs e)
    {
        // Close the application
        this.Close();
    }

    private void button_TAMAM_Click(object sender, RoutedEventArgs e)
    {
        string ad = textBox_AD.Text;
        string soyad = textBox_SOYAD.Text;

        if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
        {
            MessageBox.Show("Lütfen ad ve soyad giriniz.", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        else
        {
            label_MERHABA.Visibility = Visibility.Visible;
            label_MERHABA.Content = $"Merhaba {ad} {soyad}";
        }
    }



}
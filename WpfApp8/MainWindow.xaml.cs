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

namespace WpfApp8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SprawdzCeneButton_Click(object sender, RoutedEventArgs e)
        {
            string cenaTekst = "";
            string obrazSciezka = "";

            if (PocztowkaRadio.IsChecked == true)
            {
                cenaTekst = "Cena: 1 zł";
                obrazSciezka = "https://png.pngtree.com/png-clipart/20230924/original/pngtree-secure-package-delivery-with-shield-symbol-track-order-and-guarantee-protection-png-image_12750239.png";
            }
            else if (ListRadio.IsChecked == true)
            {
                cenaTekst = "Cena: 1,5 zł";
                obrazSciezka = "https://e7.pngegg.com/pngimages/558/425/png-clipart-money-bag-money-bag-desktop-wallpaper-bag.png";
            }
            else if (PaczkaRadio.IsChecked == true)
            {
                cenaTekst = "Cena: 10 zł";
                obrazSciezka = "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/55/5515732/Konsola-przenosna-VALVE-Steam-Deck-512-GB-front-skos-01.jpg";
            }
            CenaLabel.Content = cenaTekst;
            Obrazek.Source = new BitmapImage(new Uri(obrazSciezka));
        }
        private void ZatwierdzButton_Click(object sender, RoutedEventArgs e)
        {
            string kodPocztowy = KodPocztowyTextBox.Text;
            if (kodPocztowy.Length != 5)
            {
                MessageBox.Show("Nieprawidłowy kod pocztowy", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
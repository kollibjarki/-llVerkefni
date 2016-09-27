using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaxiStation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Taxi> _taxies;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _taxies = new ObservableCollection<Taxi>();
            _taxies.Add(new Taxi(1500, "Toyota", "Pétur"));
            _taxies.Add(new Taxi(1501, "Ford", "Guðrún"));
            _taxies.Add(new Taxi(1502, "VW", "Hugrún"));
            _taxies.Add(new Taxi(1503, "Honda", "Samir"));
            _taxies.Add(new Taxi(1504, "Toyota", "Albert"));

            lstTaxis.ItemsSource = _taxies;
        }

        private void btnAddDriver_Click(object sender, RoutedEventArgs e)
        {
            Taxi taxi = new Taxi(
                Convert.ToInt32(txtTaxiNr.Text),
                txtTaxiName.Text,
                txtTaxiCar.Text);
            _taxies.Add(taxi);
        }
    }
}

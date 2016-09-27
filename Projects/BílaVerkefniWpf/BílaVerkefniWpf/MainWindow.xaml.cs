using System;
using System.Collections.Generic;
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

namespace BílaVerkefniWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car bill;
        public MainWindow()
        {
            InitializeComponent();

            bill = new Car();
        }

        private void fletta_Click(object sender, RoutedEventArgs e)
        {
            var billnumer = carnumber.Text;

            Car car = bill.fletta(billnumer);

            _1.Text = car.convertToUtf8(car.type);
            _2.Text = car.convertToUtf8(car.subType);
            _3.Text = car.convertToUtf8(car.color);
            _4.Text = car.convertToUtf8(car.registryNumber);
            _5.Text = car.convertToUtf8(car.number);
            _6.Text = car.convertToUtf8(car.factoryNumber);
            _7.Text = car.convertToUtf8(car.registeredAt);
            _8.Text = car.convertToUtf8(car.pollution);
            _9.Text = car.convertToUtf8(car.weight);
            _10.Text = car.convertToUtf8(car.status);
            _11.Text = car.convertToUtf8(car.nextCheck);


            
        }

        private void Loka_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            carnumber.Text = String.Empty;
            _1.Text = String.Empty;
            _2.Text = String.Empty;
            _3.Text = String.Empty;
            _4.Text = String.Empty;
            _5.Text = String.Empty;
            _6.Text = String.Empty;
            _7.Text = String.Empty;
            _8.Text = String.Empty;
            _9.Text = String.Empty;
            _10.Text = String.Empty;
            _11.Text = String.Empty;
        }
    }
}

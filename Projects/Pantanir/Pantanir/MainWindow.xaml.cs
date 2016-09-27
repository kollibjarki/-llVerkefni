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

namespace Pantanir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PantanirRepository _pantanir = new PantanirRepository();

        public MainWindow()
        {
            InitializeComponent();
            lstPantanir.ItemsSource = _pantanir.GetAllPantanir();
        }

        private void btnNyr_Click(object sender, RoutedEventArgs e)
        {
            DateTime afhd = Convert.ToDateTime(txtVvAfhd.Text);
            _pantanir.AddPontun(txtVvNafn.Text, txtVvKt.Text, afhd, txtVvAfhm.Text);
            lstPantanir.ItemsSource = _pantanir.GetAllPantanir();

            txtVvNafn.Clear();
            txtVvKt.Clear();
            txtVvAfhd.Clear();
            txtVvAfhm.Clear();
        }

        private void btnNyVorulina_Click(object sender, RoutedEventArgs e)
        {
            int stuff = _pantanir.AddVorulina(
                txtVoruheiti.Text,
                Convert.ToSingle(txtVerd.Text),
                Convert.ToSingle(txtFjoldi.Text),
                Convert.ToInt32(txtNrPontunar.Text)
                );
            //lstVorulinur.ItemsSource = _pantanir.GetAllVoulinurForPontun(Convert.ToInt32(txtNrPontunar.Text));
            lstVorulinur.ItemsSource = _pantanir.GetAllVorulinur();
            

            txtVoruheiti.Clear();
            txtVerd.Clear();
            txtFjoldi.Clear();
        }

        private void txtNrPontunar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstVorulinur.ItemsSource = _pantanir.GetAllVorulinur();
        }
    }
}

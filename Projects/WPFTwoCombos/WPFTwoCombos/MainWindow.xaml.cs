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

namespace WPFTwoCombos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MockRepository _repo;
        public MainWindow()
        {
            InitializeComponent();
            _repo = new MockRepository();

            cboFraml.ItemsSource = _repo.GetFramleidendur();
        }

        private void cboFraml_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            Framleidandi f = comboBox.SelectedItem as Framleidandi;

            cboTeg.ItemsSource = _repo.GetTegundirByFramlId(f.Id);

        }
    }
}

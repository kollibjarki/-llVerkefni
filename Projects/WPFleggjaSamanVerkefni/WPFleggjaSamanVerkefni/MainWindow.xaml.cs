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

namespace WPFleggjaSamanVerkefni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var firstnumber = Convert.ToInt32(FirstNumber.Text);
            var secondnumber = Convert.ToInt32(FirstNumber2.Text);
            int finalcal = firstnumber + secondnumber;
            textBox2.Text = Convert.ToString(finalcal);
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var firstnumber = Convert.ToInt32(FirstNumber.Text);
            var secondnumber = Convert.ToInt32(FirstNumber2.Text);
            int finalcal = firstnumber * secondnumber;
            textBox2.Text = Convert.ToString(finalcal);
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            var firstnumber = Convert.ToInt32(FirstNumber.Text);
            var secondnumber = Convert.ToInt32(FirstNumber2.Text);
            int finalcal = firstnumber + secondnumber;
            textBox2.Text = Convert.ToString(finalcal);
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            var firstnumber = Convert.ToInt32(FirstNumber.Text);
            var secondnumber = Convert.ToInt32(FirstNumber2.Text);
            int finalcal = firstnumber - secondnumber;
            textBox2.Text = Convert.ToString(finalcal);
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            var firstnumber = Convert.ToInt32(FirstNumber.Text);
            var secondnumber = Convert.ToInt32(FirstNumber2.Text);
            int finalcal = firstnumber / secondnumber;
            textBox2.Text = Convert.ToString(finalcal);
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            var firstnumber = Convert.ToInt32(FirstNumber.Text);
            var secondnumber = Convert.ToInt32(FirstNumber2.Text);
            int finalcal = firstnumber * secondnumber;
            textBox2.Text = Convert.ToString(finalcal);
        }
    }
}

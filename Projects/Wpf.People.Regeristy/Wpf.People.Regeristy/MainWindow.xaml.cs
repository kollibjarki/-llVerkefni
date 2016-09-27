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
using Wpf.People.Regeristy.PeopleRegistryDataSet1TableAdapters;

namespace Wpf.People.Regeristy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            update();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            PeopleTableAdapter pta = new PeopleTableAdapter();
            pta.Insert(textBox_name.Text, textBox_phone.Text);
            update();
            textBox_name.Clear();
            textBox_phone.Clear();
            textBox_name.Focus();


        }

        private void update()
        {
            PeopleTableAdapter pta = new PeopleTableAdapter();
            lstPeople.ItemsSource = pta.GetData();
            
        }



        private void button_Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

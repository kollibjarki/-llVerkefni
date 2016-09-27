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
using WPF.data.Innkaupalisti.VörulistiDataSet1TableAdapters;

namespace WPF.data.Innkaupalisti
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int linuverd = Convert.ToInt32(textBox_Fjöldi.Text) * Convert.ToInt32(textBox_verð.Text);

            textBox_Linuverð.Text = Convert.ToString(linuverd);

            VörulistiTableAdapter vta = new VörulistiTableAdapter();
            vta.Insert(textBox_voruheiti.Text, textBox_Fjöldi.Text, textBox_verð.Text, textBox_Linuverð.Text);

           


        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox_voruheiti.Clear();
            textBox_verð.Clear();
            textBox_Fjöldi.Clear();
            textBox_Linuverð.Clear();
            textBox_voruheiti.Focus();
        }

        private void button_quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

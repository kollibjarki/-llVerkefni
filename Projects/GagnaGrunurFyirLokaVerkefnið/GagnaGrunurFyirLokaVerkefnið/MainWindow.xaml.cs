using GagnaGrunurFyirLokaVerkefnið.StaðirlOGLandshlutarTableAdapters;
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

namespace GagnaGrunurFyirLokaVerkefnið
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

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    StadirTableAdapter LTA = new StadirTableAdapter();

            //    LTA.Insert(textBox_nafn.Text, textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text),
            //        Convert.ToDouble(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));

            //    kunni.Content = "Success";

            //}
            //catch (Exception)
            //{
            //    kunni.Content = "reyndu aftur!";

            //}
            StadirTableAdapter LTA = new StadirTableAdapter();

            LTA.Insert(textBox_nafn.Text, textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text),
                textBox5.Text , Convert.ToDouble(textBox6.Text), Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));

            kunni.Content = "Success";
        }

        private void button_c_Click(object sender, RoutedEventArgs e)
        {
            textBox_nafn.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            kunni.Content = "";


        }
    }
}

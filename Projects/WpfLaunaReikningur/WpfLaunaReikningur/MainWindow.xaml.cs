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

namespace WpfLaunaReikningur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Laun Salary;

        public MainWindow()
        {
            InitializeComponent();

            Salary = new Laun();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void laun_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (laun.Text == "")
            {
                laun.Text =Convert.ToString("");
                

            }
            else
            {
                Salary.manadarlaun = Convert.ToDouble(laun.Text);
                orlof.Text = Salary.Calculate2().ToString();
                LaunEs.Text = Salary.Calculate3().ToString();
                HeildF.Text = Salary.Calculate4().ToString();
            }
            
        }

        private void orlof_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Salary.orlof = Convert.ToDouble(laun.Text);
            //orlof.Text = Salary.Calculate2().ToString();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Salary.launfradrattur = Convert.ToDouble(HeildF);
            //HeildF.Text = Salary.Calculate4().ToString(); 
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var utborgunFS      = Convert.ToInt32(laun.Text);
            var Fradrattur      = Convert.ToInt32(HeildF.Text);
            int LokaUtborgun    = utborgunFS - Fradrattur;
            utborgun.Text       = Convert.ToString(LokaUtborgun);
        }

       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

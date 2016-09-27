using Pantanir.VerslunarPöntunTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
        public MainWindow()
        {
            InitializeComponent();
            Update();

        }

        private void button_skra_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PontunarLinurTableAdapter ppta = new PontunarLinurTableAdapter();

                ppta.Insert(Convert.ToString(textBox_VH.Text), Convert.ToInt32(textBox_verd.Text), Convert.ToInt32(textBox_fjoldi.Text), Convert.ToInt32(textBox_PID.Text));
                Update();
                kunni.Content = "Pöntun Skráð!";
            }

            catch (Exception)
            {
                kunni.Content = "Pöntun Mistókst reyndu aftur!";

            }
            

          

        }

        private void button_hreinsa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox_fjoldi.Clear();
                textBox_VV.Clear();
                textBox_GS.Clear();
                textBox_VH.Clear();
                textBox_verd.Clear();
                textBox_PID.Clear();
                textBox_KTVV.Clear();
                kunni.Content = "";
                //textBox_KTVV.Focus();

                Vidskiptavinur.UnselectAll();
            }

            catch (Exception)
            {
                kunni.Content = "Ekki Tókst að hreinsa lista";
            }


        }

        private void ___quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PantanirTableAdapter Pta = new PantanirTableAdapter();
                Pta.Insert(textBox_VV.Text, textBox_KTVV.Text, Convert.ToDateTime(textBox_GS.Text), comboBox_AFM.Text);

                kunni.Content = "Viðskipavinur skráður!";
                Update();
            }

            catch (Exception)
            {
                kunni.Content = "Ekki tókst að ská viðskiptavin";
            }
        }

        private void Update()
        {
            PantanirTableAdapter pta = new PantanirTableAdapter();
            PontunarLinurTableAdapter Pta = new PontunarLinurTableAdapter();

            Vidskiptavinur.ItemsSource = pta.GetData();
            Pantanir.ItemsSource = Pta.GetData();

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            


        }

        private void textBox_PID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox_PID.Text != "")
            {
                try
                {
                    PontunarLinurTableAdapter plta = new PontunarLinurTableAdapter();


                    var rows = from row in plta.GetData()
                               where row.PontunId.Equals(Convert.ToInt32(textBox_PID.Text))
                               select row;

                    VerslunarPöntun.PontunarLinurDataTable pldt = new VerslunarPöntun.PontunarLinurDataTable();
                    rows.CopyToDataTable(pldt, LoadOption.OverwriteChanges);
                    Pantanir.ItemsSource = pldt;
                }

                catch (Exception)
                {
                    kunni.Content = "KerfisVilla Vinsamlegast lagið";
                }
            }

        }

        private void button_EP_Click(object sender, RoutedEventArgs e)
        {
            PontunarLinurTableAdapter plta = new PontunarLinurTableAdapter();
            plta.DeleteById(Convert.ToInt32(ID.Text));
            Update();
          
        }

        private void Pantanir_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void textBox_GS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

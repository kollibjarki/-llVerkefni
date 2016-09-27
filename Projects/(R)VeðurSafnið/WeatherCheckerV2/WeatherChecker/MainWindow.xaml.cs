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
using System.Xml;

namespace WeatherChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string basicTextPath = "http://xmlweather.vedur.is/?op_w=xml&type=txt&lang=is&view=xml&ids=";
        public string textPathNumber, textPathNumber2;

        private void textaspaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void landhlutaMyndirCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public class MyndaListaData
        {
            public string Photo { get; set; }
            public string Name { get; set; }
        }
        List<MyndaListaData> LandshlutaMyndaListi = new List<MyndaListaData>();

        public MainWindow()
        {
            InitializeComponent();


            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_isl.gif", Name = "Allt Landið" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "Reykjavik.10.gif", Name = "Höfuðborgarsvæðið" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_su.gif", Name = "Suðurland" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_fa.gif", Name = "Faxaflói" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_br.gif", Name = "Breiðafjörður" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_vf.gif", Name = "Vestfirðir" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_nv.gif", Name = "Strandir og Norðurland vestra" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_na.gif", Name = "Norðurland eystra" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_al.gif", Name = "Austurland að Glettingi" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_af.gif", Name = "Austfirðir" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_sa.gif", Name = "Suðausturland" });
            LandshlutaMyndaListi.Add(new MyndaListaData { Photo = "wmap_mh.gif", Name = "Miðhálendið" });
            landhlutaMyndirCombobox.ItemsSource = LandshlutaMyndaListi;
            landhlutaMyndirCombobox.SelectedIndex = 0;

        }

        private void getTextaspaButton_Click(object sender, RoutedEventArgs e)
        {
            if (textaspaComboBox.SelectedIndex == 0)
            {
                textPathNumber = "2";
            }
            else if (textaspaComboBox.SelectedIndex == 1)
            {
                textPathNumber = "3";
            }
            else if (textaspaComboBox.SelectedIndex == 2)
            {
                textPathNumber = "31";
            }
            else if (textaspaComboBox.SelectedIndex == 3)
            {
                textPathNumber = "32";
            }
            else if (textaspaComboBox.SelectedIndex == 4)
            {
                textPathNumber = "33";
            }
            else if (textaspaComboBox.SelectedIndex == 5)
            {
                textPathNumber = "34";
            }
            else if (textaspaComboBox.SelectedIndex == 6)
            {
                textPathNumber = "35";
            }
            else if (textaspaComboBox.SelectedIndex == 7)
            {
                textPathNumber = "36";
            }
            else if (textaspaComboBox.SelectedIndex == 8)
            {
                textPathNumber = "37";
            }
            else if (textaspaComboBox.SelectedIndex == 9)
            {
                textPathNumber = "38";
            }
            else if (textaspaComboBox.SelectedIndex == 10)
            {
                textPathNumber = "39";
            }
            else if (textaspaComboBox.SelectedIndex == 11)
            {
                textPathNumber = "30";
            }

            string completeTextPath = basicTextPath + textPathNumber;
            XmlDocument xmlTextaspa = new XmlDocument();
            xmlTextaspa.Load(completeTextPath);

            XmlNodeList     description = xmlTextaspa.GetElementsByTagName("content"),
                            title = xmlTextaspa.GetElementsByTagName("title"),
                            descriptionCreation = xmlTextaspa.GetElementsByTagName("creation"),
                            descriptionValidFrom = xmlTextaspa.GetElementsByTagName("valid_from"),
                            descriptionValidTo = xmlTextaspa.GetElementsByTagName("valid_to");
            string timeCreated1 = (descriptionCreation[0].InnerXml).ToString().Substring(5, 11);
            
            spa1.Text = (title[0].InnerXml);

            var Createdtime = DateTime.Parse(descriptionCreation[0].InnerXml);
            var timeNow = DateTime.Now;
            var differenceInTime = (Createdtime - timeNow).TotalHours;
            string diff = differenceInTime.ToString().Substring(0, 5);
            descriptionInfoBox.Text = "Spá birt á neti fyrir " + diff + " klst. síðan.";

            textDescriptionBox.Text = (description[0].InnerXml);
        }

        private void textDescriptionBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void getMapButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void getTextspa2Button_Click(object sender, RoutedEventArgs e)
        {
            if (textaspaComboBox2.SelectedIndex == 0)
            {
                textPathNumber = "2";
            }
            else if (textaspaComboBox2.SelectedIndex == 1)
            {
                textPathNumber = "3";
            }
            else if (textaspaComboBox2.SelectedIndex == 2)
            {
                textPathNumber = "31";
            }
            else if (textaspaComboBox2.SelectedIndex == 3)
            {
                textPathNumber = "32";
            }
            else if (textaspaComboBox2.SelectedIndex == 4)
            {
                textPathNumber = "33";
            }
            else if (textaspaComboBox2.SelectedIndex == 5)
            {
                textPathNumber = "34";
            }
            else if (textaspaComboBox2.SelectedIndex == 6)
            {
                textPathNumber = "35";
            }
            else if (textaspaComboBox2.SelectedIndex == 7)
            {
                textPathNumber = "36";
            }
            else if (textaspaComboBox2.SelectedIndex == 8)
            {
                textPathNumber = "37";
            }
            else if (textaspaComboBox2.SelectedIndex == 9)
            {
                textPathNumber = "38";
            }
            else if (textaspaComboBox2.SelectedIndex == 10)
            {
                textPathNumber = "39";
            }
            else if (textaspaComboBox2.SelectedIndex == 11)
            {
                textPathNumber = "30";
            }

            string completeTextPath = basicTextPath + textPathNumber;
            XmlDocument xmlTextaspa = new XmlDocument();
            xmlTextaspa.Load(completeTextPath);

            XmlNodeList     description = xmlTextaspa.GetElementsByTagName("content"),
                            title = xmlTextaspa.GetElementsByTagName("title"),
                            descriptionCreation = xmlTextaspa.GetElementsByTagName("creation"),
                            descriptionValidFrom = xmlTextaspa.GetElementsByTagName("valid_from"),
                            descriptionValidTo = xmlTextaspa.GetElementsByTagName("valid_to");

            textDescriptionBox2.Text = (description[0].InnerXml);
            spa2.Text = (title[0].InnerXml);

            var Createdtime = DateTime.Parse(descriptionCreation[0].InnerXml);
            var timeNow = DateTime.Now;
            var differenceInTime = (Createdtime - timeNow).TotalHours;
            string diff = differenceInTime.ToString().Substring(0, 5);
            descriptionInfoBox2.Text = "Spá skrifuð fyrir " + diff + " klst. síðan.";

        }
    }
}

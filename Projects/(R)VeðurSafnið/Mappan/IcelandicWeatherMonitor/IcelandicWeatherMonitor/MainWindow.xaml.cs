using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml;

namespace IcelandicWeatherMonitor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region ---------------         Ná Í KORT StuFferí      ---------        OpenStreetMaps          -----------

        SampleApp.MainWindow kort;
        //Er kort Þegar opið doterí
        public static T IsWindowOpen<T>(string name = null) where T : Window
        {
            var windows = Application.Current.Windows.OfType<T>();
            return string.IsNullOrEmpty(name) ? windows.FirstOrDefault() : windows.FirstOrDefault(w => w.Name.Equals(name));
        }
        //Ef Map er opið þá  on Map annars Get Map
        private void getMapButton_Click(object sender, RoutedEventArgs e)
        {
            var kort = IsWindowOpen<Window>("Kortagluggi");
            if (kort != null)
            {
                kort.Show();
                kort.Focus();
            }
            else
            {
                this.kort = new SampleApp.MainWindow { Name = "Kortagluggi", Title = "VeðurApp Kortasýn", };
                this.kort.Show();
            }

        }

        //ToggleButton Kortagluggi AlwaysOnTop False = Grey
        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            if (kort == null)
            {
                this.kort = new SampleApp.MainWindow { Name = "Kortagluggi", Title = "VeðurApp Kortasýn", };
                kort.Topmost = false;
            }
            kort.Topmost = false;
            kort.Focus();
        }
        //ToggleButton Kortagluggi AlwaysOnTop True = Blue
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            if (kort == null)
            {
                this.kort = new SampleApp.MainWindow { Name = "Kortagluggi", Title = "VeðurApp Kortasýn", };
                kort.Topmost = true;
            }
            kort.Topmost = true;


        }

        #endregion


        #region --------------       Ná í Textaspár Stuff Og með fylgjandi Landshlutamynd  -----------------------------------
        public string basicTextPath = "http://xmlweather.vedur.is/?op_w=xml&type=txt&lang=is&view=xml&ids=";
        public string textPathNumber, textPathNumber2;
        //nú væro gott að kalla bara á class.... þaggi

        //takki númeró uno í Tab 1
        private void getTextspa1Button_Click(object sender, RoutedEventArgs e)
        {
            if (textaspaComboBox1.SelectedIndex == 0)
            {
                textPathNumber = "2";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_isl_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_isl.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 1)
            {
                textPathNumber = "3";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_su_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_su.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 2)
            {
                textPathNumber = "31";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_fa_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_fa.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 3)
            {
                textPathNumber = "32";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_br_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_br.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 4)
            {
                textPathNumber = "33";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_vf_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_vf.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 5)
            {
                textPathNumber = "34";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_nv_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_nv.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 6)
            {
                textPathNumber = "35";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_na_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_na.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 7)
            {
                textPathNumber = "36";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_al_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_al.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 8)
            {
                textPathNumber = "37";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_af_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_af.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 9)
            {
                textPathNumber = "38"; if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_sa_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_sa.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 10)
            {
                textPathNumber = "39";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_ho_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_ho.gif", UriKind.Relative));

            }
            else if (textaspaComboBox1.SelectedIndex == 11)
            {
                textPathNumber = "30";
                if (invertMap1.IsChecked == true)
                {
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_mh_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd1.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_mh.gif", UriKind.Relative));

            }

            string completeTextPath = basicTextPath + textPathNumber;
            XmlDocument xmlTextaspa = new XmlDocument();
            xmlTextaspa.Load(completeTextPath);

            XmlNodeList description = xmlTextaspa.GetElementsByTagName("content"),
                            title = xmlTextaspa.GetElementsByTagName("title"),
                            descriptionCreation = xmlTextaspa.GetElementsByTagName("creation"),
                            descriptionValidFrom = xmlTextaspa.GetElementsByTagName("valid_from"),
                            descriptionValidTo = xmlTextaspa.GetElementsByTagName("valid_to");

            textDescriptionBox1.Text = (description[0].InnerXml);
            spa1.Text = (title[0].InnerXml);

            var Createdtime = DateTime.Parse(descriptionCreation[0].InnerXml);
            var timeNow = DateTime.Now;
            var differenceInTime = (Createdtime - timeNow).TotalHours;
            string diff = differenceInTime.ToString().Substring(0, 5);
            descriptionInfoBox1.Text = "Spá skrifuð fyrir " + diff + " klst. síðan.";

        }

        //takki númeró túo í Tab 2
        private void getTextspa2Button_Click(object sender, RoutedEventArgs e)
        {
            if (textaspaComboBox2.SelectedIndex == 0)
            {
                textPathNumber = "2";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_isl_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_isl.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 1)
            {
                textPathNumber = "3";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_su_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_su.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 2)
            {
                textPathNumber = "31";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_fa_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_fa.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 3)
            {
                textPathNumber = "32";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_br_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_br.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 4)
            {
                textPathNumber = "33";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_vf_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_vf.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 5)
            {
                textPathNumber = "34";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_nv_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_nv.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 6)
            {
                textPathNumber = "35";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_na_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_na.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 7)
            {
                textPathNumber = "36";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_al_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_al.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 8)
            {
                textPathNumber = "37";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_af_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_af.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 9)
            {
                textPathNumber = "38"; if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_sa_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_sa.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 10)
            {
                textPathNumber = "39";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_ho_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_ho.gif", UriKind.Relative));

            }
            else if (textaspaComboBox2.SelectedIndex == 11)
            {
                textPathNumber = "30";
                if (invertMap2.IsChecked == true)
                {
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_mh_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd2.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\AppsDiddi\Mappan\Myndasafn\wmap_mh.gif", UriKind.Relative));

            }

            string completeTextPath = basicTextPath + textPathNumber;
            XmlDocument xmlTextaspa = new XmlDocument();
            xmlTextaspa.Load(completeTextPath);

            XmlNodeList description = xmlTextaspa.GetElementsByTagName("content"),
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

        #endregion


        #region --------------------------- Some Random Events --------------------------------

        private void textDescriptionBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void textaspaComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void textaspaComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }


        private void invertMap1_Checked(object sender, RoutedEventArgs e)
        {
        }
        private void invertMap2_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
        }
        #endregion


    }
}

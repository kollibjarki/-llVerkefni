using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Windows.Markup;
using System.IO;

namespace VedurNewTabs
{

    public partial class MainWindow : Window
    {
        private List<TabItem> _tabItems;
        private TabItem _tabAdd;
        public static string kortasource = "";

        

        public MainWindow()
        {

            try
            {
                InitializeComponent();

                // initialize tabItem array
                _tabItems = new List<TabItem>();
                // add a tabItem with + in header 
                
                _tabAdd = new TabItem();
                _tabAdd.Header = "+";
                // tabAdd.MouseLeftButtonUp += new MouseButtonEventHandler(tabAdd_MouseLeftButtonUp);
                _tabItems.Add(_tabAdd);


                // add first tab
                this.AddTabItem();
                // bind tab control
                tabDynamic.DataContext = _tabItems;
                tabDynamic.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private TabItem AddTabItem()
        {
            int count = _tabItems.Count;
            // create new tab item

            TabItem tab = new TabItem();
            tab.Header = string.Format("{0}", count);
            tab.Name = string.Format("spá{0}", count);
            tab.HeaderTemplate = tabDynamic.FindResource("TabHeader") as DataTemplate;
            
            // add controls to tab item, this case I added just a textbox
            tab.Content = "Textaspár og stuff";
            // insert tab item right before the last (+) tab item
            _tabItems.Insert(count - 1, tab);
            return tab;
        }
        private void tabAdd_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // clear tab control binding
            tabDynamic.DataContext = null;
            TabItem tab = this.AddTabItem();
            // bind tab control
            tabDynamic.DataContext = _tabItems;
            // select newly added tab item
            tabDynamic.SelectedItem = tab;
        }
        private void tabDynamic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabItem tab = tabDynamic.SelectedItem as TabItem;
            if (tab == null) return;
            if (tab.Equals(_tabAdd))
            {
                // clear tab control binding
                
                if(_tabItems.Count <= 11)
                {
                    tabDynamic.DataContext = null;
                    TabItem newTab = this.AddTabItem();
                    // bind tab control
                    tabDynamic.DataContext = _tabItems;
                    // select newly added tab item
                    tabDynamic.SelectedItem = newTab;

                }
                else
                {
                    MessageBox.Show("Hámarki Náð!");
                   
                    
                }
                
            }
            else
            {
                // your code here...
            }
           
            
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string tabName = (sender as Button).CommandParameter.ToString();
            var item = tabDynamic.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabName)).SingleOrDefault();
            TabItem tab = item as TabItem;
            if (tab != null)
            {
                if (_tabItems.Count < 3)
                {
                    MessageBox.Show("Cannot remove last tab.");
                }

                //__________Til að fá promt ef maður lokar glugga.... nota í Stöðvaspám  ?? ??
                //else if (MessageBox.Show(string.Format("Are you sure you want to remove the tab '{0}'?", tab.Header.ToString()),
                //    "Remove Tab", MessageBoxButton.YesNo) == MessageBoxResult.Yes)

                else
                {
                    // get selected tab
                    TabItem selectedTab = tabDynamic.SelectedItem as TabItem;
                    // clear tab control binding
                    tabDynamic.DataContext = null;
                    _tabItems.Remove(tab);
                    // bind tab control
                    tabDynamic.DataContext = _tabItems;
                    // select previously selected tab. if that is removed then select first tab
                    if (selectedTab == null || selectedTab.Equals(tab))
                    {
                        selectedTab = _tabItems[0];
                    }
                    tabDynamic.SelectedItem = selectedTab;
                }
            }
        }




        void getMapClick(object sender, RoutedEventArgs e)
        {
            if(kortaComboBox.SelectedIndex == 0)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\wmap_isl_invert.gif", UriKind.Relative));
                }
                else
                kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\wmap_isl.gif", UriKind.Relative));
            }
            else if(kortaComboBox.SelectedIndex == 1)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\Reykjavik.10_invert.gif", UriKind.Relative));
                }
                else
                kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\Reykjavik.10.gif", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 2)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\\wmap_su_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\\wmap_su.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 3)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\\wmap_fa_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\\wmap_fa.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 4)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"wmap_br_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\VeðurForrit\Góðar Útgáfur\VedurCurrentProgram\VedurNewTabs\wmap_br.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 5)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"wmap_vf_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri("wmap_vf.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 6)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri("wmap_nv_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri("wmap_nv.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 7)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\Visual Projects Diddi\VedurNewTabs\VedurNewTabs\wmap_na_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\Góðar Útgáfur\VedurNewTabs\VedurNewTabs\wmap_na.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 8)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\Visual Projects Diddi\VedurNewTabs\VedurNewTabs\wmap_al_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\Góðar Útgáfur\VedurNewTabs\VedurNewTabs\wmap_al.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 9)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\Visual Projects Diddi\VedurNewTabs\VedurNewTabs\wmap_af_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\Góðar Útgáfur\VedurNewTabs\VedurNewTabs\wmap_af.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 10)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\Visual Projects Diddi\VedurNewTabs\VedurNewTabs\wmap_sa_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\Góðar Útgáfur\VedurNewTabs\VedurNewTabs\wmap_sa.gif ", UriKind.Relative));
            }
            else if (kortaComboBox.SelectedIndex == 11)
            {
                if (invertMap.IsChecked == true)
                {
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Documents\Visual Projects Diddi\VedurNewTabs\VedurNewTabs\wmap_mh_invert.gif", UriKind.Relative));
                }
                else
                    kortamynd.ImageSource = new BitmapImage(new Uri(@"C:\Users\Audio Monster\Desktop\Góðar Útgáfur\VedurNewTabs\VedurNewTabs\wmap_mh.gif ", UriKind.Relative));
            }

        }

        


        private void kortaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush magicBrush = (SolidColorBrush)Resources["magicBrush"];


            if ((sliR != null) && (sliG != null) && (sliB != null))
            {
                magicBrush.Color = Color.FromRgb((byte)sliR.Value, (byte)sliG.Value, (byte)sliB.Value);
            }
        }


        private void litirMenu_Click(object sender, RoutedEventArgs e)
        {
           
            vedurstodWindow colorSetting = new vedurstodWindow();
            colorSetting.Show();
        }
    }
}

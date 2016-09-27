using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace FlugSkráningarKerfiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IAlertable
    {
        private Flug flugvel;
        private Thread workerThread;
        private List<Flug> SelectedArrivals;
        private List<Flug> SelectedDate;

        private List<Flug> SelectedDepartures;

        public MainWindow()
        {
            //string alarmWaitSeconds = textBox.Text;
            //DateTime alarmTime = DateTime.Now.AddSeconds(Convert.ToDouble(alarmWaitSeconds));

            InitializeComponent();

            flugvel = new Flug();
            SelectedArrivals = new List<Flug>();
            SelectedDepartures = new List<Flug>();
            SelectedDate = new List<Flug>();

            //Alarm alarm = new Alarm(this, alarmTime);
            //workerThread = new Thread(alarm.WaitForAlarm);
            //workerThread.Start();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                MessageBox.Show("You have selected departures");
                listBox.Items.Clear();

                var ollflug = listBox;
                Flug[] flug = flugvel.departures();

                foreach (Flug F in flug)
                {
                    ListBoxItem dp = new ListBoxItem();
                    dp.Content = F.flightNumber;

                    listBox.Items.Add(dp);
                }

            }
            else if (radioButton.IsChecked == true)
            {
                MessageBox.Show("You have selected arrivals");

                listBox.Items.Clear();

                Flug[] flug = flugvel.arrivals();

                //ListBox listbox = new ListBox();

                foreach (Flug f in flug)
                {
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = f.flightNumber;

                    listBox.Items.Add(itm);
                }
            }

        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }


        private void button4_Click(object sender, RoutedEventArgs e)
        {


            //ListBoxItem mitt = new ListBoxItem();
            //mitt.Content = listBox.SelectedItem.ToString();

            //  listBox1.Items.Add(mitt);

            var flugnr = listBox.SelectedItem.ToString().Substring(37);
            var flugnrD = listBox.SelectedItem.ToString().Substring(37);


            foreach (Flug f in flugvel.arrivals())
            {
                if (f.flightNumber == flugnr)
                {

                    SelectedArrivals.Add(f);
                    ListBoxItem lpi = new ListBoxItem();
                    lpi.Content = f.flightNumber + "\nFlugfélag - " + f.airline + "\nFrá - " + f.from + "\nÁætlaður komutími - " + f.plannedArrival + "\n" + f.realArrival;
                    listBox1.Items.Add(lpi);
                }
            }

            foreach (Flug f in flugvel.departures())
            {
                if (f.flightNumber == flugnr)
                {

                    SelectedArrivals.Add(f);
                    ListBoxItem lpi = new ListBoxItem();
                    lpi.Content = f.flightNumber + "\nFlugfélag - " + f.airline + "\nTil - " + f.to + "\nÁætlaður brottfaratími - " + f.plannedArrival + "\n" + f.realArrival;
                    listBox1.Items.Add(lpi);
                }
            }
        }

       
        

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {


            foreach (Flug f in SelectedArrivals)
            {

                string bla = f.realArrival.ToString();
                DateTime.Now.ToString(bla);


                if (f.realArrival.StartsWith("On Time"))
                {

                    Convert.ToString(MessageBox.Show(bla));

                }

                if (f.realArrival.StartsWith("Departed"))
                {

                    Convert.ToString(MessageBox.Show(bla, Convert.ToString(DateTime.Now)));
                    MessageBox.Show("Your Flight has left bro", Convert.ToString(DateTime.Now));

                }

            }
        }

        public void DoAlert(string alert)
        {
           

            MessageBox.Show(alert);
            workerThread.Suspend();

        }
        

      
        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            listBox1.ItemsSource = null;
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            listBox.Items.Clear();

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.HasItems == true)
            {
                if (listBox1.SelectedItem == null)
                {
                    labelClearMsg.Content = "You must select an item to watch!";
                }
                else
                {

                    labelClearMsg.Content = "";
                    listBox2.Items.Clear();
                    ListBoxItem listItem = new ListBoxItem();
                    string displayItemString = listBox1.SelectedItem.ToString().Substring(37);
                    listItem.Content = displayItemString;
                    listBox2.Items.Add(listItem);
                    if (radioButton.IsChecked == true)
                    {
                        if (displayItemString.Contains("Landed") == false)
                        {
                            MessageBox.Show("You will be reminded 30 minutes before the selected flight arrives");
                        }
                        if (displayItemString.Contains("Landed"))
                        {
                            MessageBox.Show("The flight has alredy landed!");
                        }
                        else if (displayItemString.Contains("Confirm."))
                        {
                            int startOfConfirmed = displayItemString.IndexOf("Confirm.");
                            int locationOfConfirmedTime = startOfConfirmed + 9;
                            string dasSubstring = displayItemString.Substring(locationOfConfirmedTime);
                            dasSubstring.Trim();
                            DateTime dasTime = DateTime.ParseExact(dasSubstring, "HH:mm", CultureInfo.InvariantCulture);
                            DateTime alarmTime = dasTime.AddMinutes(-30);

                            Alarm _alarm = new Alarm(this, alarmTime);
                            workerThread = new Thread(_alarm.WaitForAlarm);
                            workerThread.Start();
                            //MessageBox.Show(dasSubstring);
                        }
                        else
                        {
                            int startOfPlanned = displayItemString.IndexOf("Planned Arrival");
                            int locationOfPlannedTime = startOfPlanned + 17;
                            string dasSubstringWithRest = displayItemString.Substring(locationOfPlannedTime);
                            string dasSubstring = dasSubstringWithRest.Remove(5);
                            dasSubstring.Trim();
                            DateTime dasTime = DateTime.ParseExact(dasSubstring, "HH:mm", CultureInfo.InvariantCulture);
                            DateTime alarmTime = dasTime.AddMinutes(-30);

                            Alarm _alarm = new Alarm(this, alarmTime);
                            workerThread = new Thread(_alarm.WaitForAlarm);
                            workerThread.Start();
                        }
                    }
                    if (radioButton1.IsChecked == true)
                    {
                        if (displayItemString.Contains("Departed") == false)
                        {
                            MessageBox.Show("You will be reminded 30 minutes before the selected flight departs");
                        }
                        if (displayItemString.Contains("Departed"))
                        {
                            MessageBox.Show("The Flight has alredy departed!");
                        }
                        else if (displayItemString.Contains("Planned Departure"))
                        {
                            int startOfPlanned = displayItemString.IndexOf("Planned Departure");
                            int locationOfPlannedTime = startOfPlanned + 19;
                            string dasSubstringWithRest = displayItemString.Substring(locationOfPlannedTime);
                            string dasSubstring = dasSubstringWithRest.Remove(5);
                            dasSubstring.Trim();
                            DateTime dasTime = DateTime.ParseExact(dasSubstring, "HH:mm", CultureInfo.InvariantCulture);
                            DateTime alarmTime = dasTime.AddMinutes(-30);

                            Alarm _alarm = new Alarm(this, alarmTime);
                            workerThread = new Thread(_alarm.WaitForAlarm);
                            workerThread.Start();
                        }
                    }
                }
            }
            if (listBox1.HasItems == false)
            {
                labelClearMsg.Content = "You must select an item to watch!";
            }
        }

        public void DoAlertS(string alertS)
        {
            MessageBox.Show(alertS);
            workerThread.Suspend();
        }
    }
}

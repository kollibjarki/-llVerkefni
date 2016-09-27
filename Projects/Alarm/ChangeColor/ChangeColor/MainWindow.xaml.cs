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
using System.Threading;

namespace ChangeColor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IAlertable
    {
        private Thread workerThread;

        public MainWindow()
        {
            // Set up alarm waiting time
            int alarmWaitSeconds = 10;
            DateTime alarmTime = DateTime.Now.AddSeconds(alarmWaitSeconds);

            InitializeComponent();

            // Create an alarm using this class. Then add some
            // for "alarmWaitSeconds" seconds. Lastly run the
            // alarm in a separate thread so the program can keep
            // doing whatever it wants.
            Alarm alarm = new Alarm(this, alarmTime);
            workerThread = new Thread(alarm.WaitForAlarm);
            workerThread.Start();
        }

        public void DoAlert(string alert)
        {
            MessageBox.Show(alert);
           // workerThread.Suspend();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = (Convert.ToInt32(txtValue.Text) + 1).ToString();
        }
    }
}

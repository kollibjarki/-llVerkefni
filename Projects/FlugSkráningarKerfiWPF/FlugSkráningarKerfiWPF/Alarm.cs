using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace FlugSkráningarKerfiWPF
{
    class Alarm
    {
        private DateTime AlarmTime { get; set; }
        private IAlertable win; // MainWindow

        public Alarm(IAlertable window, DateTime alarmTime)
        {
            AlarmTime = alarmTime;
            win = window;
        }

        public void WaitForAlarm()
        {
            // Run once every second (1000 ms)
            while (true)
            {
                if (DateTime.Now > AlarmTime) // && DateTime.Now < AlarmTime.AddSeconds(-1))
                {
                    

                    // The alarm went of, let the main window know
                    // using the DoAlert method in MainWindow.
                    win.DoAlert("Vinsamlegast kíktu aftur á flugið");
                }
                Thread.Sleep(1000); // 1000 ms are 1 second
                
                // Some logging to System.Console
                System.Console.WriteLine("Time: " + DateTime.Now.ToString() + "\nAlarm time is: " + AlarmTime.ToString());

            }
        }
    }
}

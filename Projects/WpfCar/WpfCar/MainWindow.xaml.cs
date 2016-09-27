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

namespace WpfCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Car car;

        public MainWindow()
        {
            InitializeComponent();

            car = new Car();
           
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //UPP
            var top = bill.Margin.Top;
            var left = bill.Margin.Left;
            var right = bill.Margin.Right;
            var bottom = bill.Margin.Bottom;

            bill.Margin = new Thickness(left, top - 10, right, bottom - 10);

            var stadsetning = bill.VerticalAlignment;
            var lokastadsetning = stadsetning;
            textBox.Text = Convert.ToString(lokastadsetning);
            Up.Background = Brushes.Blue;
            //Window.Background = Brushes.Blue;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //vinstri
            var top = bill.Margin.Top;
            var left = bill.Margin.Left;
            var right = bill.Margin.Right;
            var bottom = bill.Margin.Bottom;

            bill.Margin = new Thickness(left - 10, top, right - 10, bottom);

            var stadsetning = bill.HorizontalAlignment;
            var lokastadsetning = stadsetning;
            textBox.Text = Convert.ToString(lokastadsetning);
            vs.Background = Brushes.Pink;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //niður
            var top = bill.Margin.Top;
            var left = bill.Margin.Left;
            var right = bill.Margin.Right;
            var bottom = bill.Margin.Bottom;

            bill.Margin = new Thickness(left, top + 10, right, bottom + 10);

            var stadsetning = bill.Margin;
            var lokastadsetning = stadsetning;
            textBox.Text = Convert.ToString(lokastadsetning);
            Down.Background = Brushes.Green;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //hægri
            var top = bill.Margin.Top;
            var left = bill.Margin.Left;
            var right = bill.Margin.Right;
            var bottom = bill.Margin.Bottom;

            bill.Margin = new Thickness(left + 10, top, right + 10, bottom);

            var stadsetning = bill.Margin;
            var lokastadsetning = stadsetning;
            textBox.Text = Convert.ToString(lokastadsetning);

            Right.Background = Brushes.Cyan;


        }
        //private void OnShowWindow2(object sender, RoutedEventArgs e)
        //{
        //    Window window2 = new Window();
        //    Random random = new Random();
        //    SolidColorBrush brush =
        //        new SolidColorBrush(
        //            Color.FromRgb(
        //            (byte)random.Next(255),
        //            (byte)random.Next(255),
        //            (byte)random.Next(255)
        //            ));
        //    window2.Background = brush;
        //    window2.Show();
        //}


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // http://pastebin.com/BBn7JbaV

            if (e.Key == Key.Up)
            {
                var top = bill.Margin.Top;
                var left = bill.Margin.Left;
                var right = bill.Margin.Right;
                var bottom = bill.Margin.Bottom;

                bill.Margin = new Thickness(left, top - 10, 0, 0 - 10);

                var stadsetning = bill.VerticalAlignment;
                var lokastadsetning = stadsetning;
                textBox.Text = Convert.ToString(lokastadsetning);
            }
            else if (e.Key == Key.Down)
            {
                var top = bill.Margin.Top;
                var left = bill.Margin.Left;
                var right = bill.Margin.Right;
                var bottom = bill.Margin.Bottom;

                bill.Margin = new Thickness(left, top + 10, 0, 0 + 10);

                var stadsetning = bill.Margin;
                var lokastadsetning = stadsetning;
                textBox.Text = Convert.ToString(lokastadsetning);
            }

            else if (e.Key == Key.Left)
            {
                var top = bill.Margin.Top;
                var left = bill.Margin.Left;
                var right = bill.Margin.Right;
                var bottom = bill.Margin.Bottom;

                bill.Margin = new Thickness(left - 10, top, 0 - 10, 0);

                var stadsetning = bill.HorizontalAlignment;
                var lokastadsetning = stadsetning;
                textBox.Text = Convert.ToString(lokastadsetning);
                kolbeinn.Focus();
            }

            else if (e.Key == Key.Right)
            {

                var top = bill.Margin.Top;
                var left = bill.Margin.Left;
                var right = bill.Margin.Right;
                var bottom = bill.Margin.Bottom;

                bill.Margin = new Thickness(left + 10, top, 0 + 10, 0);

                var stadsetning = bill.Margin;
                var lokastadsetning = stadsetning;
                textBox.Text = Convert.ToString(lokastadsetning);
            }

            //Window window2= new Window();
            Random random = new Random();
            SolidColorBrush brush =
                new SolidColorBrush(Color.FromRgb((byte)random.Next(255),(byte)random.Next(255),(byte)random.Next(255)));
            kolbeinn.Background = brush;
            //kolbeinn.Show();

            kolbeinn.Focus();
        }

        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {

        }
    }
 }


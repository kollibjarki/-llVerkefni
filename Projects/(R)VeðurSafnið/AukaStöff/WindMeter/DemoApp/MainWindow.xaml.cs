using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace DemoApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    readonly Random random = new Random();

    public MainWindow()
    {
      InitializeComponent();
    }

    private static IEnumerable<DependencyObject> FindInVisualTreeDown(DependencyObject obj, Type type)
    {
      if (obj != null)
      {
        if (obj.GetType() == type)
        {
          yield return obj;
        }

        for (var i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
        {
          foreach (var child in FindInVisualTreeDown(VisualTreeHelper.GetChild(obj, i), type))
          {
            if (child != null)
            {
              yield return child;
            }
          }
        }
      }

      yield break;
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
      foreach (NMT.Wpf.Controls.WindMeter wm in FindInVisualTreeDown(this, typeof(NMT.Wpf.Controls.WindMeter)))
      {
        wm.Wind = random.Next(1, 40);
        wm.Direction = random.Next(0, 360);
      }
    }
  }
}

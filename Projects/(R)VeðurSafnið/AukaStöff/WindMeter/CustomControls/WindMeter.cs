using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace NMT.Wpf.Controls
{
  /// <summary>
  /// WindMeter Custom Control
  /// License: Ms-PL
  /// </summary>
  [TemplatePart(Name = "PART_pointer", Type = typeof(Rectangle))]
  [TemplatePart(Name = "PART_fan", Type = typeof(Rectangle))]
  [TemplatePart(Name = "PART_pointer_border", Type = typeof(Border))]
  [TemplatePart(Name = "PART_fan_storyboard", Type = typeof(Storyboard))]
  [TemplatePart(Name = "PART_fan_animation", Type = typeof(DoubleAnimation))]
  [TemplatePart(Name = "PART_pointer_storyboard", Type = typeof(Storyboard))]
  [TemplatePart(Name = "PART_pointer_animation", Type = typeof(DoubleAnimation))]
  [TemplatePart(Name = "PART_wiggle_storyboard", Type = typeof(Storyboard))]
  [TemplatePart(Name = "PART_wiggle_animation", Type = typeof(DoubleAnimation))]
  public class WindMeter : Control
  {
    #region -- Declares --

    private Rectangle partFan, partPointer;
    private Storyboard fanStoryBoard, pointerStoryBoard, wiggleStoryBoard;
    private DoubleAnimation fanAnimation, pointerAnimation, wiggleAnimation;

    /// <summary>
    /// Display type, Fan, Day, Night
    /// </summary>
    public enum DisplayType
    {
      Fan,
      Day,
      Night
    }

    #endregion

    #region -- Properties --

    public static readonly DependencyProperty DirectionOffsetProperty =
      DependencyProperty.Register("DirectionOffset", typeof (int), typeof (WindMeter), new PropertyMetadata(default(int),
       (o, e) => ((WindMeter)o).ChangeDirection(((WindMeter)o).Direction, ((WindMeter)o).Direction)));

    public int DirectionOffset
    {
      get { return (int) GetValue(DirectionOffsetProperty); }
      set { SetValue(DirectionOffsetProperty, value); }
    } 

    public static readonly DependencyProperty WiggleDegreesProperty =
      DependencyProperty.Register("WiggleDegrees", typeof(int), typeof(WindMeter), new PropertyMetadata(10, 
        (o, e) => ((WindMeter)o).ChangeWiggle()));

    public int WiggleDegrees
    {
      get { return (int)GetValue(WiggleDegreesProperty); }
      set { SetValue(WiggleDegreesProperty, value); }
    }

    public static readonly DependencyProperty WiggleProperty =
      DependencyProperty.Register("Wiggle", typeof(bool), typeof(WindMeter), new PropertyMetadata(true, 
        (o, e) => ((WindMeter)o).ChangeWiggle()));

    public bool Wiggle
    {
      get { return (bool)GetValue(WiggleProperty); }
      set { SetValue(WiggleProperty, value); }
    }

    public static readonly DependencyProperty ShadowProperty =
      DependencyProperty.Register("Shadow", typeof(Color), typeof(WindMeter), new PropertyMetadata(Colors.Black));

    public Color Shadow
    {
      get { return (Color)GetValue(ShadowProperty); }
      set { SetValue(ShadowProperty, value); }
    }

    public static readonly DependencyProperty DisplayProperty =
      DependencyProperty.Register("Display", typeof(DisplayType), typeof(WindMeter), new PropertyMetadata(DisplayType.Fan,
         (o, e) => ((WindMeter)o).ChangeDisplay((DisplayType)e.NewValue)));

    public DisplayType Display
    {
      get { return (DisplayType)GetValue(DisplayProperty); }
      set { SetValue(DisplayProperty, value); }
    }

    public static readonly DependencyProperty WindProperty =
    DependencyProperty.Register("Wind", typeof(int), typeof(WindMeter), new PropertyMetadata(default(int),
      (o, e) => ((WindMeter)o).ChangeWind((int)e.OldValue, (int)e.NewValue)));

    public int Wind
    {
      get { return (int)GetValue(WindProperty); }
      set { SetValue(WindProperty, value); }
    }

    public static readonly DependencyProperty DirectionProperty =
      DependencyProperty.Register("Direction", typeof(int), typeof(WindMeter), new PropertyMetadata(0,
        (o, e) => ((WindMeter)o).ChangeDirection((int)e.OldValue, (int)e.NewValue)));

    public int Direction
    {
      get { return (int)GetValue(DirectionProperty); }
      set { SetValue(DirectionProperty, value); }
    }

    #endregion

    #region -- Constructor --

    /// <summary>
    /// Initializes a new instance of the <see cref="WindMeter"/> class.
    /// </summary>
    public WindMeter()
    {
      var res = (ResourceDictionary)Application.LoadComponent(new Uri("/NmtUiLib;component/Themes/WindMeterStyle.xaml", UriKind.Relative));
      Style = res["WindMeterStyle"] as Style;
    }

    #endregion

    #region -- Public Methods --

    public void ChangeDisplay(DisplayType type)
    {
      if (fanStoryBoard == null) return;
      if (type != DisplayType.Fan)
        fanStoryBoard.Stop();
      else
        fanStoryBoard.Begin();
    }

    public void ChangeWind(int oldValue, int newValue)
    {
      if (partFan == null) return;
      fanStoryBoard.Stop();
      if (newValue > 0)
      {
        fanAnimation.Duration = new Duration(TimeSpan.FromMilliseconds((int)(20000.0 / newValue)));
        fanStoryBoard.Begin();
      }
      ChangeWiggle();
    }

    public void ChangeWiggle()
    {
      if (wiggleAnimation == null) return;
      wiggleStoryBoard.Stop();
      if (!Wiggle || Wind <= 0) return;
      wiggleAnimation.From = WiggleDegrees /2; 
      wiggleAnimation.To = 0;
      wiggleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(10000.0 / Wind)); // Depending on wind speed
      wiggleStoryBoard.Begin();
    }

    public void ChangeDirection(int oldValue, int newValue)
    {
      if (partPointer == null) return;
      pointerStoryBoard.Stop();
      pointerAnimation.To = newValue + DirectionOffset;
      pointerAnimation.From = oldValue + DirectionOffset;
      pointerStoryBoard.Begin();
    }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      // Reference template parts
      partFan = GetTemplateChild("PART_fan") as Rectangle;
      partPointer = GetTemplateChild("PART_pointer") as Rectangle;
      pointerAnimation = GetTemplateChild("PART_pointer_animation") as DoubleAnimation;
      pointerStoryBoard = GetTemplateChild("PART_pointer_storyboard") as Storyboard;
      fanAnimation = GetTemplateChild("PART_fan_animation") as DoubleAnimation;
      fanStoryBoard = GetTemplateChild("PART_fan_storyboard") as Storyboard;
      wiggleAnimation = GetTemplateChild("PART_wiggle_animation") as DoubleAnimation;
      wiggleStoryBoard = GetTemplateChild("PART_wiggle_storyboard") as Storyboard;
      //
      // Startup & initialize
      ChangeDirection(0, Direction);
      ChangeWind(0, Wind);
      ChangeWiggle();
      ChangeDisplay(Display);
    }

    #endregion
  }
}

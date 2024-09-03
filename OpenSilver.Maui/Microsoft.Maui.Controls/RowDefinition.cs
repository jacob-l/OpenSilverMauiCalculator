using System.Windows.Controls;
using System.Windows;

namespace Microsoft.Maui.Controls
{
    public class RowDefinition : DependencyObject
    {
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(GridLength), typeof(RowDefinition), new PropertyMetadata(new GridLength(1, GridUnitType.Star)));

        public GridLength Height
        {
            get { return (GridLength)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }
    }
}

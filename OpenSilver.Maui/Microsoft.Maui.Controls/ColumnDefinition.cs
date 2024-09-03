
using System.Windows;

namespace Microsoft.Maui.Controls
{
    public class ColumnDefinition : DependencyObject
    {
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(GridLength), typeof(ColumnDefinition), new PropertyMetadata(new GridLength(1, GridUnitType.Star)));

        public GridLength Width
        {
            get { return (GridLength)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }
    }
}

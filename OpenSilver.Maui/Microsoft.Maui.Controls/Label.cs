using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Microsoft.Maui.Controls
{
    public class Label : System.Windows.Controls.Label
    {
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Text"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(Label),
                new PropertyMetadata(string.Empty, OnTextChanged, CoerceText)
                {
                });

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Label)d).Content = e.NewValue;
        }

        private static object CoerceText(DependencyObject d, object value)
        {
            return (string)value ?? string.Empty;
        }
    }
}

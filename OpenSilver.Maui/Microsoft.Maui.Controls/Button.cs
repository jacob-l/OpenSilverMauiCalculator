using System;
using System.Windows;
using System.Windows.Input;

namespace Microsoft.Maui.Controls
{
    public class Button : System.Windows.Controls.Button
    {
        public Button()
        {
            this.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OnClicked();
        }

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
                typeof(Button),
                new PropertyMetadata(string.Empty, OnTextChanged, CoerceText));

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Button)d).Content = e.NewValue;
        }

        private static object CoerceText(DependencyObject d, object value)
        {
            return (string)value ?? string.Empty;
        }

        // Define the Clicked event
        public event EventHandler Clicked;

        protected virtual void OnClicked()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Maui.Controls
{
    public class Application : System.Windows.Application
    {
        public UIElement MainPage
        {
            get => RootVisual;
            set
            {
                if (MainPage == value)
                    return;

                RootVisual = value;
            }
        }
    }
}

using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Microsoft.Maui.Controls
{
    public class Grid : System.Windows.Controls.Grid
    {
        public Grid()
        {
            RowDefinitions = new ObservableCollection<RowDefinition>();
            ColumnDefinitions = new ObservableCollection<ColumnDefinition>();

            RowDefinitions.CollectionChanged += RowDefinitions_CollectionChanged;
            ColumnDefinitions.CollectionChanged += ColumnDefinitions_CollectionChanged;
        }

        private void ColumnDefinitions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
            {
                base.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition() { Width = (item as ColumnDefinition).Width });
            }
        }

        private void RowDefinitions_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
            {
                base.RowDefinitions.Add(new System.Windows.Controls.RowDefinition() { Height = (item as RowDefinition).Height });
            }
        }

        public new ObservableCollection<RowDefinition> RowDefinitions { get; set; }
        public new ObservableCollection<ColumnDefinition> ColumnDefinitions { get; set; }
    }
}

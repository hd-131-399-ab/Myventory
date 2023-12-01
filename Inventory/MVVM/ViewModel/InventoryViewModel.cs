using Inventory.MVVM.Model;
using System.Collections.ObjectModel;

namespace Inventory.MVVM.ViewModel
{
    internal class InventoryViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public InventoryViewModel()
        {
            Items = new()
            {
                new Item("Test item", new Image(), "Haus"),
                new Item("Test item2", new Image(), "Haus"),
                new Item("Test item3", new Image(), "Haus"),
                new Item("Test item4", new Image(), "Haus")
            };
        }
    }
}

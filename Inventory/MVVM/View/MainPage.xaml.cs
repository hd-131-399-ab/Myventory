using Inventory.MVVM.View;
using ShellItem = Microsoft.Maui.Controls.ShellItem;

namespace Inventory
{
    public partial class MainPage : ContentPage
    {
        private bool routesRegistered = false;

        public MainPage()
        {
            InitializeComponent();

            if (!routesRegistered)
            {
                //Routing.RegisterRoute("Inventory", typeof(InventoryPage));

                //ShellItem shellItem = new();
                //shellItem.Title = "Test";
                ////shellItem.FlyoutIcon = "dotnet-bot.svg";
                //shellItem.Route = "Inventory";

                //Shell.Current.Items.Add(shellItem);
            }            
        }
    }
}

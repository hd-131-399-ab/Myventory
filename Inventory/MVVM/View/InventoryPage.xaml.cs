using Inventory.MVVM.ViewModel;

namespace Inventory.MVVM.View;

public partial class InventoryPage : ContentPage
{
	public InventoryPage()
	{
		InitializeComponent();

		BindingContext = new InventoryViewModel();
	}
}
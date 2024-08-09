using MAUI.Mauiverter.MVVM.ViewModels;

namespace MAUI.Mauiverter.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}
}
using MAUI.Mauiverter.MVVM.ViewModels;

namespace MAUI.Mauiverter.MVVM.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConverterViewModel();
	}
}
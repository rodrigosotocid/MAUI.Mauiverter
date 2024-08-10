using MAUI.Mauiverter.MVVM.ViewModels;

namespace MAUI.Mauiverter.MVVM.Views;

public partial class MenuView : ContentPage
{
    public MenuView()
    {
        InitializeComponent();
        BindingContext = new MenuViewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var element = (Grid)sender;
        var option = ((Label)element.Children[1]).Text;

        var converterView = new ConverterView
        {
            BindingContext = new ConverterViewModel(option)
        };

        Navigation.PushAsync(converterView);
    }
}
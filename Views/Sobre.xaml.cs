namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void VoltarAoInicio_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // volta para a tela HomePage
    }

}
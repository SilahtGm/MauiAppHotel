namespace MauiAppHotel.Views;

public partial class PagamentoEfetuado : ContentPage
{
    public PagamentoEfetuado()
    {
        InitializeComponent();
    }

    private async void VoltarAoInicio_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // volta para a tela HomePage
    }
}

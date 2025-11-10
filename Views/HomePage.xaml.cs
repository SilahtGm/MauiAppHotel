namespace MauiAppHotel.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void IrParaContratacao(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }

    private async void IrParaSobre(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}

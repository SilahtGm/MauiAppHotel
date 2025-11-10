namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // volta para a tela anterior
    }

    private async void IrParaPagamento(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagamentoEfetuado());
    }
}
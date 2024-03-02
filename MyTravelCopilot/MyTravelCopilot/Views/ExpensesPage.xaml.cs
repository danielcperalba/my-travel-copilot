namespace MyTravelCopilot.Views;

public partial class ExpensesPage : ContentPage
{

	// configura��o de inje��o de depend�ncia da tela
	private ExpensesViewModel _viewModel;
	public ExpensesPage(ExpensesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = _viewModel = viewModel;
	}

	//chamda do m�todo da view model respons�vel por carregar os dados toda vez que a tela for renderizada
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await _viewModel.InitiAsync();
    }
}
namespace MyTravelCopilot.Views;

public partial class ExpensesPage : ContentPage
{

	// configuração de injeção de dependência da tela
	private ExpensesViewModel _viewModel;
	public ExpensesPage(ExpensesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = _viewModel = viewModel;
	}

	//chamda do método da view model responsável por carregar os dados toda vez que a tela for renderizada
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		await _viewModel.InitiAsync();
    }
}
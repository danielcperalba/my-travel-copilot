using MyTravelCopilot.Models.Response;
using MyTravelCopilot.Repositories.Spent;

namespace MyTravelCopilot.ViewModels
{
    public partial class ExpensesViewModel : BaseViewModel
    {
        public ObservableCollection<ExpensesResponse> Expense { get; set; }
        = new ObservableCollection<ExpensesResponse>();

        private readonly IExpensesRepository _expensesRepository;
        public ExpensesViewModel(IExpensesRepository expensesRepository) 
        {
            _expensesRepository = expensesRepository;
        }

        internal async Task InitiAsync()
        {
            IsBusy = true;

            var expenses = await _expensesRepository.GetExpensesAsync();

            Expense.Clear();

            foreach (var expense in expenses)
                Expense.Add(expense);

            IsBusy = false;
        }
    }
}

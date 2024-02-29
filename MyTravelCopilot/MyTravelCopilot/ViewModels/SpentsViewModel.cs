using MetalPerformanceShaders;
using MyTravelCopilot.Models.Response;
using MyTravelCopilot.Repositories.Spent;

namespace MyTravelCopilot.ViewModels
{
    public partial class SpentsViewModel : BaseViewModel
    {
        public ObservableCollection<SpentResponse> Spents { get; set; }
        = new ObservableCollection<SpentResponse>();

        private readonly ISpentRepository _spentRepository;
        public SpentsViewModel(ISpentRepository spentRepository) 
        {
            _spentRepository = spentRepository;
        }

        internal async Task InitiAsync()
        {
            IsBusy = true;

            var spents = await _spentRepository.GetSpentAsyc();

            Spents.Clear();

            foreach (var spent in spents)
                Spents.Add(spent);

            IsBusy = false;
        }
    }
}

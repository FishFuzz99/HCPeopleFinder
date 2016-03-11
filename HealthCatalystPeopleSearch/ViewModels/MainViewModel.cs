using Caliburn.Micro;
using HealthCatalystPeopleSearch.Models;

namespace HealthCatalystPeopleSearch.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {

        private static PeopleContext _context = IoC.Get<PeopleContext>();
        private IPeopleRepository _repository = new PeopleRepository(_context);

        public MainViewModel()
        {
            People();
        }

        public void People()
        {
            ActivateItem(new PeopleListViewModel(_repository));
        }

        public void NewPerson()
        {
            ActivateItem(new NewPersonViewModel(_repository));
        }

    }
}

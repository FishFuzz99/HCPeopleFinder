using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HealthCatalystPeopleSearch.Models;

namespace HealthCatalystPeopleSearch.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private const string WindowTitleDefault = "So. Just Not It";


        private static PeopleContext _context = IoC.Get<PeopleContext>();
        private IPeopleRepository _repository = new PeopleRepository(_context);
       
        private string _windowTitle = WindowTitleDefault;
        public string WindowTitle
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

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

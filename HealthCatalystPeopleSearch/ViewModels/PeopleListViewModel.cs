using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HealthCatalystPeopleSearch.Models;
using System.Collections.ObjectModel;
using System.Drawing;

namespace HealthCatalystPeopleSearch.ViewModels
{
    public class PeopleListViewModel : Screen
    {
        private IPeopleRepository _repository;
        private ObservableCollection<Person> _People;
        public ObservableCollection<Person> People
        {
            get
            {
                return _People;
            }
            set
            {
                _People = value; NotifyOfPropertyChange(() => People);
            }

        }
        
        
        public PeopleListViewModel(IPeopleRepository repository)
        {
            //if (DesignProperties.GetIsInDesignMode(new System.Windows.DependencyObject())) return;

            _repository = repository;
            
           // People = new ObservableCollection<Person>(_repository.GetPeopleAsync().Result);
            //People = _repository
        }

        public void NewPerson()
        {
            MainViewModel mvm = new MainViewModel();
            mvm.NewPerson();
        }
        
        
        protected async override void OnActivate()
        {
            base.OnActivate();

            People = await _repository.getPeopleAsync();
          

        }

    }
}

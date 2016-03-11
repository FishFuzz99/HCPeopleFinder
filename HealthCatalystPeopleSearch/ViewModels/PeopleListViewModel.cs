using System.Linq;
using Caliburn.Micro;
using HealthCatalystPeopleSearch.Models;
using System.Collections.ObjectModel;
using System;

namespace HealthCatalystPeopleSearch.ViewModels
{
    public class PeopleListViewModel : Screen
    {
        private ObservableCollection<Person> _preSearchPeople;
        private IPeopleRepository _repository;

        public PeopleListViewModel(IPeopleRepository repository)
        {
            _repository = repository;
        }

        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> people
        {
            get
            {
                return _people;
            }
            set
            {
                _people = value; NotifyOfPropertyChange(() => people);
            }

        }

        private string _searchValues;
        public string searchValues
        {
            get
            {
                return _searchValues;
            }
            set
            {
                _searchValues = value; NotifyOfPropertyChange(() => searchValues);
            }
        }

        private string _message;
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value; NotifyOfPropertyChange(() => message);
            }
        }


        

        public void NewPerson()
        {
            IoC.Get<MainViewModel>().NewPerson();
        }
        
        public void Search()
        {
            if (!string.IsNullOrWhiteSpace(searchValues))
            {
                string[] searchVals = null;
                searchVals = searchValues.Split(' ');

                people = new ObservableCollection<Person>(_preSearchPeople.Where(p => p.firstName.ContainsAny(searchVals) || p.lastName.ContainsAny(searchVals)));
            }
            else
            {
                people = _preSearchPeople;
            }
        }

        protected async override void OnActivate()
        {
            base.OnActivate();

            try
            {
                _preSearchPeople = await _repository.getPeopleAsync();
            }
            catch (ApplicationException ae)
            {
                message = ae.Message;
            }
        }
    }
}

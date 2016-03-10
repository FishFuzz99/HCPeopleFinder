using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalystPeopleSearch.Models
{
    public interface IPeopleRepository
    {
        Task<ObservableCollection<Person>> getPeopleAsync(string firstName = null, string lastName = null);
        Task addPersonAsync(Person newPerson);
        Task removePersonAsync(Person person);
    }
}

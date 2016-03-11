using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HealthCatalystPeopleSearch.Models
{
    public interface IPeopleRepository
    {
        Task<ObservableCollection<Person>> getPeopleAsync();
        Task addPersonAsync(Person newPerson);
    }
}

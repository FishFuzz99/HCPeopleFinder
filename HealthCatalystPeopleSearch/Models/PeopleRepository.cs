using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.IO;
using System.Drawing;


namespace HealthCatalystPeopleSearch.Models
{
    public class PeopleRepository : IPeopleRepository
    {
        private PeopleContext _context;
        private PeopleContextSeedData seeder;

        public PeopleRepository(PeopleContext context)
        {
            _context = context;
            seeder = new PeopleContextSeedData(context);
            seed();
        }

        public async void seed()
        {
            await seeder.EnsureSeedDataAsync();
        }
     

        public async Task<ObservableCollection<Person>> getPeopleAsync(string firstName = null, string lastName = null)
        {
            using (_context)
            {
                var People = await (from a in _context.People
                                    //where a.firstName.Contains(firstName) && a.lastName.Contains(lastName)
                                    select a).ToListAsync();

                People.ForEach(p => p.image = p.byteArr.ConvertByteArrToImage());

                return new ObservableCollection<Person>(People);
            }
        }



        public async Task addPersonAsync(Person newPerson)
        {
            _context.People.Add(newPerson);
            await _context.SaveChangesAsync();
        }

        public async Task removePersonAsync(Person person)
        {
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}

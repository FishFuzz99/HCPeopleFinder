using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System;

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
     

        public async Task<ObservableCollection<Person>> getPeopleAsync()
        {
            try
            {
                var People = await (from a in _context.People
                                    select a).ToListAsync();

                People.ForEach(p => p.image = p.byteArr?.ConvertByteArrToImage());

                return new ObservableCollection<Person>(People);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Failed to get people from the database", e);
            }
            
        }



        public async Task addPersonAsync(Person newPerson)
        {
            try
            {
                newPerson.byteArr = newPerson.image.ConvertImageToByteArr();
                _context.People.Add(newPerson);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new ApplicationException("Failed to add person.", e);
            }
        }
    }
}

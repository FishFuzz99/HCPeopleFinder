using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalystPeopleSearch.Models
{
    public class PeopleContextSeedData
    {
        private PeopleContext _context;

        public PeopleContextSeedData(PeopleContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedDataAsync()
        {
            if (!_context.People.Any())
            {
                var john = new Person()
                {
                    firstName = "John",
                    lastName = "Doe",
                    age = 30,
                    address = "123 N Main",
                    interests = "Snowboarding, video games, food",
                    byteArr = Properties.Resources.male1.ConvertImageToByteArr()
                };
                var jane = new Person()
                {
                    firstName = "Jane",
                    lastName = "Doe",
                    age = 31,
                    address = "123 N Main",
                    interests = "Snowboarding, cats, food",
                    byteArr = Properties.Resources.female1.ConvertImageToByteArr()
                };
                var bob = new Person()
                {
                    firstName = "Bob",
                    lastName = "Henry",
                    age = 55,
                    address = "Park Lane",
                    interests = "Bird Watching, fine wines, football",
                    byteArr = Properties.Resources.male2.ConvertImageToByteArr()
                };
                var nancy = new Person()
                {
                    firstName = "Nancy",
                    lastName = "Brown",
                    age = 23,
                    address = "4th South 300 East",
                    interests = "Movies, vollyball, hiking",
                    byteArr = Properties.Resources.female2.ConvertImageToByteArr()
                };


                _context.People.Add(john);
                _context.People.Add(jane);
                _context.People.Add(bob);
                _context.People.Add(nancy);

                await _context.SaveChangesAsync();
                
            }
        }
    }
}

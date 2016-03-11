using System.Data.Entity;


namespace HealthCatalystPeopleSearch.Models
{
    public class PeopleContext : DbContext
    {
        public PeopleContext()
        {
            
        }

        public DbSet<Person> People { get; set; }
    }
}

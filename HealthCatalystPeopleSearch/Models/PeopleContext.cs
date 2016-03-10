using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

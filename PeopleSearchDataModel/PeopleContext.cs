using HealthCatalystPeopleSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeopleSearchDataModel
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}

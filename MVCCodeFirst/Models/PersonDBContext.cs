using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models
{
    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
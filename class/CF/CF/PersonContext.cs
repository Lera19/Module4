using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("DefaultConnection")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PersonContext>());
            //Database.SetInitializer<PersonContext>(null);
            Database.SetInitializer(new CUSTOMiNITIALIZER());
        }
         public DbSet<Person> People { get;set; }
        
    }
}

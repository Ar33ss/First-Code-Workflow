using CodeFirstWorkFlow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWorkFlow
{
    public class Context : DbContext
    {
        public Context() : base()
        {
            // these are database initializers, theyre useful when youre makign changes in the properties

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
        }
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}

using GabsConsoleEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabsConsoleEF
{
    class MyDbContext : DbContext
    {
        public MyDbContext():base("DbJetAccess")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

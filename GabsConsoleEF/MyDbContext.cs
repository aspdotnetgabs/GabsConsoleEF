using GabsConsoleEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabsConsoleEF
{
    // When using MySql Database install https://dev.mysql.com/downloads/connector/net/
    // And uncomment the line below
    class MyDbContext : DbContext
    {
        public MyDbContext():base("DbConnDbJetAccess")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

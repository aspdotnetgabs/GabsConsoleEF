using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabsConsoleEF.Models
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

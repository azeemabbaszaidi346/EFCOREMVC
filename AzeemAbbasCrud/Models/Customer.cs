using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzeemAbbasCrud.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public Location Location { get; set; }
    }
}

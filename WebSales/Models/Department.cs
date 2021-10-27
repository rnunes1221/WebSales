using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSales.Models;
using WebSales.Models.ViewModels;
using System.Collections.Generic;

namespace WebSales.Models 
{
    public class Department 
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


    }
}

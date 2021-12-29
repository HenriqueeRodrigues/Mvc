using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc1.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSales(Seller seller)
        {
            this.Sellers.Add(seller);
        }

        public double TotalSales(DateTime init, DateTime final)
        {

            return Sellers.Sum(y => y.TotalSales(init, final));
        }
    }
}

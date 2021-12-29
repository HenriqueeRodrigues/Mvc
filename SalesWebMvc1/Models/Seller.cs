using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc1.Models
{
    public class Seller
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public ICollection<SallesRecord> Sales { get; set; } = new List<SallesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SallesRecord sr)
        {
            this.Sales.Add(sr);
        }
    
        public void RemoveSales(SallesRecord sr)
        {
            this.Sales.Remove(sr);
        }

        public double TotalSales (DateTime init, DateTime final)
        {

            return Sales.Where(x => x.Date >= init && x.Date <= final).Sum( y => y.Amount);
        }
    }
}

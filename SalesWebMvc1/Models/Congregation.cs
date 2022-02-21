using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Models
{
    public class Congregation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public  string City { get; set; }

        public  string State { get; set; }

        public ICollection<Publisher> Publishers { get; set; } = new List<Publisher>();

        public int SumPublishers { get; set; } 

        //public int? UserId { get; set; }

        public Congregation()
        {
        }

        public Congregation(int id, string name, string city, string state/*, Users users*/)
        {
            Id = id;
            Name = name;
            City = city;
            State = state;
            //Users = users;
        }
        
        public void AddPublishers(Publisher Publisher)
        {
            this.Publishers.Add(Publisher);
        }

        //public double TotalPublishers(DateTime init, DateTime final)
        //{

        //    return Publishers.Sum(y => y.TotalPublisher(init, final));
        //}
    }
}

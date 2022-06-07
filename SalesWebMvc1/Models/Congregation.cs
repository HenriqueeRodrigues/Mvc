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

        public Congregation()
        {
        }

        public Congregation(int id, string name, string city, string state)
        {
            Id = id;
            Name = name;
            City = city;
            State = state;
        }
        
        public void AddPublishers(Publisher Publisher)
        {
            this.Publishers.Add(Publisher);
        }
    }
}

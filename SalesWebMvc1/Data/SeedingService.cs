using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Models.Enums;

namespace SecretaryWebMvc.Data
{
    public class SeedingService
    {
        private SecretaryWebMvcContext _context;

        public SeedingService(SecretaryWebMvcContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            if (_context.Congregation.Any() ||
                 _context.Publisher.Any() ||
                 _context.ActivitiesReport.Any()||
                  _context.User.Any())
            {
                return; // DB has been seeded
            }
            //Users u1 = new Users();

            Congregation c1 = new Congregation(1, "Jd Colorado", "Suzano", "SP");
   

            Publisher p1 = new Publisher(1, "Bob Brown", "Rua 15 nº 2, Jd Brasil - Suzano CEP 0865-111", new DateTime(1998, 4, 21), new DateTime(2008, 4, 21),false,false,false,false, c1);
     

           ActivitiesReport a1 = new ActivitiesReport(1,new DateTime(2022, 1, 2), 10, 2, 15,2, 0, 0, "teste", p1);



            _context.Congregation.AddRange(c1);

            _context.Publisher.AddRange(p1);

            _context.ActivitiesReport.AddRange(
                a1
            );

            _context.SaveChanges();
        }
    }
}

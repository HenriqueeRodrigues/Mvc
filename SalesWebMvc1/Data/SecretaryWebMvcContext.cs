using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Models;

namespace SecretaryWebMvc.Data
{
    public class SecretaryWebMvcContext : DbContext
    {
        public SecretaryWebMvcContext (DbContextOptions<SecretaryWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Congregation> Congregation { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<ActivitiesReport>ActivitiesReport { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Assistance> Assistance{ get; set; }
    }
}

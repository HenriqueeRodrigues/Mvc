using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Services
{
    public class CongregationService
    {
        private readonly SecretaryWebMvcContext _context;

        public CongregationService(SecretaryWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Congregation>> FindAllAsync()
        {
            return await _context.Congregation.OrderBy(x => x.Name).ToListAsync();
        }
        public void Insert(Publisher obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}

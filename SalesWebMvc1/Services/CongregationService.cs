using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Controllers;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Services.Exceptions;
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

        //public async Task FindAllCongregationforAttAsync(Publisher publisher)
        //{
        //    var attCongregationPublisher = await _context.Congregation.Where(x => x.Id == publisher.CongregationId).ToListAsync();

        //    var count = attCongregationPublisher.Select( x => x.SumPublishers.Value);

        //    foreach (var item in attCongregationPublisher)
        //    {
        //        item.SumPublishers = item.SumPublishers + 1;
        //    }

        //    UpdateAsync(attCongregationPublisher);

        //}
        public async Task FindAllCongregationforUpdateAsync(Publisher publisher)
        {
            var congregationUpdate = await _context.Congregation.FirstOrDefaultAsync(x => x.Id == publisher.CongregationId);
            congregationUpdate.SumPublishers = congregationUpdate.SumPublishers + 1;
            _context.Update(congregationUpdate);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Congregation>> FindAllAsync()
        {
            return await _context.Congregation.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task InsertAsync(Congregation obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

    }
}

using SecretaryWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;

namespace SecretaryWebMvc.Services
{
    public class ActivitiesReportService
    {
        private readonly SecretaryWebMvcContext _context;

        public ActivitiesReportService(SecretaryWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<ActivitiesReport>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.ActivitiesReport select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Publisher)
                .Include(x => x.Publisher.Congregation)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Congregation,ActivitiesReport>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.ActivitiesReport select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Publisher)
                .Include(x => x.Publisher.Congregation)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Publisher.Congregation)
                .ToListAsync();
        }
    }
}
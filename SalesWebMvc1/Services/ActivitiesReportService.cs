using SecretaryWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Services.Exceptions;

namespace SecretaryWebMvc.Services
{
    public class ActivitiesReportService
    {
        private readonly SecretaryWebMvcContext _context;

        public ActivitiesReportService(SecretaryWebMvcContext context)
        {
            _context = context;
        }


        public async Task<List<ActivitiesReport>> FindAllAsync()
        {
            return await _context.ActivitiesReport.Include(x => x.Publisher).ToListAsync();
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

        public async Task InsertAsync(ActivitiesReport obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<ActivitiesReport> FindByIdAsync(int id)
        {
            return await _context.ActivitiesReport.Include(obj => obj.Publisher).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.ActivitiesReport.FindAsync(id);
                _context.ActivitiesReport.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Você não pode excluir essas atividades....");
            }
        }

        public async Task UpdateAsync(ActivitiesReport obj)
        {
            bool hasAny = await _context.ActivitiesReport.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
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
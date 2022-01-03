using SecretaryWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Services.Exceptions;
using SecretaryWebMvc.Data;

namespace SecretaryWebMvc.Services
{
    public class PublisherService
    {
        private readonly SecretaryWebMvcContext _context;

        public PublisherService(SecretaryWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Publisher>> FindAllAsync()
        {
            return await _context.Publisher.Include(x => x.Congregation).ToListAsync();
        }

        public async Task InsertAsync(Publisher obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Publisher> FindByIdAsync(int id)
        {
            return await _context.Publisher.Include(obj => obj.Congregation).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Publisher.FindAsync(id);
                _context.Publisher.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete Publisher because he/she has congregation");
            }
        }

        public async Task UpdateAsync(Publisher obj)
        {
            bool hasAny = await _context.Publisher.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
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
    }
}
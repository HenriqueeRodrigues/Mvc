using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Services
{
    public class UserService
    {
        private readonly SecretaryWebMvcContext _context;
        private readonly CongregationService _CongregationService;

        public HttpContext Login { get; set; }

        public UserService(SecretaryWebMvcContext context, CongregationService congregationService)
        {
            _context = context;
            _CongregationService = congregationService;
        }

        public async Task<List<Congregation>> FindAllCongregationAsync()
        {

            var congregações = await _CongregationService.FindAllAsync();

            return congregações;
        }

        public async Task<List<Users>> GetAllAsync()
        {
            
            var users =  await _context.User.Include(x => x.Congregation).ToListAsync();

            return users;

        }

        public async Task<Users> FindAllUsersAsync(string nome)
        {
            
            var users =  await _context.User.Include(x => x.Congregation).FirstOrDefaultAsync( x=> x.Nome == nome);

            return users;

        }

        public async Task<List<Users>> FindAllAsync(string email, string senha)
        {

            var userActives = await _context.User.Include(x => x.Congregation).Where(x => x.Email == email && x.Senha == senha).ToListAsync();

            return userActives;
        }

        public async Task<Users> ValidationEmailAsync(string email)
        {

           //var userActives = await _context.User.Include(x => x.Congregation).Where(x => x.Email == email && x.CongregationId == null).ToListAsync();
            var userActives = await _context.User.Include(x => x.Congregation).FirstAsync(x => x.Email == email && x.CongregationId == null);
            await _context.SaveChangesAsync();

            return userActives;
        }

        public async Task InsertAsync(Users obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Users obj)
        {
            bool hasAny = await _context.User.AnyAsync(x => x.Id == obj.Id);
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

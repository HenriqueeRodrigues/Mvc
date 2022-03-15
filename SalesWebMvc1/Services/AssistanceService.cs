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
    public class AssistanceService
    {
        private readonly SecretaryWebMvcContext _context;

        public AssistanceService(SecretaryWebMvcContext context)
        {
            _context = context;
        }


        public async Task<List<Assistance>> FindAll()
        {
            return await _context.Assistance.Include(x => x.Congregation).ToListAsync();

        }
        public async Task<List<Assistance>> FindCongregationLogged(int congregationId)
        {

            return await _context.Assistance.Where(x => x.CongregationId == congregationId).ToListAsync();

        }


        public async Task<List<Assistance>> FindAllAssistanceMonthAsync(int congUserLoged, DateTime? reportMonth)
        {
            List<Assistance> listResult = new List<Assistance>();

            var getAllActivities = await this._context.Assistance.ToListAsync();

            foreach (var item in getAllActivities)
            {
                if (item.Date.Month == reportMonth?.Date.Month &&
                    item.Date.Year == reportMonth?.Date.Year)
                {
                    listResult.Add(item);
                }
            }

            return listResult;
        }

        public async Task InsertAsync(Assistance obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveIdAsync(int assistanceId)
        {
            try
            {
                var obj = await _context.Assistance.Include(x => x.Congregation).ToListAsync();

                _context.Assistance.Remove(obj.FirstOrDefault(x => x.Id == assistanceId));
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete Publisher because he/she has congregation");
            }
        }
        public async Task RemoveAsync(int? congregationId)
        {
            try
            {

                var obj = await _context.Assistance.Include(x => x.Congregation).Where(x => x.CongregationId == congregationId).ToListAsync();


                DateTime datafim = DateTime.Today;
                DateTime datainicio = datafim;

                // pega o mês anterior...
                datafim = datafim.AddMonths(-3);


                var Henrique = obj.Where(x => x.Date < datafim).ToList();


                foreach (var item in Henrique)
                {
                    _context.Assistance.Remove(item);
                    await _context.SaveChangesAsync();
                }

            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete Publisher because he/she has congregation");
            }
        }

    }
}

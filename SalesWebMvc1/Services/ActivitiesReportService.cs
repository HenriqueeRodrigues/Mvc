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
        private readonly PublisherService _PublisherService;


        public ActivitiesReportService(SecretaryWebMvcContext context, PublisherService _publisherService)
        {
            _context = context;
            _PublisherService = _publisherService;
        }

        public async Task<ActivitiesReport> FindObjAsync()
        {
            return await _context.ActivitiesReport.Include(obj => obj.Publisher).FirstOrDefaultAsync();
        }

        public async Task<List<ActivitiesReport>> FindAllAsync()
        {

            return await _context.ActivitiesReport.Include(x => x.Publisher).ToListAsync();
        }

        public async void SetToPublisherInactive()
        {
            var publisher = await _PublisherService.FindAllPublisherAndCongregationAsync();

            foreach (var item in publisher)
            {
                var publisherId = item.Id;

                var todaAtividaeds = await FindAllAsync();

                foreach (var activities in todaAtividaeds)
                {
                    if (activities.PublisherId == publisherId)
                    {
                        //var mes = activities.Date.Month == null;
                    }
                }
            }
        }

        public async Task<List<ActivitiesReport>> FindAllReporteMonthAsync(int congUserLoged, DateTime? reportMonth)
        {
            List<ActivitiesReport> listResult = new List<ActivitiesReport>();

            var getAllActivities = await this._context.ActivitiesReport
               .Include(x => x.Publisher)
               .ThenInclude(x => x.Congregation).OrderBy(x => x.Publisher.FullName)
                   .ToListAsync();

            foreach (var item in getAllActivities)
            {
                if (item.PublisherId == null)
                {
                    continue;
                }

                if (item.Publisher.CongregationId == congUserLoged &&
                    item.Date.Month == reportMonth?.Date.Month &&
                    item.Date.Year == reportMonth?.Date.Year )
                {
                    listResult.Add(item);
                }
            }
            return listResult;
        }

        public async Task<List<ActivitiesReport>> FindAllAsync(int congUserLoged)
        {
            List<ActivitiesReport> listResult = new List<ActivitiesReport>();

            var getAllActivities = await this._context.ActivitiesReport
               .Include(x => x.Publisher)
               .ThenInclude(x => x.Congregation).OrderBy(x => x.Publisher.FullName)
                   .ToListAsync();

            foreach (var item in getAllActivities)
            {
                if (item.Publisher == null)
                {
                    continue;
                }
                if (item.Publisher.CongregationId == congUserLoged)
                {
                    listResult.Add(item);
                }
            }

            return listResult;

        }

        public async Task<ActivitiesReport> FindAllOneAsync(Users userLoged)
        {
            return await _context.ActivitiesReport
                .Include(x => x.Publisher)
                .ThenInclude(x => x.Congregation)
                    .FirstOrDefaultAsync(x => x.Publisher.CongregationId == userLoged.CongregationId);

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
            var updatePublisherrelated = await _PublisherService.FindAllPublisherAndCongregationAsync();
            var publisherParams = updatePublisherrelated.FirstOrDefault(x => x.Id == obj.PublisherId);

            publisherParams.LastActivitiesRelated = DateTime.Today;
            await _PublisherService.UpdateAsync(publisherParams);
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


        public async Task<List<IGrouping<Congregation, ActivitiesReport>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
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

        public async Task RemoveBatchAsync(List<ActivitiesReport> myCongregationActivities)
        {
            try
            {
                DateTime datafim = DateTime.Today;
                DateTime datainicio = datafim;

                // pega o mês anterior...
                datafim = datafim.AddMonths(-12);

                var Henrique = myCongregationActivities.Where(x => x.Date < datafim).ToList();

                foreach (var item in Henrique)
                {
                    _context.ActivitiesReport.Remove(item);
                    await _context.SaveChangesAsync();
                }

            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete Publisher because he/she has LoteAtividades");
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Models.ViewModels;
using SecretaryWebMvc.Services;
using SecretaryWebMvc.Services.Exceptions;

namespace SecretaryWebMvc.Controllers
{
    public class CongregationsController : Controller
    {

        private readonly SecretaryWebMvcContext _context;
        private readonly CongregationService _CongregationService;
        private readonly PublisherService _PublisherService;
        private readonly ActivitiesReportService _ActivitiesReportService;

        public CongregationsController(SecretaryWebMvcContext context, CongregationService congregationService, PublisherService publisherService, ActivitiesReportService _ActivitiesReportService)
        {
            _context = context;
            _CongregationService = congregationService;
            _PublisherService = publisherService;
        }

        // GET: Congregations
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _PublisherService.FindAllUsersAsync(); // todos

                var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();

                var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado

                var allcong = await _CongregationService.FindAllAsync();


                if (usuarioLogadoObj == null)
                {
                    if (allcong.Count() > 1)
                    {
                        var viewToNewUser1 = allcong.FirstOrDefault();

                        return View(viewToNewUser1);
                    }
                    var viewToNewUser = allcong.LastOrDefault();

                    return View(viewToNewUser);
                }
                var filterCongregationLocal = allcong.FirstOrDefault(x => x.Id == usuarioLogadoObj.CongregationId);


                return View(filterCongregationLocal);
            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }
        public async Task<IActionResult> GoUser()
        {
            return RedirectToAction("Link", "/Login");

        }


        // GET: Congregations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Congregation = await _context.Congregation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Congregation == null)
            {
                return NotFound();
            }

            return View(Congregation);
        }

        // GET: Congregations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Congregations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,City,State")] Congregation congregation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(congregation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(congregation);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Congregation = await _context.Congregation.FindAsync(id);
            if (Congregation == null)
            {
                return NotFound();
            }
            return View(Congregation);
        }

        // POST: Congregations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,City,State,SumPublishers")] Congregation Congregation)
        {
            if (id != Congregation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Congregation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongregationExists(Congregation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Congregation);
        }

        // GET: Congregations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Congregation = await _context.Congregation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Congregation == null)
            {
                return NotFound();
            }

            return View(Congregation);
        }

        // POST: Congregations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherForDelete = _context.Publisher.Where(x => x.CongregationId == id);
            //foreach (var item in publisherForDelete)
            //{
            //    _context.Publisher.Remove(item);
            //    await _context.SaveChangesAsync();

            //}
            try
            {
                var Congregation = await _context.Congregation.FindAsync(id);
                _context.Congregation.Remove(Congregation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException e)
            {
                return RedirectToAction(nameof(Error), new { message = $"Você não pode excluir essa congregação por que existem {publisherForDelete.Count()} publicadores relacionado a ela. Excluia todos primeiro" });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }

        private bool CongregationExists(int id)
        {
            return _context.Congregation.Any(e => e.Id == id);
        }
    }
}

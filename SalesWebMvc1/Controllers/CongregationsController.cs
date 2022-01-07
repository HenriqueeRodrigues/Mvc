using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecretaryWebMvc.Data;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Models.ViewModels;
using SecretaryWebMvc.Services;

namespace SecretaryWebMvc.Controllers
{
    public class CongregationsController : Controller
    {
        private readonly SecretaryWebMvcContext _context;
        private readonly CongregationService _CongregationService;

        public CongregationsController(SecretaryWebMvcContext context, CongregationService congregationService)
        {
            _context = context;
            _CongregationService = congregationService;
        }

        // GET: Congregations
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                return View(await _context.Congregation.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,Name,City,State")] Congregation Congregation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Congregation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Congregation);
        }






        //public IActionResult Link()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Link([Bind("Id,Name")] Congregation Congregation)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(Congregation);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(Congregation);
        //}

        // GET: Congregations/Edit/5
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Congregation Congregation)
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
            var Congregation = await _context.Congregation.FindAsync(id);
            _context.Congregation.Remove(Congregation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CongregationExists(int id)
        {
            return _context.Congregation.Any(e => e.Id == id);
        }
    }
}

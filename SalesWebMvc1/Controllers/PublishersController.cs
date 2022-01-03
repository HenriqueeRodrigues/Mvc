﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Models.ViewModels;
using SecretaryWebMvc.Services;
using SecretaryWebMvc.Services.Exceptions;

namespace SalesWebMvc.Controllers
{
    public class PublishersController : Controller
    {
        private readonly PublisherService _PublisherService;
        private readonly CongregationService _CongregationService;

        public PublishersController(PublisherService PublisherService, CongregationService CongregationService)
        {
            _PublisherService = PublisherService;
            _CongregationService = CongregationService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _PublisherService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var congregations = await _CongregationService.FindAllAsync();
            var viewModel = new PublisherFormViewModel { Congregations = congregations };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Publisher Publisher)
        {
            if (!ModelState.IsValid)
            {
                var Congregations = await _CongregationService.FindAllAsync();
                var viewModel = new PublisherFormViewModel { Publisher = Publisher, Congregations = Congregations };
                return View(viewModel);
            }
            await _PublisherService.InsertAsync(Publisher);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _PublisherService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _PublisherService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _PublisherService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _PublisherService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Congregation> Congregations = await _CongregationService.FindAllAsync();
            PublisherFormViewModel viewModel = new PublisherFormViewModel { Publisher = obj, Congregations = Congregations };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Publisher Publisher)
        {
            if (!ModelState.IsValid)
            {
                var Congregations = await _CongregationService.FindAllAsync();
                var viewModel = new PublisherFormViewModel { Publisher = Publisher, Congregations = Congregations };
                return View(viewModel);
            }
            if (id != Publisher.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                await _PublisherService.UpdateAsync(Publisher);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
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
    }
}
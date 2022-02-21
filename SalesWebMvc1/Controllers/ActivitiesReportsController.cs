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

namespace SecretaryWebMvc.Controllers
{
    public class ActivitiesReportsController : Controller
    {
        private readonly ActivitiesReportService _ActivitiesReportService;
        private readonly PublisherService _PublisherService;
        private readonly UserService _UserService;
        private readonly AssistanceService _AssistanceService;


        public ActivitiesReportsController(ActivitiesReportService activitiesReportService, PublisherService publisherService, UserService userService, AssistanceService _assistanceService)
        {
            _ActivitiesReportService = activitiesReportService;
            _PublisherService = publisherService;
            _UserService = userService;
            _AssistanceService = _assistanceService;    
        }

        public async Task<IActionResult> Index(ActivitiesReport activitiesReport)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (activitiesReport.Date == DateTime.MinValue)
                {

                    ActivitiesReport param = new ActivitiesReport();

                    var userLogedCongregation = await this.GetUserLogadoAndCongregation(param);

                    if (userLogedCongregation.Any(x => x.Publisher.CongregationId == default))
                    {
                        return RedirectToAction(nameof(Error), new { message = "Você ainda não se vinculou a nenhuma congregação. Se vincule para ter acesso as atividades dos publicadores de sua congregação." });

                    }


                    return View(userLogedCongregation);
                }
                else
                {
                    if (activitiesReport.Date == DateTime.MinValue)
                    {
                        return View();
                    }
                    if (User.Identity.IsAuthenticated)
                    {

                        var activitiesLocal = await this.GetUserLogadoAndCongregation(activitiesReport);

                        if (activitiesLocal.Any(x => x.Publisher.CongregationId == default))
                        {
                            return RedirectToAction(nameof(Error), new { message = "Você ainda não se vinculou a nenhuma congregação. Se vincule para ter acesso as atividades dos publicadores de sua congregação." });

                        }

                        var viewlModel = activitiesLocal.Where(x => x.PublisherRelated == false);
                        return View(viewlModel);

                    }
                    else
                    {
                        return RedirectToAction("Index", "/Login");
                    }

                }
               
            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }


        [HttpPost]
        public async Task<IActionResult> IndexReport([Bind("Date")] ActivitiesReport actives )
        {
            if (actives.Date == DateTime.MinValue)
            {
                return View();
            }
            if (User.Identity.IsAuthenticated)
            {
                var userLogedCongregation = await this.GetUserLogadoAndCongregation(actives);

                var congId = userLogedCongregation.FirstOrDefault(x => x.Publisher.CongregationId != 0);

                var assistance = await _AssistanceService.FindCongregationLogged(congId.Publisher.CongregationId);

                var henrique = assistance.Where(x => x.Date.Month == actives.Date.Month).ToList();


                var viewModel = new ActivitiesReportFormViewModel { ActivitiesReports = userLogedCongregation, Assistances = (ICollection<Assistance>)henrique };


                //return View(userLogedCongregation); para a model
                return View(viewModel);
            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }


        private async Task<List<ActivitiesReport>> GetUserLogadoAndCongregation(ActivitiesReport dateSearch)
        {

            if (dateSearch.Date != DateTime.MinValue)
            {
                var user = await _PublisherService.FindAllUsersAsync(); // todos

                var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();

                var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado

                var listMonthResult = await _ActivitiesReportService.FindAllReporteMonthAsync(usuarioLogadoObj.Congregation.Id, dateSearch.Date);


                return listMonthResult;

            }
            else {
                var user = await _PublisherService.FindAllUsersAsync(); // todos

                var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();

                var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado

                var list = await _ActivitiesReportService.FindAllAsync(usuarioLogadoObj.Congregation.Id); // Todas atividades

                return list;
            }
        }

        public async Task<IActionResult> IndexReport()
        {
            if (User.Identity.IsAuthenticated)
            {

                var user = await _PublisherService.FindAllUsersAsync(); // todos

                var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList(); // so o loogado

                if (userLogado.Any(x => x.CongregationId == null))
                {
                    return RedirectToAction(nameof(Error), new { message = "Você ainda não se vinculou a nenhuma congregação. Se vincule para ter acesso as atividades dos publicadores de sua congregação." });

                }

                //var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado

                //var list = await _ActivitiesReportService.FindAllAsync(usuarioLogadoObj);
                return View();
            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }


        public async Task<IActionResult> Create()
        {
            var publishers = await _PublisherService.FindAllPublisherAndCongregationAsync();

            var user = await _PublisherService.FindAllUsersAsync(); // todos

            var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList(); // so o loogado

            var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado


            List<Publisher>pub = new List<Publisher>();

            foreach (var item in publishers)
            {
                if (item.CongregationId == usuarioLogadoObj.CongregationId)
                {
                    pub.Add(item);
                }
            }

            var viewModel = new ActivitiesReportFormViewModel { Publishers = pub };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ActivitiesReport activitiesReport)
        {
            if (!ModelState.IsValid)
            {
                var publishers = await _PublisherService.FindAllPublisherAndCongregationAsync();
                var viewModel = new ActivitiesReportFormViewModel { ActivitiesReport = activitiesReport, Publishers = publishers };
                
                return View(viewModel);
            }
            await _ActivitiesReportService.InsertAsync(activitiesReport);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _ActivitiesReportService.FindByIdAsync(id.Value);
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
                await _ActivitiesReportService.RemoveAsync(id);
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

            var obj = await _ActivitiesReportService.FindByIdAsync(id.Value);
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

            var obj = await _ActivitiesReportService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Publisher> publishers = await _PublisherService.FindAllPublisherAndCongregationAsync();
            ActivitiesReportFormViewModel viewModel = new ActivitiesReportFormViewModel { ActivitiesReport = obj, Publishers = publishers };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ActivitiesReport activitiesReport)
        {
            if (!ModelState.IsValid)
            {
                var publishers = await _PublisherService.FindAllPublisherAndCongregationAsync();
                var viewModel = new ActivitiesReportFormViewModel { ActivitiesReport = activitiesReport, Publishers = publishers };
                return View(viewModel);
            }
            if (id != activitiesReport.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            try
            {
                await _ActivitiesReportService.UpdateAsync(activitiesReport);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _ActivitiesReportService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _ActivitiesReportService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
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

        public async Task<IActionResult> SumAssistance()
        {
            return RedirectToAction("Assistance", "/Assistance");
        }


        public async Task<IActionResult> DeleteBatch()
        {
            await this.DeleteBatchAction();
            return RedirectToAction(nameof(Index));


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBatchAction()
        {
            try
            {
                var user = await _PublisherService.FindAllUsersAsync(); // todos

                var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();

                var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado

                await _ActivitiesReportService.RemoveBatchAsync(usuarioLogadoObj.CongregationId);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }


    }
}
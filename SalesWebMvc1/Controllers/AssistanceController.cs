using Microsoft.AspNetCore.Mvc;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Models.ViewModels;
using SecretaryWebMvc.Services;
using SecretaryWebMvc.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Controllers
{
    public class AssistanceController : Controller
    {
        private readonly ActivitiesReportService _ActivitiesReportService;
        private readonly PublisherService _PublisherService;
        private readonly AssistanceService _AssistanceService;


        public AssistanceController(ActivitiesReportService activitiesReportService, PublisherService publisherService, AssistanceService assistanceService)
        {
            _ActivitiesReportService = activitiesReportService;
            _PublisherService = publisherService;
            _AssistanceService = assistanceService;
        }
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userLogedCongregation = await this.GetUserLogadoAndCongregation();

                if (userLogedCongregation.Any(x => x.Congregation == null))
                {
                    return RedirectToAction(nameof(Error), new { message = "Você ainda não se vinculou a nenhuma congregação. Se vincule para ter acesso as atividades dos publicadores de sua congregação." });

                }

                return View(userLogedCongregation.Where(x => x.Date.Month == DateTime.Now.Month));
            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Quantity,CongregationId")] Assistance assistance)
        {
            if (ModelState.IsValid)
            {
                await _AssistanceService.InsertAsync(assistance);
                return RedirectToAction("Index", "/Assistance");
            }
            return View(assistance);
        }



        public async Task<IActionResult> Assistance()
        {

            if (User.Identity.IsAuthenticated)
            {
                var userLogedCongregation = await this.GetUserLogadoAndCongregation();

                //var usuarioLogadoObj = userLogedCongregation.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado


                if (userLogedCongregation.Any(x => x.CongregationId == default))
                {
                    return RedirectToAction(nameof(Error), new { message = "Você ainda não se vinculou a nenhuma congregação. Se vincule para ter acesso as atividades dos publicadores de sua congregação." });

                }

                //var assitence = await this._AssistanceService.FindCongregationLogged(usuarioLogadoObj.CongregationId);

                //var obj = userLogedCongregation.FirstOrDefault();
                //if (obj == null)
                //{
                var user = await _PublisherService.FindAllUsersAsync(); // todos
                var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();
                var hrn = userLogado.FirstOrDefault(x => x.CongregationId != 0);



                Assistance NewList1 = new Assistance() { Congregation = hrn.Congregation, CongregationId = (int)hrn.CongregationId, Date = DateTime.Today };

                //    return View(NewList1);
                //}

                //Assistance NewList = new Assistance() { Congregation = obj.Congregation , CongregationId = obj.CongregationId, Date = DateTime.Today };

                return View(NewList1);

            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }


        private async Task<List<Assistance>> GetUserLogadoAndCongregation()
        {

            var user = await _PublisherService.FindAllUsersAsync(); // todos

            var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();

            var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);// id da congregação do logado

            if (usuarioLogadoObj == null)
            {
                var gambiarra = new List<Assistance>();
                gambiarra.Add(new Assistance()
                {
                    Congregation = null
                });

                return gambiarra;
            }

            var list = await _AssistanceService.FindAll(); // Todas atividades

            var returnObg = list.Where(x => x.CongregationId == usuarioLogadoObj.CongregationId).ToList();

            return returnObg;
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

                await _AssistanceService.RemoveAsync(usuarioLogadoObj.CongregationId);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
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

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var allAssistance = await _AssistanceService.FindAll();

            if (allAssistance == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            var IdForDelete = allAssistance.FirstOrDefault(x => x.Id == id);


            return View(IdForDelete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _AssistanceService.RemoveIdAsync(id);

                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
    }
}

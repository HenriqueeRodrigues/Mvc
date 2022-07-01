using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Services;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
//using System.HttpContext;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using MySql.Data.MySqlClient;
using SecretaryWebMvc.Models.ViewModels;
using System.Diagnostics;

namespace SecretaryWebMvc.Controllers
{
    public class PrintsController : Controller
    {
        private readonly ActivitiesReportService _ActivitiesReportService;
        private readonly PublisherService _PublisherService;
        private readonly UserService _UserService;
        private readonly AssistanceService _AssistanceService;


        public PrintsController(ActivitiesReportService activitiesReportService, PublisherService publisherService, UserService userService, AssistanceService _assistanceService)
        {
            _ActivitiesReportService = activitiesReportService;
            _PublisherService = publisherService;
            _UserService = userService;
            _AssistanceService = _assistanceService;
        }


        public async Task<IActionResult> Index(Publisher publisher)
        {
            if (User.Identity.IsAuthenticated)
            {
                var viewModel = await GetActivitiesWithMyCongregation(publisher.Id);

                return View(viewModel);

            }
            return RedirectToAction("Index", "/Home");
        }


        private async Task<ActivitiesReportFormViewModel> GetActivitiesWithMyCongregation(int publisherId = default)
        {
            var allActivitiesWhithDateOrWithOut = await this.GetUserLogadoAndCongregation();

            if (allActivitiesWhithDateOrWithOut.Any(x => x.Publisher == null))
            {
                RedirectToAction(nameof(Error), new { message = "Você ainda não se vinculou a nenhuma congregação. Se vincule para ter acesso as atividades dos publicadores de sua congregação." });

            }

            var publishers = await _PublisherService.FindAllPublisherAndCongregationAsync();

            Publisher publisherToCard = new Publisher();


            if (publisherId != default)
            {
                publisherToCard = publishers.FirstOrDefault(x => x.Id == publisherId);
            }


            var activitiesToGetCongId = allActivitiesWhithDateOrWithOut.FirstOrDefault(x => x.Publisher.CongregationId != null);

            if (activitiesToGetCongId == null)
            {
                var viewModelClear = new ActivitiesReportFormViewModel
                {
                    ActivitiesReports = new List<ActivitiesReport>(),
                    Publishers = new List<Publisher>(),
                };

                return viewModelClear;
            }

            var monthCurrentForActivities = DateTime.Now.AddYears(-1);

            var allActivitiesWhithDateOrWithOutFilterMonth = allActivitiesWhithDateOrWithOut.Where(x =>
            x.Date.Year == monthCurrentForActivities.Year && x.Date.Month >= 9 && x.Publisher.Id == publisherId //
            || x.Date.Year == DateTime.Now.Year && x.Date.Month < 9 && x.Publisher.Id == publisherId).ToList();
            
            var viewModel1 = new ActivitiesReportFormViewModel
            {
                ActivitiesReports = allActivitiesWhithDateOrWithOutFilterMonth,
                Publisher = publisherToCard,
                Publishers = publishers.Where(x => x.CongregationId == activitiesToGetCongId.Publisher.CongregationId).OrderBy(x => x.FullName).ToList()
            };

            return viewModel1;
        }


        private async Task<List<ActivitiesReport>> GetUserLogadoAndCongregation()
        {

            var user = await _PublisherService.FindAllUsersAsync();

            var userLogado = user.Where(x => x.Nome == User.Identity.Name).ToList();

            var usuarioLogadoObj = userLogado.FirstOrDefault(x => x.CongregationId != null);

            if (usuarioLogadoObj == null)
            {
                var listEmpty = new List<ActivitiesReport>();
                listEmpty.Add(new ActivitiesReport()
                {
                    Publisher = null
                });

                return listEmpty;
            }

            var list = await _ActivitiesReportService.FindAllAsync(usuarioLogadoObj.Congregation.Id);

            return list;
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

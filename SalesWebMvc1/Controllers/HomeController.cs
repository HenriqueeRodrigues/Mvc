﻿using Microsoft.AspNetCore.Mvc;
using SecretaryWebMvc.Models;
using SecretaryWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SecretaryWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "/Login");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Assistente Secretario JW";
            ViewData["Autor"] = "Henrique.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

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
    public class LoginController : Controller
    {
        private readonly UserService _UserService;

        public LoginController(UserService userService)
        {
            _UserService = userService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "/Home");

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChecarLogin([Bind("Email,Senha")] Users users)
        {
            var userActives = await _UserService.FindAllAsync(users.Email, users.Senha);

            if (userActives.Any())
            {
                var idUser = 0;
                var nameuser = "";
                foreach (var user in userActives)
                {
                    idUser = user.Id;
                    nameuser = user.Nome;
                    //congregationId = user.CongregationId;
                }

                List<Claim> direitoacesso = new List<Claim>
                 {
                    new Claim(ClaimTypes.NameIdentifier, idUser.ToString()),
                    new Claim(ClaimTypes.Name, nameuser.ToString()),

                 };

                var identity = new ClaimsIdentity(direitoacesso, "Identity.Login");
                var userPrincipal = new ClaimsPrincipal(new[] { identity });

                await HttpContext.SignInAsync(userPrincipal,
                    new AuthenticationProperties
                    {
                        IsPersistent = false,
                        ExpiresUtc = DateTime.Now.AddHours(1)
                    });

                return RedirectToAction("Index", "Home");
            }
            else
            {
                await Logout();
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
            }

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Users users)
        {
            var emailExist = await _UserService.FindAllAsync(users.Email, users.Senha);

            if (emailExist.Any())
            {
                return RedirectToAction(nameof(Error), new { message = "O Email já existe em nossos registros. Tente outro" });

            }
            else
            {
                if (ModelState.IsValid)
                {
                    await _UserService.InsertAsync(users);
                    return RedirectToAction(nameof(Index));
                }
                return View();
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

        public async Task<IActionResult> Link()
        {

            var nomeVerificação = User.Identity.Name; // Estudar uma maneira melhor de pegar o id converter do claims


            var cong = await _UserService.FindAllCongregationAsync();
            var user = await _UserService.FindAllUsersAsync(nomeVerificação);

            var viewModel = new CongregationFormViewModel { Users = user, UserCongregations = cong };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Linky(Users users)
        {
            //var validationCongregation = await _UserService.ValidationEmailAsync(users.Email);

            //if (validationCongregation == null)
            //{
            //    return RedirectToAction(nameof(Error), new { message = "Seu Usuário já está vinculado a uma Congregação" });
            //}

            await _UserService.UpdateAsync(users);
            return RedirectToAction(nameof(Index));


            //var cong = await _UserService.FindAllCongregationAsync();
            //var viewModel = new CongregationFormViewModel { UserCongregations = cong, Users = users };
            //return View(viewModel);

        }
    }
}

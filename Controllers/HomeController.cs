//**********************************************************************************
// HomeController.cs
// ASP.NET Core MVC (.NET 7)
// ---------------------------------------------------------------------------------
//  С# | Visual Studio 2022
//  ASP.NET Core MVC (.NET 7) 
//  Template ASP NET (Model-View-Controller)
// ---------------------------------------------------------------------------------
// Gosha Dudar | Изучение ASP.NET Core с нуля |
// Разработка веб проекта на Core MVC (.NET 6) 
//
// Writing by sgiman @ 2023
//**********************************************************************************

using Microsoft.AspNetCore.Mvc;     // model(M)-view(V)-controller(C)
using SgimanWebSite.Models;         // my models
using System.Diagnostics;

// ------------------------
//  Controller (Home)
// ------------------------

namespace SgimanWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Отобразить index.html (шаблон)
        public IActionResult Index()
        {
            return View();
        }
    }
}

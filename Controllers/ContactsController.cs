//**********************************************************************************
// ContactController1.cs
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

using Microsoft.AspNetCore.Mvc;
using SgimanWebSite.Models;

// ------------------------
//  Controller (Conatcts)
// ------------------------

namespace SgimanWebSite.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()    // page Contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)    // form Contact
        {
            if(ModelState.IsValid)
            {  
                return Redirect("/");   // Home/index (шаблон)               
            }
            
            return View("Index");       // Contact/index (шаблон)

        }

    }
}

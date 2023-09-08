
//**********************************************************************************
// Contact.cs
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

// --- MODEL ---

using System.ComponentModel.DataAnnotations; // атрибуты и валидация

namespace SgimanWebSite.Models
{
    public class Contact
    {
        // --- Form Fields ---
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string SurName { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам нужно ввести почту")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [StringLength(30, ErrorMessage = "Текст менее 30 символов")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        public string Message { get; set; }

    }
}

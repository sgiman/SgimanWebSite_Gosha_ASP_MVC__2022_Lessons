//**********************************************************************************
// Program.cs
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

var builder = WebApplication.CreateBuilder(args);

// Добавьте сервисы в контейнер.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настройте конвейер HTTP-запросов.
// В среде Development не отображаются страницы с кодами ошибок сервера  
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Значение HSTS по умолчанию — 30 дней.
    // Возможно, вы захотите изменить это для производственных сценариев,
    // см. https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

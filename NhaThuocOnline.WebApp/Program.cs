using NhaThuocOnline.ApiIntergration;
using System.Security.Policy;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();

//DI
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IProductApiClient, ProductApiClient>();
builder.Services.AddTransient<IPrescriptionApiClient, PrescriptionApiClient>();
builder.Services.AddTransient<ICustomerApiClient, CustomerApiClient>();


//add sessions
//builder.Services.AddSession(option =>
//{
//    option.Cookie.Name = "NtoCookie";
//    option.IdleTimeout = TimeSpan.FromHours(2);

//});



builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

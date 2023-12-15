using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NhaThuocOnline.Application.Interface;
using NhaThuocOnline.Application.Service;
using NhaThuocOnline.Data.EF;
using NhaThuocOnline.Data.Entities;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddDbContext<NhaThuocOnlineDbContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("NhaThuocOnlineDb")));

builder.Services.AddIdentity<AppStaffAccount, AppStaffRole>()
    .AddEntityFrameworkStores<NhaThuocOnlineDbContext>()
    .AddDefaultTokenProviders();

//DI

builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IFileStorageService, FileStorageService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBooksRepository, BooksRepository>();
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
builder.Services.AddScoped<IDiscountsRepository, DiscountsRepository>();
builder.Services.AddScoped<IFinesRepository, FinesRepository>();
builder.Services.AddScoped<ILendingsRepository, LendingsRepository>();

// Add services to the container.
builder.Services.AddRazorPages();

string connectionString = "Server = 127.0.0.1; Database = Library; User Id = root; Password = bober2467;";

builder.Services.AddDbContext<LibraryDBContext>(option => {
    option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

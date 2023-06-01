using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fitness.Data;
using Microsoft.AspNetCore.Identity;
using Fitness.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FitnesssContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FitnesssContext") ?? throw new InvalidOperationException("Connection string 'FitnessContext' not found.")));

builder.Services.AddDefaultIdentity<FitnessUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<FitnessContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

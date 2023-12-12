using Microsoft.EntityFrameworkCore;
using PCBuilder.Service.Implementations;
using PCBuilder.Service.Interfaces;
using PCBuilderMVC.DAL;
using PCBuilderMVC.DAL.Interfaces;
using PCBuilderMVC.DAL.Repositories;
using PCBuilderMVC.Domain.Entities;

namespace PCBuilderMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection)
            );
            builder.Services.AddScoped<IBaseRepository<PC>, PCRepository>();
            builder.Services.AddScoped<IPCService, PCService>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddControllersWithViews();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
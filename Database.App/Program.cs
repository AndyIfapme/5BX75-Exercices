using Database.Infrastucture;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Database.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<DataContext>((provider, options) =>
            {
                // options.UseInMemoryDatabase("database-dev");
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")!,
                    x =>
                    {
                        x.EnableRetryOnFailure();
                    });
            });

            var app = builder.Build();
            ResetDatabase(app.Services);

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
        }

        [Conditional("RESETDB")]
        static void ResetDatabase(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var dbContext = services.GetRequiredService<DataContext>();
                DbInitializer.Initialize(dbContext);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();

                logger.LogError(ex, "An error occurred while seeding the database.");
            }
        }
    }
}
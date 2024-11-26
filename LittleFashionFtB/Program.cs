using Microsoft.EntityFrameworkCore;
using static LittleFashionFtB.DAL.AppDContext;

namespace LittleFashionFtB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer("server=DELL\\SQLEXPRESS;database=LittleFashionDB;trusted_connection=true;Encrypt=false")
            );

            var app = builder.Build();

            app.MapControllerRoute(
                name: "defoult",
                pattern: "{controller=Home}/{action=index}"
            );

            app.UseStaticFiles();
            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IProductService, ProductService>();



            builder.Services.AddDbContext<ProductContext>(config =>
                config.UseSqlServer(builder.Configuration.GetConnectionString("sqlDb"))
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
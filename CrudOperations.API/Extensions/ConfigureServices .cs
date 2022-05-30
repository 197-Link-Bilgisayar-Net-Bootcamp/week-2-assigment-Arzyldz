using CrudOperations.API.Models;
using CrudOperations.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.API.Extensions
{
    public static class ConfigureServices
    {
        public static void AddServices(IServiceCollection services, IConfiguration confign)
        {
            services.AddDbContext<MyDataContext>(options =>
            {
                options.UseSqlServer(confign.GetConnectionString("WebApiDatabase"));
            });


            services.AddScoped<IRepository<Product>, ProductRepository>();
        }
    }
}

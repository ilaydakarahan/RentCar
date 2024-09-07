using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Application.Services
{
    public static class ServiceRegistiration 
        
    //ServiceRegistiration sayfası sayesinde cqrs'de olduğu gibi handle ları program.cs içine tek tek yazmıyoruz.
    //Alttaki metodu tanımlayıp bunu da program.cs'e bildiriyoruz.
    
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObserveServices.Core
{
    public class ObserveServicesMiddleware
    {
        private readonly RequestDelegate _next;
        private IServiceCollection _services;

        public ObserveServicesMiddleware(RequestDelegate next, IServiceCollection services)
        {
            _next = next;
            _services = services;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync(JsonSerializer.Serialize(AnalyzeServices(), new JsonSerializerOptions
            {
                WriteIndented = true
            }));
        }

        private Services AnalyzeServices()
        {
            Services services = new Services();

            Func<ServiceLifetime, IEnumerable<string>> filter = (lifeTime) =>
            {
                return _services.Where(x => x.Lifetime == lifeTime)
                               .Select(x => x.ServiceType.ToString());
            };

            services.TransientServices = filter(ServiceLifetime.Transient);

            services.ScopedServices = filter(ServiceLifetime.Scoped);

            services.SingletonServices = filter(ServiceLifetime.Singleton);

            return services;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            context.Response.StatusCode = 200;

            context.Response.ContentType = "text/html;charset=utf-8";

            using (var stream = typeof(ObserveServicesMiddleware).Assembly.GetManifestResourceStream("ObserveServices.Core.Models.index.html"))
            {
                var htmlBuilder = new StringBuilder(new StreamReader(stream).ReadToEnd());

                foreach (var entry in GetIndexArguments())
                {
                    htmlBuilder.Replace(entry.Key, entry.Value);
                }

                await context.Response.WriteAsync(htmlBuilder.ToString(), Encoding.UTF8);

            }

            //await context.Response.WriteAsync(JsonSerializer.Serialize(AnalyzeServices(), new JsonSerializerOptions
            //{
            //    WriteIndented = true
            //}));
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

            filter(ServiceLifetime.Transient).Select(x => new ServicesModel
            {
                Type = "Transient",
                Name = x
            });

            var v = _services.GroupBy(x => x.Lifetime)
                             .SelectMany(x => new ServicesModel
                             {
                                 Type = x.Key.ToString(),
                                 Name = x.
                             });

            return services;
        }

        private IDictionary<string, string> GetIndexArguments()
        {
            var v = AnalyzeServices();

            var l = new List<object>();

            l.Add(v.ScopedServices.Select(x => new
            {
                Type = "Scoped",
                Name = x,
            }));

            l.Add(v.TransientServices.Select(x => new
            {
                Type = "Transient",
                Name = x,
            }));

            return new Dictionary<string, string>()
            {
                //    { "%(ConfigObject)", JsonSerializer.Serialize(AnalyzeServices(),new JsonSerializerOptions
                //{
                //    WriteIndented = true
                //})}

                    { "%(ConfigObject)", JsonSerializer.Serialize(l ,new JsonSerializerOptions
                {
                    WriteIndented = false
                })}


            };
        }
    }
}

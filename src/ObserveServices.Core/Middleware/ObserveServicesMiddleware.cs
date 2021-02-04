using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
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
            Services services = new Services
            {
                ServicesModels = _services.Select(x => new ServicesModel
                {
                    Type = x.Lifetime.ToString(),
                    Name = x.ServiceType.ToString()
                }).ToList()
            };

            return services;
        }

        private IDictionary<string, string> GetIndexArguments()
        {
            var v = AnalyzeServices();

            return new Dictionary<string, string>()
            {
                //    { "%(ConfigObject)", JsonSerializer.Serialize(AnalyzeServices(),new JsonSerializerOptions
                //{
                //    WriteIndented = true
                //})}

                    { "%(ConfigObject)", JsonSerializer.Serialize(v.ServicesModels ,new JsonSerializerOptions
                {
                    WriteIndented = false
                })}


            };
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ObserveServices.Core
{
    public static class Extensions
    {
        public static IApplicationBuilder UseObserveServices(this IApplicationBuilder applicationBuilder, IServiceCollection services)
        {
            IConfiguration configuration;

            using var app = applicationBuilder.ApplicationServices.CreateScope();

            configuration = app.ServiceProvider.GetRequiredService<IConfiguration>();

            string endpointAddress = configuration["ObserviceServices:endpoint"];

            if (string.IsNullOrEmpty(endpointAddress))
            {
                endpointAddress = "observe-services";
            }

            return applicationBuilder.Map($"/{endpointAddress}", builder => builder.UseMiddleware<ObserveServicesMiddleware>(services));
        }
    }
}

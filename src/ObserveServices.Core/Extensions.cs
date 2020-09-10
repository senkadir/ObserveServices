using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ObserveServices.Core
{
    public static class Extensions
    {
        public static IApplicationBuilder UseObserveServices(this IApplicationBuilder applicationBuilder, IServiceCollection services)
        {
            return applicationBuilder.Map("/observe-services", builder => builder.UseMiddleware<ObserveServicesMiddleware>(services));
        }
    }
}

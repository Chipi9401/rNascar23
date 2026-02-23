using Microsoft.Extensions.DependencyInjection;
using rNascar26.PitStops.Ports;
using rNascar26.Service.PitStops.Adapters;

namespace rNascar26.Service.PitStops
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPitStops(this IServiceCollection services)
        {
            services
                .AddTransient<IPitStopsRepository, PitStopsRepository>();

            return services;
        }
    }
}
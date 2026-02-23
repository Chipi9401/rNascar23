using Microsoft.Extensions.DependencyInjection;
using rNascar26.LapTimes.Ports;
using rNascar26.Service.LapTimes.Adapters;

namespace rNascar26.Service.LapTimes
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLapTimes(this IServiceCollection services)
        {
            services
                .AddTransient<IMoversFallersService, MoversFallersService>()
                .AddTransient<ILapTimesRepository, LapTimesRepository>()
                .AddTransient<ILapAveragesRepository, LapAveragesRepository>();

            return services;
        }
    }
}

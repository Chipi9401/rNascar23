using Microsoft.Extensions.DependencyInjection;
using rNascar26.LoopData.Ports;
using rNascar26.Service.LiveFeeds;
using rNascar26.Service.LoopData.Adapters;

namespace rNascar26.Service.LoopData
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLoopData(this IServiceCollection services)
        {
            services
                .AddSchedules()
                .AddTransient<IDriverInfoRepository, DriverInfoRepository>()
                .AddTransient<ILoopDataRepository, LoopDataRepository>();

            return services;
        }
    }
}

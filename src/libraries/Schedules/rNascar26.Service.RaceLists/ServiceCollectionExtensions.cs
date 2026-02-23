using Microsoft.Extensions.DependencyInjection;
using rNascar26.Schedules.Ports;
using rNascar26.Service.RaceLists.Adapters;

namespace rNascar26.Service.LiveFeeds
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSchedules(this IServiceCollection services)
        {
            services
                .AddTransient<ISchedulesRepository, SchedulesRepository>();

            return services;
        }
    }
}

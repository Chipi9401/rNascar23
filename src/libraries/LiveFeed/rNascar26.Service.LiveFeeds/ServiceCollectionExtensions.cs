using Microsoft.Extensions.DependencyInjection;
using rNascar26.Data.LiveFeeds.Ports;
using rNascar26.LiveFeeds.Ports;
using rNascar26.Service.LiveFeeds.Adapters;

namespace rNascar26.Service.LiveFeeds
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLiveFeed(this IServiceCollection services)
        {
            services
                .AddTransient<IKeyMomentsRepository, KeyMomentsRepository>()
                .AddTransient<IWeekendFeedRepository, WeekendFeedRepository>()
                .AddTransient<ILiveFeedRepository, LiveFeedRepository>();

            return services;
        }
    }
}

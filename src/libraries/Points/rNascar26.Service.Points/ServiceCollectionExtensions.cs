using Microsoft.Extensions.DependencyInjection;
using rNascar26.Points.Ports;
using rNascar26.Service.Points.Adapters;

namespace rNascar26.Service.Points
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPoints(this IServiceCollection services)
        {
            services
                .AddTransient<IPointsRepository, PointsRepository>();

            return services;
        }
    }
}

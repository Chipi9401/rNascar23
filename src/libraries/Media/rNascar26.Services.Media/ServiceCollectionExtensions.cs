using Microsoft.Extensions.DependencyInjection;
using rNascar26.Media.Ports;

namespace rNascar26.Service.Media
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMedia(this IServiceCollection services)
        {
            services
                .AddSingleton<IMediaRepository, MediaRepository>();

            return services;
        }
    }
}

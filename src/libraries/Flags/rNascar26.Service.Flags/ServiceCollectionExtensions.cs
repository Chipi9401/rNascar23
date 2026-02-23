using Microsoft.Extensions.DependencyInjection;
using rNascar26.Data.Flags.Ports;
using rNascar26.Service.Flags.Adapters;

namespace rNascar26.Service.Flags
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFlagState(this IServiceCollection services)
        {
            services
                .AddTransient<IFlagStateRepository, FlagStateRepository>();

            return services;
        }
    }
}

using Vanguard.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;
using Vanguard.Core.IoC;

namespace Vanguard.Container.Bootstrappers
{
    public static class MapperBootstrapper
    {
        public static void RegisterMapper(this IServiceCollection services)
        {

            services.RegisterMapper<MapperProfile>();
        }
    }
}

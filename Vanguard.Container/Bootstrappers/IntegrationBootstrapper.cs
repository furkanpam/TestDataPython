using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace Vanguard.Container.Bootstrappers
{
    public static class IntegrationBootstrapper
    {
        public static void RegisterIntegration(this IServiceCollection services)
        {

        }

        public static IApplicationBuilder IntegrationHelperConfig(this IApplicationBuilder app)
        {
            throw new NotImplementedException();
        }
    }
}

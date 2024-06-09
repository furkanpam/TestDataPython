using Framework.Cache.IoC;
using Vanguard.Abstraction.Settings;
using Vanguard.Core.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Container.Bootstrappers
{
    public static class CacheBootstrapper
    {
        public static void RegisterCache(this IServiceCollection services)
        {
            services.RegisterMemoryCache(configuration =>
            {
                configuration.ExpirationScanFrequency = TimeSpan.FromHours(24);
                configuration.SizeLimit = 1000;
            });

            var config = AppSettingsHelper.GetData<RedisSettings>();
            services.RegisterRedisCache(configuration =>
            {
                configuration.Host = config.Host;
                configuration.Port = config.Port;
                configuration.Username = config.Username;
                configuration.Password = config.Password;
                configuration.Timeout = config.Timeout;
            });
        }
    }
}

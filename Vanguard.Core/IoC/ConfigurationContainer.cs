using Microsoft.Extensions.Configuration;
using Winton.Extensions.Configuration.Consul;

namespace Vanguard.Core.IoC
{
    public static class ConfigurationContainer
    {
        public static void RegisterConsul(this IConfigurationManager configuration)
        {

            string settingsFileName = "appsettings.json";
            string applicationName = "Vanguard_Dev";

            //#if DEBUG
            //            applicationName = Environment.GetEnvironmentVariable("applicationName");
            //#endif

            string consulUrl = Environment.GetEnvironmentVariable("consulURL");

            string key = applicationName + "/" + settingsFileName;
            configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration.AddConsul(key, config =>
            {
                config.ConsulConfigurationOptions = cco => { cco.Address = new Uri(consulUrl); };
                config.Optional = true;
                config.PollWaitTime = TimeSpan.FromMinutes(1);
                config.ReloadOnChange = true;
                config.OnLoadException = ctx =>
                {
                    ctx.Ignore = true;
                    configuration
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile(key, true, true);
                };
                config.OnWatchException = cxt =>
                {
                    var exp = cxt.Exception;
                    return config.PollWaitTime;
                };
            });
        }
    }
}

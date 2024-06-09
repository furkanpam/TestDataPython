using Framework.CQRS.Core.Configurations;
using Framework.CQRS.Core.IoC;
using Vanguard.Abstraction.Settings;
using Vanguard.Core.Helpers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Container.Bootstrappers
{
    public static class CQRSBootstrapper
    {
        public static void RegisterCQRS(this IServiceCollection services)
        {
            string moduleName = "Vanguard.Application";
            services.LoadCQRS(w =>
            {
                w.ModuleName = moduleName;
            });

            var mqSettings = AppSettingsHelper.GetData<CqrsMQSettings>();
            services.RegisterCqrsMQ(config =>
            {
                config.Durable = mqSettings.Durable;
                config.QueueName = mqSettings.QueueName;
                config.UserName = mqSettings.UserName;
                config.Password = mqSettings.Password;
                config.Exclusive = mqSettings.Exclusive;
                config.AutoDelete = mqSettings.AutoDelete;
                config.HostName = mqSettings.HostName;
                config.QPort = mqSettings.QPort;
            });
        }
    }
}

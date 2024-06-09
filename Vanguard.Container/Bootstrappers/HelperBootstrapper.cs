using Vanguard.Core.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Container.Bootstrappers
{
    public static class HelperBootstrapper
    {
        public static IApplicationBuilder AddHelpers(this IApplicationBuilder app)
        {
            var service = app.ApplicationServices.GetRequiredService<IActionDescriptorCollectionProvider>();
            RouteInfoHelper.Configure(service);
            return app;
        }
    }
}

using Vanguard.Abstraction.Data.Context;
using Vanguard.Abstraction.Data.EfCore.UnitOfwork;
using Vanguard.Core.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Core.IoC
{
    public static class UnitOfWorkContainer
    {
        /// <summary>
        /// Modullerde Unitofwork oluştururken bunu kullanacağız.
        /// </summary>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="services"></param>
        public static void RegisterUnitOfWork<TContext>(this IServiceCollection services)
            where TContext : DbContextBase
        {
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWork<TContext>, UnitOfWork<TContext>>();
        }
    }
}

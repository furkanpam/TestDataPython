using Vanguard.Abstraction.Exceptions;
using Vanguard.Abstraction.Settings;
using Vanguard.Abstraction.StatusCodes;
using Vanguard.Core.Configurations;
using Vanguard.Core.Extensions;
using Vanguard.Core.Helpers;
using Vanguard.Core.Utilties.Encryption;
using Vanguard.Domain.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Container.Bootstrappers
{
    public static class DbBootstrapper
    {
        public static void AddDbContext(this IServiceCollection services)
        {
            DatabaseSettings dbSettings = AppSettingsHelper.GetData<DatabaseSettings>();
            string key = ResourceHelper.GetString("TripleDesKey");
            Console.WriteLine(key);
            if (string.IsNullOrEmpty(key))
                throw new BusinessException(StatusCodes.Status111DataNotFound, "Triple Des Key Not Found!");

            string decryptStr = TripleDesEncryption.Decrypt(dbSettings.ConnectionString, key);
            Console.WriteLine(decryptStr);
            services.AddBackendDataEF<VanguardDbContext>(new ContextConfiguration
            {
                ConnectionString = decryptStr,
                DatabaseType = dbSettings.DatabaseType
            });

            services.AddBackendDataEF<VanguardHealthCheckDbContext>(new ContextConfiguration
            {
                ConnectionString = decryptStr,
                DatabaseType = dbSettings.DatabaseType
            });
        }

        public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            var mongodbConfig = configuration.GetSection("Databases:MongoDbSettings").Get<MongoDbSettings>(); ;
            services.Configure<MongoDbSettings>(config => 
            {
                config = mongodbConfig;
            });

            services.AddSingleton<IMongoDbSettings>(serviceProvider =>
                serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);
        }
    } 
}

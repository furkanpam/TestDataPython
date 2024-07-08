using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanguard.Abstraction.Attributes;
using Vanguard.Abstraction.Enums;

namespace Vanguard.Abstraction.Settings
{
    [AppSetting(Path = "Databases:PostgreSql")]
    public class DatabaseSettings : ISettingsBase
    {
        public string DbKey { get; set; }
        public DatabaseType DatabaseType { get; set; }
        public string ConnectionString { get; set; }
    }
}

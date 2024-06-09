using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Abstraction.Contracts.Responses
{
    public class SignInResponse
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string RefreshToken { get; set; }
        public string UserStatus { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ShortName { get; set; }
        public long UserId { get; set; }
    }
}

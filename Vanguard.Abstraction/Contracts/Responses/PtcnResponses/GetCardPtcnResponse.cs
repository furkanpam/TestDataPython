using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Abstraction.Contracts.Responses.PtcnResponses
{
    public class GetCardPtcnResponse
    {
        public string PTCN { get; set; }
        public string StateCode { get; set; }
        public bool PtcnStatus { get; set; }
        public bool BinDelayedAuthStatus { get; set; }
        public bool OfflineStatus { get; set; }
        public string BankCode { get; set; }
        public string BankCountryCode { get; set; }
    }
}

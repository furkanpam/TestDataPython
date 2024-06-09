using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Abstraction.Consts
{
    public static class TransactionTypeIndicators
    {
        public const string DelayedAuthorization = "00";
        public const string Prefunded = "01";
        public const string RealTimeAuthorized = "02";
        public const string PostAuthorizedAggregated = "03";
        public const string AuthorizedAggregatedSplitClearing = "04";
        public const string Other = "05";
        public const string PostAuthorizedAggregatedMaestro = "06";
        public const string DebtRecovery = "07";
        public const string ReservedForFutureUse = "08-97";
        public const string OfflineTransactionForTransportationFareCollection = "98";
        public const string RealTimeAuthorizedBalanceTopUpForTransportationServices = "99";
    }
}

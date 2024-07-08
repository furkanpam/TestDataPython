using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanguard.Abstraction.Domain;

namespace Vanguard.Domain.Entities
{
    public class DebitCard : CardEntity
    {
        public bool BlockedByIncorrectPinEntries { get; set; }
        public bool PosYD { get; set; }
        public bool PosYI { get; set; }
        public bool WithdrawalYD { get; set; }
        public bool WithdrawalYI { get; set; }
        public string CardNumber { get; set; }
        public string CardTitle { get; set; }
        public string CardStatus { get; set; }
        public string CardStatusCode { get; set; }
        public string CardStyleCode { get; set; }
        public string CardStyleName { get; set; }
        public string CardType { get; set; }
        public int AccountBranchCode { get; set; }
        public int AccountNumber { get; set; }
        public int AccountSuffix { get; set; }
        public string AccountCurrency { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime LastTranDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool ECommerceYI { get; set; }
        public bool ECommerceYD { get; set; }
        public bool MailOrderYI { get; set; }
        public bool MailOrderYD { get; set; }
        public int CardBranchCode { get; set; }
        public string CardEmboss { get; set; }
        public string CardGroup { get; set; }
        public string CardUniqueId { get; set; }
        public string DetailCode { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public int StatusCode { get; set; }
        public string TxId { get; set; }

}
}


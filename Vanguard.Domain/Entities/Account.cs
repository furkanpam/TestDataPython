using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanguard.Abstraction.Domain;
using Vanguard.Core.Domain.Entity;

namespace Vanguard.Domain.Entities
{
    public class Account:  CardEntity
    {
        public string Channel { get; set; }
        public string Language { get; set; }
        public string AccountBranchName { get; set; }
        public string AccountClosingDate { get; set; }
        public object AccountClosingUserCode { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal Balance { get; set; }
        public string BlockageExplanation { get; set; }
        public string BlockageReasonCode { get; set; }
        public string BlockageReasonCodeName { get; set; }
        public string BlockageType { get; set; }
        public string BlockageUserCode { get; set; }
        public bool CanBeDisplayed { get; set; }
        public bool CanBeUsedInTransactions { get; set; }
        public string CurrencyCode { get; set; }
        public string DormantFlag { get; set; }
        public int GeneralLedgerNumber { get; set; }
        public string Iban { get; set; }
        public Identifier Identifier { get; set; }
    }

}

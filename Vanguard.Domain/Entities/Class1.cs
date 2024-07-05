using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Domain.Entities
{
    public class RootObject
    {
        public DataObject Data { get; set; }
        public HeaderObject Header { get; set; }
    }

    public class DataObject
    {
        public AccountSubTotalAmounts AccountSubTotalAmounts { get; set; }
        public List<Account> Accounts { get; set; }
        public BmdAccount BmdAccount { get; set; }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public decimal TotalEurAllBalance { get; set; }
        public decimal TotalEurChBalance { get; set; }
        public decimal TotalEurKhBalance { get; set; }
        public decimal TotalTRYAllBalance { get; set; }
        public decimal TotalTRYAllBalanceWithInvestment { get; set; }
        public decimal TotalTRYchBalance { get; set; }
        public decimal TotalTRYkhBalance { get; set; }
        public decimal TotalUsdAllBalance { get; set; }
        public decimal TotalUsdChBalance { get; set; }
        public decimal TotalUsdKhBalance { get; set; }
    }

    public class AccountSubTotalAmounts
    {
        public decimal SubTotalEurChOtherBalance { get; set; }
        public decimal SubTotalEurChTRYBalance { get; set; }
        public decimal SubTotalEurChXAGBalance { get; set; }
        public decimal SubTotalEurChXAUBalance { get; set; }
        public decimal SubTotalEurKhOtherBalance { get; set; }
        public decimal SubTotalEurKhTRYBalance { get; set; }
        public decimal SubTotalEurKhXAGBalance { get; set; }
        public decimal SubTotalEurKhXAUBalance { get; set; }
        public decimal SubTotalOtherBalance { get; set; }
        public decimal SubTotalTRYBalance { get; set; }
        public decimal SubTotalTRYchOtherBalance { get; set; }
        public decimal SubTotalTRYchTRYBalance { get; set; }
        public decimal SubTotalTRYchXAGBalance { get; set; }
        public decimal SubTotalTRYchXAUBalance { get; set; }
        public decimal SubTotalTRYkhOtherBalance { get; set; }
        public decimal SubTotalTRYkhTRYBalance { get; set; }
        public decimal SubTotalTRYkhXAGBalance { get; set; }
        public decimal SubTotalTRYkhXAUBalance { get; set; }
        public decimal SubTotalUsdChOtherBalance { get; set; }
        public decimal SubTotalUsdChTRYBalance { get; set; }
        public decimal SubTotalUsdChXAGBalance { get; set; }
        public decimal SubTotalUsdChXAUBalance { get; set; }
        public decimal SubTotalUsdKhOtherBalance { get; set; }
        public decimal SubTotalUsdKhTRYBalance { get; set; }
        public decimal SubTotalUsdKhXAGBalance { get; set; }
        public decimal SubTotalUsdKhXAUBalance { get; set; }
        public decimal SubTotalXAGBalance { get; set; }
        public decimal SubTotalXAUBalance { get; set; }
    }

    public class Account
    {
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
        public string IntervalDepositValueDate { get; set; }
        public bool IsAggregatedAccount { get; set; }
        public bool IsBlockedAccount { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDisplayedOnInternet { get; set; }
        public bool IsFavouriteAccount { get; set; }
        public bool IsPartialBlockedAccount { get; set; }
        public bool IsPersonnelAccount { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string MaturityDate { get; set; }
        public int MaturityType { get; set; }
        public object MaturityTypeDefinition { get; set; }
        public string Name { get; set; }
        public string OriginalProductCode { get; set; }
        public bool ParticipationAccount { get; set; }
        public string ProductCode { get; set; }
        public object ProfitAccrualFrequency { get; set; }
        public object ProfitAccrualFrequencyDefinition { get; set; }
        public decimal ProfitRate { get; set; }
        public string ProjectCode { get; set; }
        public string ShortName { get; set; }
        public decimal TotalPartialBlockageAmount { get; set; }
        public string TracingFlag { get; set; }
        public DateTime ValueDate { get; set; }
    }


    public class BmdAccount
    {
        public decimal BmdAccountBalance { get; set; }
        public int BmdBranchCode { get; set; }
        public int BmdCustomerNumber { get; set; }
        public decimal BmdTotalAmount { get; set; }
        public decimal Bmdt2Balance { get; set; }
        public decimal BmdtotalFund { get; set; }
        public decimal BmdtotalKiraSertifika { get; set; }
        public decimal BmdtotalPortfolio { get; set; }
        public decimal CalculatePortfolioTotal { get; set; }
        public decimal TotalElus { get; set; }
        public decimal TotalFundStock { get; set; }
    }

    public class HeaderObject
    {
        public string DetailCode { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public int StatusCode { get; set; }
        public string TxId { get; set; }
        public List<WarningObject> Warnings { get; set; }
    }

    public class WarningObject
    {
        public string Key { get; set; }
        public string Text { get; set; }
    }

}

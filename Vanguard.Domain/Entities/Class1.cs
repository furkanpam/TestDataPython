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

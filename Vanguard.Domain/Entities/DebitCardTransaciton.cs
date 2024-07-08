using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanguard.Abstraction.Domain;

namespace Vanguard.Domain.Entities
{
    public class DebitCardTransaciton : CardEntity
    {
        public string Language { get; set; }
        public string CardNumber { get; set; }
         public DateTime TranDate { get; set; }
            public string TranCode { get; set; }
            public string BankCode { get; set; }
            public string AccountText { get; set; }
            public string Explanation { get; set; }
            public double Amount { get; set; }
            public string DetailCode { get; set; }
            public string Message { get; set; }
            public string Status { get; set; }
            public int StatusCode { get; set; }
            public string TxId { get; set; }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WholeSaleEngineeringApi.Response
{
    public class AccountResponse
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public DateTime BalanceDate { get; set; }
        public string CurrencyType { get; set; }
        public double OpeningBalance { get; set; }
    }
}

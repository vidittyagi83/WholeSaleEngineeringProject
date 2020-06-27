using System;

namespace WholeSaleEngineeringApi.Model
{
    public class Accounts
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

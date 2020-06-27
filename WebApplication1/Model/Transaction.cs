using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WholeSaleEngineeringApi.Model
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime ValueDate { get; set; }
        public string CurrencyType { get; set; }
        public double DebitAmount { get; set; }
        public double CreditAmount { get; set; }
        public string TransactionType { get; set; }        
        public string TransactionDescription { get; set; }
    }
}

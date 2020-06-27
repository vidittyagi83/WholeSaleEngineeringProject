using System;
using System.Collections.Generic;
using WholeSaleEngineeringApi.Model;

namespace WholeSaleEngineeringUnitTests.TestData
{
    public static class WholeSaleEngineeringTestData
    {
        public static readonly IList<Accounts> TestAccountData;
        public static readonly IList<Transactions> TestTransactionData;

        static WholeSaleEngineeringTestData()
        {
            TestAccountData = new List<Accounts>()
            {
                new Accounts() { AccountId =1,AccountNumber = "123456",AccountName = "Test",AccountType = "D",BalanceDate = DateTime.Now,CurrencyType = "Test",OpeningBalance = 1.0235}
            };

            TestTransactionData = new List<Transactions>()
            {
                new Transactions(){ TransactionId = 1,AccountNumber = "123456",AccountName ="Test",ValueDate = DateTime.Now,DebitAmount = 1.23,CreditAmount =123,TransactionType = "Debit",TransactionDescription ="abc",CurrencyType = "AUD"},
                new Transactions(){ TransactionId = 2,AccountNumber = "123456",AccountName ="Test",ValueDate = DateTime.Now,DebitAmount = 1.23,CreditAmount =123,TransactionType = "Debit",TransactionDescription ="xyz",CurrencyType = "AUD"},
                new Transactions(){ TransactionId = 3,AccountNumber = "456987",AccountName ="Test",ValueDate = DateTime.Now,DebitAmount = 2.36,CreditAmount =236,TransactionType = "Credit",TransactionDescription ="stu",CurrencyType = "AUD"}
            };
        }
    }
}

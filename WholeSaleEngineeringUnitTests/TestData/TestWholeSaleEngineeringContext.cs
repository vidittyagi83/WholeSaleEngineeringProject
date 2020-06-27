using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WholeSaleEngineeringApi.Model;
using WholeSaleEngineeringUnitTests.TestHelper;

namespace WholeSaleEngineeringUnitTests.TestData
{
   public class TestWholeSaleEngineeringContext
    {
        public WholeSaleEngineeringContext WholeSaleEngineeringContext { get; private set; }
       
        public TestWholeSaleEngineeringContext()
            {
                WholeSaleEngineeringContext = new WholeSaleEngineeringContext(DBContextUtils.GetDbContextOptions<WholeSaleEngineeringContext>());
                WholeSaleEngineeringContext.Database.OpenConnection();
                WholeSaleEngineeringContext.Database.EnsureCreated();
            }
        public void SetUpAccountData()
        {
            IList<Accounts> accounts = WholeSaleEngineeringTestData.TestAccountData.ToList();
            foreach (Accounts account in accounts)
            {
                WholeSaleEngineeringContext.Accounts.Add(new Accounts()
                {
                    AccountId = account.AccountId,
                    AccountNumber = account.AccountNumber,
                    AccountName = account.AccountName,
                    AccountType = account.AccountType,
                    BalanceDate = account.BalanceDate,
                    CurrencyType = account.CurrencyType,
                    OpeningBalance = account.OpeningBalance
                });
            }
            WholeSaleEngineeringContext.SaveChanges();
        }
        public void SetUpTrasactionData()
        {
            IList<Transactions> transactions = WholeSaleEngineeringTestData.TestTransactionData.ToList();
            foreach (Transactions transaction in transactions)
            {
                WholeSaleEngineeringContext.Transactions.Add(new Transactions()
                {
                    TransactionId = transaction.TransactionId,
                    AccountNumber = transaction.AccountNumber,
                    AccountName = transaction.AccountName,
                    ValueDate = transaction.ValueDate,
                    CurrencyType = transaction.CurrencyType,
                    DebitAmount = transaction.DebitAmount,
                    CreditAmount = transaction.CreditAmount,
                    TransactionDescription = transaction.TransactionDescription,
                    TransactionType = transaction.TransactionType
                });
            }
            WholeSaleEngineeringContext.SaveChanges();
        }
        //******************************************************************************
        /// <summary>
        /// Return a deep clone of a list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        //public  List<T> DeepClone<T>(this List<T> items)
        //{
        //    var query = from T item in items select item.DeepClone();
        //    return new List<T>(query);
        //}
    }
}

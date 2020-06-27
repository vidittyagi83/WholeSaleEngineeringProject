using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WholeSaleEngineeringApi.Model;
using WholeSaleEngineeringApi.Response;

namespace WholeSaleEngineeringApi.Service
{
    public class WholeSaleEngineeringService : IWholeSaleEngineeringService
    {
        #region Private Members
        
        private readonly WholeSaleEngineeringContext WholeSaleEngineeringContext;

        #endregion
        #region Contructors
        //******************************************************************************
        public WholeSaleEngineeringService(WholeSaleEngineeringContext wholeSaleEngineeringContext)
        {
            WholeSaleEngineeringContext = wholeSaleEngineeringContext;
        }
        #endregion
        public List<Accounts> GetAccountDetails()
        {
            List<Accounts> accountResponses = WholeSaleEngineeringContext.Accounts.ToList();
            return accountResponses;
        }
        public List<Transactions> GetTransactionsDetails(string accountNumber)
        {
            List<Transactions> transactionsDetails = WholeSaleEngineeringContext.Transactions.Where(x => x.AccountNumber.Equals(accountNumber)).ToList();
            return transactionsDetails;
        }
    }
}

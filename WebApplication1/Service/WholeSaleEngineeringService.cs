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
        /// <summary>
        /// this function will fetch account details from DB
        /// </summary>
        /// <returns>List<Accounts></returns>
        public List<Accounts> GetAccountDetails()
        {
            try
            {
                List<Accounts> accountResponses = WholeSaleEngineeringContext.Accounts.ToList();
                return accountResponses;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// this function will fetch transaction detail for given account number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public List<Transactions> GetTransactionsDetails(string accountNumber)
        {
            try
            {
                List<Transactions> transactionsDetails = WholeSaleEngineeringContext.Transactions.Where(x => x.AccountNumber.Equals(accountNumber)).ToList();
                return transactionsDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

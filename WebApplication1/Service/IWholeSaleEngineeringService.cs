using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WholeSaleEngineeringApi.Model;
using WholeSaleEngineeringApi.Response;

namespace WholeSaleEngineeringApi.Service
{
   public interface IWholeSaleEngineeringService
    {
       List<Accounts> GetAccountDetails();
        List<Transactions> GetTransactionsDetails(string accountNumber);
    }
}

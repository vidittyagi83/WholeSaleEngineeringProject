using System;
using Microsoft.AspNetCore.Mvc;
using WholeSaleEngineeringApi.Service;

namespace WholeSaleEngineeringApi.Controllers
{
    //******************************************************************************
    /// <summary>
    /// Api's to do Account operations
    /// </summary>
    //******************************************************************************
   
    public class WholeSaleEngineeringController : ControllerBase
    {
        private readonly IWholeSaleEngineeringService WholeSaleEngineeringService;

        //******************************************************************************
        public WholeSaleEngineeringController(IWholeSaleEngineeringService wholeSaleEngineeringService)
        {
            WholeSaleEngineeringService = wholeSaleEngineeringService;
        }

        /// <summary>
        /// This api will give Account list enquiries
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/AccountDetails")]
        public IActionResult AccountDetails()
        {
            return Ok(WholeSaleEngineeringService.GetAccountDetails());
        }
        /// <summary>
        /// This get call will get all the Account Transaction Enquiry for given account number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Transactions/{accountNumber}")]
        public IActionResult GetTransactionsDetails(string accountNumber)
        {
            return Ok(WholeSaleEngineeringService.GetTransactionsDetails(accountNumber));
        }
    }
}
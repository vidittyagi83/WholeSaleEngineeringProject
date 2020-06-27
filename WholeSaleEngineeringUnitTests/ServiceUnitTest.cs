using System;
using System.Collections.Generic;
using WholeSaleEngineeringApi.Model;
using WholeSaleEngineeringUnitTests.TestHelper;
using Xunit;

namespace WholeSaleEngineeringUnitTests
{
    //******************************************************************************
    //******************************************************************************
    [Trait("Category", "ServicesWholeSaleEngineering")]
    public class ServiceUnitTest
    {
        #region TEST  GetAccountDetails()
        [Fact]
        public void GetAccountDetails_ReturnData_OK()
        {
            WholeSaleEngineeringServiceTestWrapper wrapper = new WholeSaleEngineeringServiceTestWrapper();
            wrapper.TestWholeSaleEngineeringContext.SetUpAccountData();
            List<Accounts> accountResponses = wrapper.WholeSaleEngineeringService.GetAccountDetails();
            Assert.True(accountResponses.Count > 0);
        }
        [Fact]
        public void GetAccountDetails_ReturnNoData_OK()
        {
            WholeSaleEngineeringServiceTestWrapper wrapper = new WholeSaleEngineeringServiceTestWrapper();           
            List<Accounts> accountResponses = wrapper.WholeSaleEngineeringService.GetAccountDetails();
            Assert.Empty(accountResponses);
        }
        #endregion

        #region TEST  GetAccountDetails(string accountNumber)
        [Fact]
        public void GetTransactionsDetails_ReturnData_OK()
        {
            string accountNumber = "123456";
            WholeSaleEngineeringServiceTestWrapper wrapper = new WholeSaleEngineeringServiceTestWrapper();
            wrapper.TestWholeSaleEngineeringContext.SetUpTrasactionData();
            List<Transactions> transactionRsp = wrapper.WholeSaleEngineeringService.GetTransactionsDetails(accountNumber);
            Assert.True(transactionRsp.Count > 0);
        }
        [Fact]
        public void GetTransactionsDetails_ReturnNoData_OK()
        {
            string accountNumber = "12345612";
            WholeSaleEngineeringServiceTestWrapper wrapper = new WholeSaleEngineeringServiceTestWrapper();            
            List<Transactions> transactionRsp = wrapper.WholeSaleEngineeringService.GetTransactionsDetails(accountNumber);
            Assert.Empty(transactionRsp);
        }
        #endregion
    }
}

using Microsoft.AspNetCore.Http;
using Moq;
using WholeSaleEngineeringApi.Model;
using WholeSaleEngineeringApi.Service;
using WholeSaleEngineeringUnitTests.TestData;

namespace WholeSaleEngineeringUnitTests.TestHelper
{
   public class WholeSaleEngineeringServiceTestWrapper
    {
        public Mock<IHttpContextAccessor> MockHttpContextAccessor { get; set; }
        public IHttpContextAccessor HttpContextAccessor => MockHttpContextAccessor?.Object;

        public TestWholeSaleEngineeringContext TestWholeSaleEngineeringContext { get; set; }
        public WholeSaleEngineeringContext WholeSaleEngineeringContext => TestWholeSaleEngineeringContext?.WholeSaleEngineeringContext;
        public IWholeSaleEngineeringService WholeSaleEngineeringService { get; set; }

        public WholeSaleEngineeringServiceTestWrapper()
        {           
            MockHttpContextAccessor = new Mock<IHttpContextAccessor>();           
            TestWholeSaleEngineeringContext = new TestWholeSaleEngineeringContext();
            WholeSaleEngineeringService = new WholeSaleEngineeringService(WholeSaleEngineeringContext);
        }

    }
}

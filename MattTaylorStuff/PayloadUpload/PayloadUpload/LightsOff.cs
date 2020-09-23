using NUnit.Framework;
using OpenQA.Selenium;
using PayloadImport;

namespace PayloadUpload
{
    [TestFixture]
    public class LightsOff
    {
        private CXResponse _response;
        private IWebDriver _driver;

        [Test, Category(helpers.TestLevel.BASEPASS)]
        public void LightsOffTest()
        {
            var payload = new CXPayload(helpers.Payloads.MiniLoan);
            var apikey = TestContext.Parameters["apikey"];
            var secret = TestContext.Parameters["secret"];
            payload.InjectApiKey(apikey, secret);
            _response = payload.Import(helpers.Engines.QA);

        }
    }
}

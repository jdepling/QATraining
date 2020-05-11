using OpenQA.Selenium.IE;
using System;

namespace Practice1.Helpers
{

    public class TestsFixture : IDisposable
    {
        public InternetExplorerDriver Driver { get; }

        // This will run only once, but will setup our tests
        public TestsFixture()
        {
            // Initalize Internet Explorer
            InternetExplorerOptions option = new InternetExplorerOptions();
            Driver = new InternetExplorerDriver(option);
            Driver.Navigate().GoToUrl("https://careers.firstam.com/benefits/"); // Navigate to a url
        }

        // This will run only once, after all the tests have ran
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}

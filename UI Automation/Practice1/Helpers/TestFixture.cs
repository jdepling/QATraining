using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Practice1.Helpers
{

    public class TestsFixture : IDisposable
    {
        public IWebDriver Driver { get; }

        public enum Browser
        {
            FireFox,
            Chrome,
        }

        // This will run only once, but will setup our tests
        public TestsFixture()
        {
            var browser = Browser.Chrome;

            switch (browser)
            {
                case Browser.Chrome:
                    {
                        // Initalize Chrome
                        ChromeOptions chromeOptions = new ChromeOptions();
                        Driver = new ChromeDriver(chromeOptions);
                        break;
                    }
                case Browser.FireFox:
                    {
                        // Initalize Firefox
                        FirefoxOptions option = new FirefoxOptions();
                        Driver = new FirefoxDriver(option);
                        break;
                    }
            }
           
            Driver.Navigate().GoToUrl("https://careers.firstam.com/benefits/"); // Navigate to a url
        }

        // This will run only once, after all the tests have ran
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}

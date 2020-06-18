using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace UITestPractice2
{
    public class ConformXSandBoxTest
    {
        public IWebDriver Driver { get; }

        public ConformXSandBoxTest()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            Driver = new ChromeDriver(chromeOptions);
        }

        [Fact]
        public void TestConformX()
        {
            Driver.Navigate().GoToUrl("https://qa.conformx.com/Login.aspx");

            //find the element for the username and password by its ID
            IWebElement username = Driver.FindElement(By.Id("txtUsername"));
            IWebElement password = Driver.FindElement(By.Id("txtPassword"));

            //enter the username and password in appropriate boxes
            username.SendKeys("SOMEUSERNAME");
            password.SendKeys("SOMEPASSWORD");

            Driver.FindElement(By.XPath("//*[@id=\"divUserName\"]/a")).Click();
            Driver.FindElement(By.Id("ctl00_Header_lnkAdmin")).Click();
            Driver.FindElement(By.LinkText("System Default Settings")).Click();//call me back, i hung up!!!

            Console.WriteLine("test");
            Driver.FindElement(By.Id("systemDefaults_defaults_btnShowHelp3")).Click();
            Driver.FindElement(By.Id("btnClose")).Click();

            // Close the browser and release the driver so we won't have chromeDriver.exe in our task manager
            Driver.Close();
            Driver.Dispose();
        }
    }
}

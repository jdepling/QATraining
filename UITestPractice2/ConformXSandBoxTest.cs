using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            Driver.Manage().Window.Maximize();

            Setup();
        }

        public void Setup()
        {
            Driver.Navigate().GoToUrl("https://qa.conformx.com/Login.aspx");

            //find the element for the username and password by its ID
            IWebElement username = Driver.FindElement(By.Id("txtUsername"));
            IWebElement password = Driver.FindElement(By.Id("txtPassword"));

            //enter the username and password in appropriate boxes
            username.SendKeys("SOMEUSERNAME");
            password.SendKeys("SOMEPASSWORD");

            Driver.FindElement(By.XPath("//*[@id=\"divUserName\"]/a")).Click();
        }

        public void TearDown()
        {
            // Close the browser and release the driver so we won't have chromeDriver.exe in our task manager
            Driver.Close();
            Driver.Dispose();
        }

        public void SelectDropDownOption(string id, string option)
        {
            var dropdown = Driver.FindElement(By.Id(id));
            new SelectElement(dropdown).SelectByText(option);
        }


        [Fact]
        public void TestConformX()
        {
            try
            {
                Driver.FindElement(By.Id("ctl00_Header_lnkAdmin")).Click();
                Driver.FindElement(By.LinkText("System Default Settings")).Click();

                Driver.FindElement(By.Id("systemDefaults_defaults_btnShowHelp3")).Click();
                Driver.FindElement(By.Id("btnClose")).Click();
            }
            finally
            {
                TearDown();
            }
        }

        [Fact]
        public void TestFieldLibrary() 
        {
            try
            {
                Driver.Navigate().GoToUrl("https://qa.conformx.com/admin/WebAdminFieldLibrary.aspx");
                SelectDropDownOption("ctl00_cphBodyContent_ddCriteria", "Field Name");
                SelectDropDownOption("ctl00_cphBodyContent_ddSearchType", "Equals");
                Driver.FindElement(By.Id("ctl00_cphBodyContent_tbExpression")).SendKeys("Borrower 4 Credit Report Date Plus 90 Days");


                Driver.FindElement(By.Id("ctl00_cphBodyContent_btnAddCondition")).Click();
                Driver.FindElement(By.Id("ctl00_cphBodyContent_btnApply")).Click();

                string index = Driver.FindElement(By.XPath("//*[@id=\"ctl00_cphBodyContent_datagrid\"]/tbody/tr[2]/td[1]/a")).Text;
                Assert.Equal("141092", index);

                var table = Driver.FindElement(By.XPath("//*[@id=\"ctl00_cphBodyContent_datagrid\"]/tbody/tr[2]/td[1]/a"));
                Assert.True(table.Displayed);

            }
            finally
            {
                TearDown();
            }
        
        
        }
    }
}

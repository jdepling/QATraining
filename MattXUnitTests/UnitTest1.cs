using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using Xunit;

namespace MattXUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //bringing in the driver from chrome does the actions (click, tabs etc.)
            IWebDriver driver = new ChromeDriver();

            //navigate to page
            driver.Navigate().GoToUrl("https://roll20.net/");

            //find and click sign in button
            driver.FindElement(By.Id("menu-signin")).Click();

            //find the element for the email address
            IWebElement email = driver.FindElement(By.Id("input_login-email"));

            //find the element for the password
            IWebElement password = driver.FindElement(By.Id("input_login-password"));

            //enter the email address and password for the site
            email.SendKeys("mtaylor@docutech.com");
            password.SendKeys("LotusElise57");

            //push sign in button
            driver.FindElement(By.XPath("//*[@id=\"navbar-legacy\"]/ul[2]/li[2]/div/form/button")).Click();

            //Choose Valperous game
            IWebElement gamelink = driver.FindElement(By.CssSelector("a[href*='5174815']"));
            gamelink.Click();

            //Launch Valperous game
           // IWebElement launch = driver.FindElement(By.LinkText("Launch Game"));
           // launch.Click();






        }
    }
}

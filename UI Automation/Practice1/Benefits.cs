using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using Practice1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Practice1
{
    public class Benefits: IClassFixture<TestsFixture>
    {
        IWebDriver Driver { get; }
        public Benefits(TestsFixture data)
        {
            Driver = data.Driver;
        }

        [Fact]
        public void DoWeHaveTheBenefits()
        {
            // Navigate to a url
            Driver.Navigate().GoToUrl("https://careers.firstam.com/benefits/");

            // Find some elements on the page
            IEnumerable<IWebElement> h2headings = Driver.FindElements(By.TagName("h2"));
            List<string> h2Text = h2headings.Select(h => h.Text).ToList();
            IEnumerable<string> expectedBenefits = new List<string>{ 
                "Pet Insurance", 
                "Bonding Leave", 
                "Adoption Assistance", 
                "Employee Stock Purchase Program", 
                "Settlement Services Reimbursement", 
                "FA Recognition",
                "Wellness Programs" 
            };

            // Assert
            expectedBenefits.ToList().ForEach(expected =>
            {
                bool weGotIt = h2Text.Contains(expected);
                Assert.True(weGotIt, string.Format("Benefit was not found: {0}", expected));
            });
        }
    }
}

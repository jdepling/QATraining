using OpenQA.Selenium;
using Practice1.Helpers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Practice1
{
    /// <summary>
    /// Instructions:
    /// 1. In order to use selenium you need Selenium.WebDriver and a driver for your browser. 
    /// This project has both of them. They were obtained via nuget package manager. 
    /// I recommend that way as opposed to downloading it yourself. 
    /// This project only has IEWedriver in it. If you want Chrome you will need to install it yourself :)
    /// 2. You can go to nuget package manager here, select "installed" and you will see what I have already installed.
    /// 3. Make sure to put "OpenQA.Selenium" in your usings
    /// 4. If using IE, I find that adding the site that you want to test to "trusted sites" works better: https://seleniumie.blogspot.com/2015/01/no-such-window-exception-or-unable-to.html
    /// 5. Explanation of how to do a setup and teardown in xunit: https://stackoverflow.com/questions/12976319/xunit-net-global-setup-teardown
    /// </summary>
    public class Benefits: IClassFixture<TestsFixture>
    {
        IWebDriver Driver { get; }

        public Benefits(TestsFixture data)
        {
            Driver = data.Driver;
        }

        /// <summary>
        /// With this test we will learn how to extract text from elements on the page
        /// </summary>
        [Fact]
        public void DoWeHaveTheBenefits()
        {
            // Arrange
            IEnumerable<string> expectedBenefits = new List<string>{ // Our expected benefits 
                "Pet Insurance",
                //"Bonding Leave", // Note: this one is not on the page, therefore it will fail
                "Adoption Assistance",
                "Employee Stock Purchase Program",
                "Settlement Services Reimbursement",
                "FA Recognition",
                "Wellness Programs"
            };

            // Act
            IEnumerable<IWebElement> h2headings = Driver.FindElements(By.TagName("h2"));  // Find all the h2s
            List<string> h2Text = h2headings.Select(h => h.Text).ToList();               // extract all the text from the h2s
            
            // Assert
            expectedBenefits.ToList().ForEach(expected =>
            {
                bool weGotIt = h2Text.Contains(expected);
                Assert.True(weGotIt, string.Format("Benefit was not found: {0}", expected));
            });
        }

        /// <summary>
        /// Here we learn how to click on an element.
        /// Please note that under normal circumstances we could have done this a lot easier if we had:
        /// 1. An id
        /// 2. LinkText that wasn't nested in another element
        /// </summary>
        [Fact]
        public void Test()
        {
            // Arrange
            string expected = "Diversity";

            // Act
            Driver.FindElements(By.ClassName("avia-menu-text")).Where(element => element.Text == "Diversity").FirstOrDefault().Click(); // Select the Diversity tab
            string actual = Driver.FindElement(By.TagName("h1")).Text; // Get the text of the h1 header on the Diversity page

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

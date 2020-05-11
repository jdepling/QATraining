using OpenQA.Selenium.IE;
using System;

namespace Practice1.Helpers
{

    public class TestsFixture : IDisposable
    {
        public InternetExplorerDriver Driver { get; }
        public TestsFixture()
        {
            // Initalize Internet Explorer
            InternetExplorerOptions option = new InternetExplorerOptions();
            Driver = new InternetExplorerDriver(option);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}

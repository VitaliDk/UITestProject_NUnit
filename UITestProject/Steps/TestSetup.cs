using System;
using BoDi;
using TechTalk.SpecFlow;
using ComponentLibrary.Factories;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UITestProject.Steps
{
    [Binding]
    public class TestSetup
    {

        private readonly IObjectContainer _objectContainer;

        public TestSetup(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitialiseTest()
        {
            WebDriverFactory factory = new WebDriverFactory();
            IWebDriver driver = factory.Create(BrowserType.Chrome);
            driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void TearDown(IWebDriver driver)
        {
            var result = TestContext.CurrentContext.Result.Outcome.ToString();
            var testName = TestContext.CurrentContext.Test.Name;
            if (result == "Passed")
            {
                Console.WriteLine("Test " + testName + "passed");
            } else if (result == "Failed")
            {
                Console.WriteLine("it failed");
            }
            // driver.Close();
            // driver.Quit();
        }

    }
}

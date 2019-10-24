using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NLog;
using ComponentLibrary.HelperFunctions;

namespace UITestProject.Steps
{
    [Binding]
    public class OrderDetailsPageSteps
    {
        private readonly IWebDriver driver;

        private static readonly Logger _Logger = LogManager.GetCurrentClassLogger();

        public OrderDetailsPageSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"the user is taken to the order details page")]
        public void ThenTheUserIsTakenToTheOrderDetailsPage()
        {
            Find.Element(driver, By.Id("orderDetails"));
        }

    }
}

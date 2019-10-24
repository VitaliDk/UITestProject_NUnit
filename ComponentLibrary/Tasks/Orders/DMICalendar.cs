using System;
using OpenQA.Selenium;
using ComponentLibrary.HelperFunctions;
using ComponentLibrary.Screens;

namespace ComponentLibrary.Actions
{
    public class DMICalendar
    {
        public static void NavigateToNextMonth(IWebDriver driver)
        {
            Find.Element(driver, DMICalendarScreen.ToggleRight).Click();
        }

        public static void NavigateToPreviousMonth(IWebDriver driver)
        {
            Find.Element(driver, DMICalendarScreen.ToggleLeft).Click();
        }
    }
}

﻿using System;
using OpenQA.Selenium;
using ComponentLibrary.HelperFunctions;
using ComponentLibrary.Actions;

namespace ComponentLibrary.Tasks.Orders
{
    public class VerifyOrderExists
    {
        public static void DoesAnOrderExistOnThePage(IWebDriver driver)
        {
            Console.WriteLine("ATTEMPTING TO FIND ORDERS ON THE PAGE");
            Find.Element(driver, By.ClassName("order-link"));
            Console.WriteLine("ORDER FOUND");
        }

        public static void DmiOrderIdEquals(IWebDriver driver, string dmiorderid)
        {
            Find.Element(driver, By.XPath($"//a[contains(text(),'{dmiorderid}')]"));
        }

        public static void OpenOrderDetailsPage(IWebDriver driver, string dmiOrderId)
        {
            Click.Element(driver, By.XPath($"//a[contains(text(),'{dmiOrderId}')]"));
        }

        public static Boolean FindOrder(IWebDriver driver, string order)
        {
            return Find.ElementIfExists(driver, By.XPath($"//a[contains(text(),'{order}')]"));
        }
    }
}

using DocspiderWebAutomation.SetupProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DocspiderWebAutomation.Utils.Wait
{
    public class CustomWait : Setup
    {
        public static IWebElement WaitForElement(By elementId)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement elementToBeClickable = null;
            var element = wait.Until(condition =>
            {
                try
                {
                    elementToBeClickable = driver.FindElement(elementId);
                    return elementToBeClickable.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            return elementToBeClickable;
        }

        public static IWebElement WaitUntilElementClickable(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}

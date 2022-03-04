using DocspiderWebAutomation.SetupProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Utils.Wait
{
    public class CustomWait : Setup
    {
        public static IWebElement WaitForElement(string elementId)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            IWebElement elementToBeClickable = null;
            var element = wait.Until(condition =>
            {
                try
                {
                    elementToBeClickable = driver.FindElement(By.Id(elementId));
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
    }
}

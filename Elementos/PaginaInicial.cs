using DocspiderWebAutomation.Utils.Wait;
using OpenQA.Selenium;

namespace DocspiderWebAutomation.Elementos
{
    public class PaginaInicial : CustomWait
    {
        public static IWebElement BtnAcessarPortalDocumentos()
        {
            ////*[@id="portal"]/header/nav/div[2]/div[1]/form/div/button
            return driver.FindElement(By.XPath("//*[@id='portal']/header/nav/div[2]/div[1]/form/div/button"));
        }
    }
}

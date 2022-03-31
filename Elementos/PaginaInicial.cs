using DocspiderWebAutomation.Utils.Wait;
using OpenQA.Selenium;

namespace DocspiderWebAutomation.Elementos
{
    public class PaginaInicial : CustomWait
    {
        public static IWebElement BtnAcessarPortalDocumentos()
        {            
            return driver.FindElement(By.XPath("//*[@id='holderPortal/PortalDocumentos/']/span"));
        }

        public static IWebElement ImgLogoDocspider()
        {
            return driver.FindElement(By.Id("imgLogo"));
        }
    }
}

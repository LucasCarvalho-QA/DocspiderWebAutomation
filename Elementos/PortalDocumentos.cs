using DocspiderWebAutomation.Utils.Wait;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocspiderWebAutomation.Elementos
{
    internal class PortalDocumentos : CustomWait
    {
        public static IWebElement TxtDigiteConteudoBusca()
        {
            return driver.FindElement(By.Id("txtBuscaHeader"));
        }

        public static IWebElement BtnBuscar()
        {
            return driver.FindElement(By.XPath("//*[@id='portal']/header/nav/div[2]/div[1]/form/div/button"));
        }

        public static List<IWebElement> CardResultados()
        {
            try
            {
                return driver.FindElements(By.Id("documents")).ToList();
            }
            catch (Exception)
            {
                return null;
            }            
        }

        
    }

}

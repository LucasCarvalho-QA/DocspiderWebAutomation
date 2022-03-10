using DocspiderWebAutomation.SetupProject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Elementos
{
    public class ElementosComuns : Setup
    {
        public static IWebElement AguardarResultadosDaPesquisa()
        {
            return driver.FindElement(By.Id("ComTodasAsPalavras"));
        }
    }
}

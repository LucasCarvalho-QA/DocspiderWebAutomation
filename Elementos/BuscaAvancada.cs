using DocspiderWebAutomation.Utils.Wait;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Elementos
{
    public class BuscaAvancada : CustomWait
    {

        public static IWebElement RbtnBuscadoPorPalavra()
        {
            return driver.FindElement(By.Id("modoPorPalavra"));
        }

        public static IWebElement RbtnBuscadoPorExpressoes()
        {
            return driver.FindElement(By.Id("modoPorExpressao"));
        }

        public static IWebElement TxtTermoDaBusca()
        {
            return driver.FindElement(By.Id("termoBuscaFiltro"));
        }
        
        public static IWebElement BtnPesquisarTermo()
        {
            return driver.FindElement(By.Id("btnSubmitTermo"));
        }

        public static IWebElement RbtnComTodasAsPalavras()
        {     
            return WaitForElement(By.Id("ComTodasAsPalavras"));
        }

        public static IWebElement RbtnComQualquerUmaDasPalavras()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.document.getElementById('ComQualquerUmaDasPalavras').click()");

            return null;
        }

        public static IWebElement TxtSemAsPalavras()
        {
            return driver.FindElement(By.Id("semAsPalavras"));
        }
        
        public static IWebElement BtnPesquisarFiltro()
        {
            return driver.FindElement(By.Id("btnFilterSubmit"));
        }

        public static IWebElement TxtDataEfetivacaoInicio()
        {
            return driver.FindElement(By.XPath("//*[@id='dataEfetivacao']/span[1]/span/input"));
        }

        public static IWebElement TxtDataEfetivacaoFim()
        {
            return driver.FindElement(By.XPath("//*[@id='dataEfetivacao']/span[3]/span/input"));
        }

        public static IWebElement BtnPesquisarDataEfetivacao()
        {
            return driver.FindElement(By.XPath("//*[@id='efetivacao']/button"));
        }

    }
}

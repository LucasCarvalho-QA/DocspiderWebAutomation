using DocspiderWebAutomation.Utils.Wait;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Elementos
{
    public class Login : CustomWait
    {
        public static IWebElement TxtUsuarioLogin()
        {
            return driver.FindElement(By.Id("username"));
        }

        public static IWebElement TxtUsuarioSenha()
        {
            return driver.FindElement(By.Id("password"));
        }

        public static IWebElement BtnAcessar()
        {
            return driver.FindElement(By.Id("loginButton"));
        }//holderPortal/PortalDocumentos/
    }    
        
}

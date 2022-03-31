using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Page
{
    public static class LoginPage
    {
        public static void RealizarLoginComSucesso()
        {
            Elementos.Login.TxtUsuarioLogin().SendKeys("camila");
            Elementos.Login.TxtUsuarioSenha().SendKeys("123456");
            Elementos.Login.BtnAcessar().Click();
        }

        public static void RealizarLogin(string usuario, string senha)
        {
            Elementos.Login.TxtUsuarioLogin().SendKeys(usuario);
            Elementos.Login.TxtUsuarioSenha().SendKeys(senha);
            Elementos.Login.BtnAcessar().Click();
        }

        internal static bool ValidarLoginSemSucesso()
        {
            if (Elementos.Login.BtnAcessar() == null)
                return true;
            else
                return true;
        }

        internal static bool ValidarLoginComSucesso()
        {
            throw new NotImplementedException();
        }

        internal static string RetornarMensagemDeLoginInvalido()
        {
            throw new NotImplementedException();
        }

        internal static bool ValidarLogin()
        {
            if (Elementos.Login.BtnAcessar() == null)
                return false;  
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Page
{
    public static class LoginPage
    {
        public static void RealizarLoginComSucesso()
        {
            Elementos.Login.TxtUsuarioLogin().SendKeys("docspider");
            Elementos.Login.TxtUsuarioSenha().SendKeys("docspider");
            Elementos.Login.BtnAcessar().Click();
        }
    }
}

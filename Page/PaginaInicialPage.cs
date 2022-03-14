using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Page
{
    public static class PaginaInicialPage
    {
        public static void AcessarPortalDocumentos()
        {
            Elementos.PaginaInicial.BtnAcessarPortalDocumentos().Click();
        }

        public static bool VerificarPresencaNaPagina()
        {
            var elementosEsperados = Elementos.PaginaInicial.BtnAcessarPortalDocumentos();

            if (elementosEsperados == null)
                return false;
            else
                return true;
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Page
{
    public class PortalDocumentosPage
    {
        public static void RealizarBuscaPorTermo(string termo)
        {
            Elementos.PortalDocumentos.TxtDigiteConteudoBusca().SendKeys(termo);
            Elementos.PortalDocumentos.BtnBuscar().Click();
        }

        public static bool ValidarExistenciaDeResultado()
        {
            IWebElement elementoEsperado = Elementos.PortalDocumentos.CardResultados();

            if (elementoEsperado == null)
                return false;
            return true;
        }
    }
}

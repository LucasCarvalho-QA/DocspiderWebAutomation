using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocspiderWebAutomation.Page
{
    public class PortalDocumentosPage
    {
        public static void RealizarBuscaPorTermo(string termo)
        {
            Elementos.PortalDocumentos.TxtDigiteConteudoBusca().SendKeys(termo);            
        }
        public static void PressionarBotaoBuscar()
        {
            Elementos.PortalDocumentos.BtnBuscar().Click();
        }

        public static bool ValidarExistenciaDeTermoNoResultado(string termoBusca = null)
        {
            var elementosEsperados = Elementos.PortalDocumentos.CardResultados();

            if (elementosEsperados[0].Text.Equals("Nenhum documento encontrado"))
                return false;
            if (termoBusca == null)
                return true;

            bool resultado = false;

            foreach (var card in elementosEsperados)                
                if (card.Text.Contains(termoBusca))
                    resultado = true;  
            
            return resultado;
        }

        public static bool ValidarExistenciaDeResultado()
        {
            var elementosEsperados = Elementos.PortalDocumentos.CardResultados();

            if (elementosEsperados[0].Text.Equals("Nenhum documento encontrado"))
                return false;
            else
                return true;
        }

        
    }
}

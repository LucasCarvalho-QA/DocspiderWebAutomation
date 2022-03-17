using NUnit.Framework;
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

        public static void ValidarExistenciaDeResultado()
        {
            var elementosEsperados = Elementos.PortalDocumentos.CardResultados();
            bool resultado;

            if (elementosEsperados[0].Text.Equals("Nenhum documento encontrado"))
                resultado = false;
            else
                resultado = true;

            Assert.IsTrue(resultado);
        }

        public static void ValidarNaoExistenciaDeResultado()
        {
            var elementosEsperados = Elementos.PortalDocumentos.CardResultados();
            bool resultado;

            if (elementosEsperados[0].Text.Equals("Nenhum documento encontrado"))
                resultado = true;
            else
                resultado = false;

            Assert.IsTrue(resultado);
        }
    }
}

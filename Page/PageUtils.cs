using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DocspiderWebAutomation.Page
{
    public static class PageUtils
    {
        public static int RetornarSomatoriaDeDocumentosDoMenuLateral(List<IWebElement> elementoDoMenuLateral)
        {
            int valorTotal = 0;
            foreach (var item in elementoDoMenuLateral)
                valorTotal += int.Parse(Regex.Match(item.Text, @"\d+").Value);

            return valorTotal;
        }

        public static int RetornarQuantidadeDeResultados()
        {
            return int.Parse(Elementos.BuscaAvancada.QuantidadeDeResultadosNaBusca().GetAttribute("value"));
        }
    }
}

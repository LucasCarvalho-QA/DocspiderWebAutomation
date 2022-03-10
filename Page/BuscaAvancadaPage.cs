using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Page
{
    public static class BuscaAvancadaPage
    {
        public static void AcessarBuscaAvancada()
        {
            PortalDocumentosPage.PressionarBotaoBuscar();            
        }
        public static void SelecionarFiltro_PesquisarPorPalavras()
        {
            Elementos.BuscaAvancada.RbtnBuscadoPorPalavra().Click();
        }
        public static void SelecionarFiltro_PesquisarPorExpressoes()
        {
            Elementos.BuscaAvancada.RbtnBuscadoPorExpressoes().Click();
        }

        public static void PreencherTermoDeBusca(string termo)
        {
            Elementos.BuscaAvancada.TxtTermoDaBusca().SendKeys(termo);
        }

        public static void PressionarBotao_PesquisarTermos()
        {
            Elementos.BuscaAvancada.BtnPesquisarTermo().Click();
        }

        public static void SelecionarFiltro_FiltrarTodasAsPalavras()
        {
            Elementos.BuscaAvancada.RbtnComTodasAsPalavras().Click();
        }

        public static void SelecionarFiltro_FiltrarQualquerPalavra()
        {
            Elementos.BuscaAvancada.RbtnComQualquerUmaDasPalavras();
        }

        public static void PreencherFiltroDeBusca(string termo)
        {
            Elementos.BuscaAvancada.TxtSemAsPalavras().SendKeys(termo);
        }

        public static void PressionarBotao_PesquisarFiltros()
        {
            Elementos.BuscaAvancada.BtnPesquisarFiltro().Click();
        }

        public static void AguardarResultadosPesquisa()
        {
            Utils.Wait.CustomWait.WaitUntilElementClickable(By.Id("ComTodasAsPalavras"));
        }
    }
}

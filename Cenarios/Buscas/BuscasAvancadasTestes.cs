using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Cenarios.Buscas
{
    [TestFixture, Category("Buscas Avancadas")]
    internal class BuscasAvancadasTestes : Setup
    {
        [TestCase(TestName = "CT005_Realizar_busca_avançada_filtro_palavras_todas")]
        public void BuscasAvancada_FiltroPalavrasTodas()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documentos");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarTodasAsPalavras();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT006_Realizar_busca_avançada_filtro_palavras_qualquer")]
        public void BuscasAvancada_FiltroPalavrasQualquer()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de teste");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }
    }
}

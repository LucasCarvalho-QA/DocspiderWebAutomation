using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;

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

            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documentos");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarTermos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [Parallelizable]
        [TestCase(TestName = "CT006_Realizar_busca_avançada_filtro_palavras_qualquer")]
        public void BuscasAvancada_FiltroPalavrasQualquer()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de teste");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();


            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT007_Realizar_busca_avançada_filtro_palavras_todas_sem_as_palavras")]
        public void BuscasAvancada_FiltroPalavrasTodasSemAsPalavras()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documentos gerais");
            Page.BuscaAvancadaPage.PreencherFiltroDeBusca("documentos");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT008_Realizar_busca_avançada_filtro_palavras_qualquer_sem_as_palavras")]
        public void BuscasAvancada_FiltroPalavrasQualquerSemPalavras()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documentos gerais");
            Page.BuscaAvancadaPage.PreencherFiltroDeBusca("documentos");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();            
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT009_Realizar_busca_avançada_filtro_expressoes_todas")]
        public void BuscasAvancada_FiltroExpressoesTodas()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("teste de obsoletar");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorExpressoes();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT010_Realizar_busca_avançada_filtro_expressões_qualquer")]
        public void BuscasAvancada_FiltroExpressoesQualquer ()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("teste de obsoletar");
            Page.BuscaAvancadaPage.PreencherFiltroDeBusca("documentos");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorExpressoes();            
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT013_Realizar_busca_avançada_palavras_todas_ter_retorno_radicais")]
        public void BuscasAvancada_FiltroPalavrasTodasTerRetornoRadicais()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento");
            Page.BuscaAvancadaPage.PreencherFiltroDeBusca("documentos");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorExpressoes();
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }
    }
}

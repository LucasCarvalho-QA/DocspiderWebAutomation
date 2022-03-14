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
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de novidades");
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
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de novidades");
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
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.ExibirRadicaisSinonimos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.BuscaAvancadaPage.VerificarExistenciaDeRadicaisSinonimos();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT014_Realizar_busca_avançada_palavras_todas_ter_retorno_sinônimos")]
        public void BuscasAvancada_FiltroPalavrasTodasTerRetornoSinonimos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.ExibirRadicaisSinonimos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.BuscaAvancadaPage.VerificarExistenciaDeRadicaisSinonimos();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT015_Realizar_busca_avançada_palavras_qualquer_ter_retorno_radicais")]
        public void BuscasAvancada_FiltroPalavrasQualquerTerRetornoRadicais()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de novidades");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.ExibirRadicaisSinonimos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.BuscaAvancadaPage.VerificarExistenciaDeRadicaisSinonimos();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT016_Realizar_busca_avançada_palavras_qualquer_ter_retorno_sinônimos")]
        public void BuscasAvancada_FiltroPalavrasQualquerTerRetornoSinonimos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de novidades");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.ExibirRadicaisSinonimos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.BuscaAvancadaPage.VerificarExistenciaDeRadicaisSinonimos();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT017_Realizar_busca_avançada_filtro_portal_automatização")]
        public void BuscasAvancada_FiltroPortalAutomatizacao()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Teste");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarPortalAutomatizacao();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT018_Realizar_busca_avançada_filtro_portal_doc_renomeado")]
        public void BuscasAvancada_FiltroPortalDocRenomeado()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Teste");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarPortalDocRenomeado();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT019_Realizar_busca_avançada_filtro_portal_normativos_externos")]
        public void BuscasAvancada_FiltroPortalNormativoExternos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Teste");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarPortalNormativosExternos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT019_Realizar_busca_avançada_filtro_portal_normativos_internos")]
        public void BuscasAvancada_FiltroPortalNormativoInternos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarPortalNormativosInternos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT020_Realizar_busca_avançada_filtro_portal_processos")]
        public void BuscasAvancada_FiltroPortalProcessos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarPortalNormativosInternos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT021_Realizar_busca_avançada_filtro_situação_vigente")]
        public void BuscasAvancada_FiltroSituacaoVigente()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarSituacaoVigente();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT022_Realizar_busca_avançada_filtro_situação_obsoleto")]
        public void BuscasAvancada_FiltroSituacaoObsoleto()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarSituacaoObsoleto();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT023_Realizar_busca_avançada_filtro_situação_expirado")]
        public void BuscasAvancada_FiltroSituacaoExpirado()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarSituacaoExpirado();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT024_Realizar_busca_avançada_filtro_situação_vigencia_futura")]
        public void BuscasAvancada_FiltroSituacaoVigenciaFutura()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarSituacaoExpirado();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT025_Realizar_busca_avançada_filtro_tipo_de_documento")]
        public void BuscasAvancada_FiltroTipoDeDocumento()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarTipoDeDocumento_AssuntosGerais();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT026_Realizar_busca_avançada_filtro_categoria")]
        public void BuscasAvancada_FiltroCategoria()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarCategoria_Documentacao();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT028_Realizar_busca_avançada_filtro_efetivação")]
        public void BuscasAvancada_FiltroEfetivacao()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.PreencherDataDeEfetivacao("01/12/2021", "31/01/2022");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarDataEfetivacao();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT029_Realizar_busca_avançada_filtro_validade")]
        public void BuscasAvancada_FiltroValidade()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.PreencherDataDeValidade("01/12/2021", "31/01/2022");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarDataValidade();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT030_Realizar_busca_avançada_filtro_validade_indefinida")]
        public void BuscasAvancada_FiltroValidadeIndefinida()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("Documento");
            Page.BuscaAvancadaPage.PressionarBotao_PesquisarFiltros();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.PreencherCheckboxValidadeIndefinidade();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT032_Realizar_busca_avançada_todos_os_filtros")]
        public void BuscasAvancada_FiltroTodosOsFiltros()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documentos gerais");
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarPortalNormativosInternos();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarSituacaoVigente();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarTipoDeDocumento_AssuntosGerais();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();            
            Page.BuscaAvancadaPage.PreencherCheckboxValidadeIndefinidade();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT035_Visualizar_resultados_como_cards")]
        public void VisualizarResultadosComoCards()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT036_Visualizar_resultados_como_lista")]
        public void VisualizarResultadosComoLista()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarVisualizacaoDosResultadosPorLista();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT037_Visualizar_últimas_atualizações")]
        public void VisualizarMenuLateral_UltimasAtualizacoes()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_UltimasAtualizacoes();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT038_Visualizar_meus_favoritos")]
        public void VisualizarMenuLateral_MeusFavoritos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_MeusFavoritos();

            //Assert
            bool resultado = Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Assert.IsTrue(resultado);
        }        
    }
}

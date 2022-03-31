using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;

namespace DocspiderWebAutomation.Cenarios.Buscas
{
    [TestFixture, Category("Buscas Avancadas")]
    internal class BuscasAvancadasTestes : Setup
    {
        [TestCase(TestName = "CT005_Realizar_busca_avancada_filtro_palavras_todas")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT006_Realizar_busca_avancada_filtro_palavras_qualquer")]
        public void BuscasAvancada_FiltroPalavrasQualquer()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.PreencherTermoDeBusca("documento de teste");
            Page.BuscaAvancadaPage.SelecionarFiltro_PesquisarPorPalavras();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();
            Page.BuscaAvancadaPage.SelecionarFiltro_FiltrarQualquerPalavra();
            Page.BuscaAvancadaPage.AguardarResultadosPesquisa();


            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT007_Realizar_busca_avancada_filtro_palavras_todas_sem_as_palavras")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT008_Realizar_busca_avancada_filtro_palavras_qualquer_sem_as_palavras")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT009_Realizar_busca_avancada_filtro_expressoes_todas")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT010_Realizar_busca_avancada_filtro_expressoes_qualquer")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT013_Realizar_busca_avancada_palavras_todas_ter_retorno_radicais")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT014_Realizar_busca_avancada_palavras_todas_ter_retorno_sinônimos")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT015_Realizar_busca_avancada_palavras_qualquer_ter_retorno_radicais")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT016_Realizar_busca_avancada_palavras_qualquer_ter_retorno_sinônimos")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT017_Realizar_busca_avancada_filtro_portal_automatizacao")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT018_Realizar_busca_avancada_filtro_portal_doc_renomeado")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT019_Realizar_busca_avancada_filtro_portal_normativos_externos")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT020_Realizar_busca_avancada_filtro_portal_normativos_internos")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT021_Realizar_busca_avancada_filtro_portal_processos")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT022_Realizar_busca_avancada_filtro_situacao_vigente")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT023_Realizar_busca_avancada_filtro_situacao_obsoleto")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT024_Realizar_busca_avancada_filtro_situacao_expirado")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT025_Realizar_busca_avancada_filtro_situacao_vigencia_futura")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT026_Realizar_busca_avancada_filtro_tipo_de_documento")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT027_Realizar_busca_avancada_filtro_categoria")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT028_Realizar_busca_avancada_filtro_efetivacao")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT029_Realizar_busca_avancada_filtro_validade")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            
        }

        [TestCase(TestName = "CT030_Realizar_busca_avancada_filtro_validade_indefinida")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT032_Realizar_busca_avancada_todos_os_filtros")]
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT037_Visualizar_últimas_atualizacoes")]
        public void VisualizarMenuLateral_UltimasAtualizacoes()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_UltimasAtualizacoes();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
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
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT039_Visualizar_últimos_acessados")]
        public void VisualizarMenuLateral_UtimosAcessados()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_UltimasAtualizacoes();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT039_Visualizar_mais_acessados")]
        public void VisualizarMenuLateral_MaisAcessados()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_MaisAcessados();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT040_Visualizar_documentos_por_tipo")]
        public void VisualizarMenuLateral_DocumentoPorTipo()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_DocumentosPorTipo();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT041_Visualizar_documentos_por_area")]
        public void VisualizarMenuLateral_DocumentoPorArea()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_DocumentosPorArea();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT042_Visualizar_documentos_por_indexadores")]
        public void VisualizarMenuLateral_DocumentoPorIndexadores()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_DocumentosPorIndexadores();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT043_Visualizar_tutoriais")]
        public void VisualizarMenuLateral_Tutorias()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_Tutoriais();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT044_Visualizar_painel_de_atividades")]
        public void VisualizarMenuLateral_PainelDeAtividades()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_PainelDeAtividades();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT045_Visualizar_painel_gestao_de_documentos")]
        public void VisualizarMenuLateral_PainelGestaoDeDocumentos()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.BuscaAvancadaPage.AcessarBuscaAvancada();
            Page.BuscaAvancadaPage.SelecionarMenuLateral_PainelGestaoDocumentos();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }
    }
}

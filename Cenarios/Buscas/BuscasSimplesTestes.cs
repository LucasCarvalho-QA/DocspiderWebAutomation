using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;

namespace DocspiderWebAutomation.Cenarios.Buscas
{
    [TestFixture, Category("Buscas Simples")]
    public class BuscasSimplesTestes : Setup
    {
        [TestCase(TestName = "CT001_Realizar_busca_normal_em_branco")]
        public void BuscasSimples_RealizarBuscaNormalEmBranco()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.PortalDocumentosPage.RealizarBuscaPorTermo("");
            Page.PortalDocumentosPage.PressionarBotaoBuscar();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT003_Realizar_busca_normal_com_conteudo")]
        public void BuscasSimples_RealizarBuscaNormalComConteudo()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.PortalDocumentosPage.RealizarBuscaPorTermo("Amazonia");
            Page.PortalDocumentosPage.PressionarBotaoBuscar();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();

        }

        [TestCase(TestName = "CT002_Realizar_busca_normal_com_dois_termos_iguais")]
        public void BuscasSimples_RealizarBuscaNormalComDoisTermosIguais()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.PortalDocumentosPage.RealizarBuscaPorTermo("Amazonia Amazonia");
            Page.PortalDocumentosPage.PressionarBotaoBuscar();

            //Assert
            Page.PortalDocumentosPage.ValidarExistenciaDeResultado();
            Page.BuscaAvancadaPage.ValidarQuantidadeDeResultadoApresentados();
        }

        [TestCase(TestName = "CT004_Realizar_busca_normal_com_conteudo_invalido")]
        public void BuscasSimples_RealizarBuscaNormalComConteudoInvalido()
        {
            //Arrange
            Page.LoginPage.RealizarLoginComSucesso();
            Page.PaginaInicialPage.AcessarPortalDocumentos();

            //Act
            Page.PortalDocumentosPage.RealizarBuscaPorTermo("llllll");
            Page.PortalDocumentosPage.PressionarBotaoBuscar();

            //Assert
            Page.PortalDocumentosPage.ValidarNaoExistenciaDeResultado();
        }
    }
}

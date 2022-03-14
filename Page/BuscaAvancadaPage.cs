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

        public static bool VerificarExistenciaDeRadicaisSinonimos()
        {
            string radicaisSinonimos = Elementos.BuscaAvancada.TxtRadicaisSinonimos().Text;

            if (string.IsNullOrEmpty(radicaisSinonimos))
                return false;
            else
                return true;
        }

        public static void RetornarRadicaisSinonimos()
        {
            Elementos.BuscaAvancada.TxtRadicaisSinonimos().Click();
        }

        public static void ExibirRadicaisSinonimos()
        {
            Elementos.BuscaAvancada.BtnExibirSinonimosRadicais().Click();
        }

        #region Portal
        public static void SelecionarPortalAutomatizacao()
        {
            Elementos.BuscaAvancada.CheckboxPortal_Automatizacao().Click();
        }

        public static void SelecionarPortalDocRenomeado()
        {
            Elementos.BuscaAvancada.CheckboxPortal_DocRenomeado().Click();
        }

        public static void SelecionarPortalNormativosInternos()
        {
            Elementos.BuscaAvancada.CheckboxPortal_NormativosInternos().Click();
        }

        public static void SelecionarPortalProcessos()
        {
            Elementos.BuscaAvancada.CheckboxPortal_Processos().Click();
        }

        public static void SelecionarPortalNormativosExternos()
        {
            Elementos.BuscaAvancada.CheckboxPortal_NormativosExternos().Click();
        }
        #endregion

        #region Situacao
        public static void SelecionarSituacaoVigente()
        {
            Elementos.BuscaAvancada.CheckboxSituacao_Processo_Vigente().Click();
        }

        public static void SelecionarSituacaoObsoleto()
        {
            Elementos.BuscaAvancada.CheckboxSituacao_Processo_Obsoleto().Click();
        }

        public static void SelecionarSituacaoExpirado()
        {
            Elementos.BuscaAvancada.CheckboxSituacao_Processo_Expirado().Click();
        }

        public static void SelecionarSituacaoVigenciaFutura()
        {
            Elementos.BuscaAvancada.CheckboxSituacao_Processo_VigenciaFutura().Click();
        }
        #endregion

        #region Indexadores
        public static void SelecionarTipoDeDocumento_DocumentoParaTesteDeServico()
        {
            Elementos.BuscaAvancada.CheckboxTipoDocumento_DocumentoParaTestesDeServico().Click();
        }

        public static void SelecionarTipoDeDocumento_Resolucao_AlteradoRevogado()
        {
            Elementos.BuscaAvancada.CheckboxTipoDocumento_ResolucaoAlteradoRevogado().Click();
        }

        public static void SelecionarTipoDeDocumento_DocumentoDeNovidades()
        {
            Elementos.BuscaAvancada.CheckboxTipoDocumento_DocumentoDeNovidades().Click();
        }

        public static void SelecionarTipoDeDocumento_AssuntosGerais()
        {
            Elementos.BuscaAvancada.CheckboxTipoDocumento_AssuntosGerais().Click();
        }

        public static void SelecionarTipoDeDocumento_DocumentoDeAutomatizacao()
        {
            Elementos.BuscaAvancada.CheckboxPortal_Automatizacao().Click();
        }
        #endregion

        #region Categoria
        public static void SelecionarCategoria_Teste()
        {
            Elementos.BuscaAvancada.CheckboxCategoria_Teste().Click();
        }

        public static void SelecionarCategoria_Documentacao()
        {
            Elementos.BuscaAvancada.CheckboxCategoria_Documentacao().Click();
        }
        #endregion

        #region Efetivacao
        public static void PreencherDataDeEfetivacao(string dataInicio, string dataFim)
        {
            Elementos.BuscaAvancada.TxtDataEfetivacaoInicio().SendKeys(dataInicio);
            Elementos.BuscaAvancada.TxtDataEfetivacaoInicio().SendKeys(dataFim);
        }

        public static void PressionarBotao_PesquisarDataEfetivacao()
        {
            Elementos.BuscaAvancada.BtnPesquisarDataEfetivacao().Click();
        }
        #endregion

        #region Validade
        public static void PreencherDataDeValidade(string dataInicio, string dataFim)
        {
            Elementos.BuscaAvancada.TxtDataEfetivacaoInicio().SendKeys(dataInicio);
            Elementos.BuscaAvancada.TxtDataEfetivacaoInicio().SendKeys(dataFim);
        }

        public static void PressionarBotao_PesquisarDataValidade()
        {
            Elementos.BuscaAvancada.BtnPesquisarDataValidade().Click();
        }

        public static void PreencherCheckboxValidadeIndefinidade()
        {
            Elementos.BuscaAvancada.CheckboxValidade_ValidadeIndefinida().Click();
        }
        #endregion

        #region Layout
        public static void SelecionarVisualizacaoDosResultadosPorCards()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmCards().Click();
        }

        public static void SelecionarVisualizacaoDosResultadosPorLista()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }
        #endregion

        #region Menu Lateral
        public static void SelecionarMenuLateral_UltimasAtualizacoes()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_MeusFavoritos()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_MaisAcessados()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_DocumentosPorTipo()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_DocumentosPorArea()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_DocumentosPorIndexadores()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_DocumentosPorPasta()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_PainelGestaoDocumentos()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_PainelDeAtividades()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }

        public static void SelecionarMenuLateral_Tutoriais()
        {
            Elementos.BuscaAvancada.BtnVisualizacaoEmLista().Click();
        }
        #endregion
    }
}

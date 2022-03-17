using DocspiderWebAutomation.Utils.Wait;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocspiderWebAutomation.Elementos
{
    public class BuscaAvancada : CustomWait
    {
        #region Menu Lateral
        public static List<IWebElement> FiltroPortal()
        {
            return driver.FindElement(By.Id("listaPortal")).FindElements(By.ClassName("checkbox")).ToList();
        }

        public static List<IWebElement> FiltroSituacao()
        {
            return driver.FindElement(By.Id("situacoes")).FindElements(By.ClassName("checkbox")).ToList();
        }

        public static List<IWebElement> FiltroTipoDocumento()
        {
            return driver.FindElement(By.Id("tiposDocumento")).FindElements(By.ClassName("checkbox")).ToList();
        }
        #endregion

        #region Termos
        public static IWebElement RbtnBuscadoPorPalavra()
        {
            return driver.FindElement(By.Id("modoPorPalavra"));
        }

        public static IWebElement RbtnBuscadoPorExpressoes()
        {
            return driver.FindElement(By.Id("modoPorExpressao"));
        }

        public static IWebElement TxtTermoDaBusca()
        {
            return driver.FindElement(By.Id("termoBuscaFiltro"));
        }

        public static IWebElement BtnPesquisarTermo()
        {
            return driver.FindElement(By.Id("btnSubmitTermo"));
        }

        public static IWebElement RbtnComTodasAsPalavras()
        {
            return WaitForElement(By.Id("ComTodasAsPalavras"));
        }

        public static IWebElement RbtnComQualquerUmaDasPalavras()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.document.getElementById('ComQualquerUmaDasPalavras').click()");

            return null;
        }

        public static IWebElement TxtSemAsPalavras()
        {
            return driver.FindElement(By.Id("semAsPalavras"));
        }

        public static IWebElement BtnPesquisarFiltro()
        {
            return driver.FindElement(By.Id("btnFilterSubmit"));
        }        

        public static IWebElement TxtRadicaisSinonimos()
        {
            return driver.FindElement(By.XPath("//*[@id='collapseResultadoBusca']/div"));
        }

        public static IWebElement BtnExibirSinonimosRadicais()
        {
            return driver.FindElement(By.XPath("//*[@id='resultadoBusca']/div/div[1]/a/span/span"));
        }
        #endregion

        #region Itens do menu "Portal"        
        
        public static IWebElement QuantidadeDeResultadosNaBusca()
        {
            return driver.FindElement(By.Id("TotalItemCount"));
        }

        public static IWebElement CheckboxPortal_Automatizacao()
        {
            return driver.FindElement(By.XPath("//*[@id='listaPortal']/div[1]/label/input"));
        }

        public static IWebElement CheckboxPortal_DocRenomeado()
        {
            return driver.FindElement(By.XPath("//*[@id='listaPortal']/div[2]"));
        }

        public static IWebElement CheckboxPortal_NormativosExternos()
        {
            return driver.FindElement(By.XPath("//*[@id='listaPortal']/div[3]"));
        }

        public static IWebElement CheckboxPortal_NormativosInternos()
        {
            return driver.FindElement(By.XPath("//*[@id='listaPortal']/div[4]"));
        }

        public static IWebElement CheckboxPortal_AdministracaoDocSpider()
        {
            return driver.FindElement(By.XPath("//*[@id='listaPortal']/div[5]"));
        }

        public static IWebElement CheckboxPortal_Processos()
        {
            return driver.FindElement(By.XPath("//*[@id='listaPortal']/div[6]"));
        }
        
        #endregion

        #region Itens do menu "Tipo de Documento"
        public static IWebElement CheckboxTipoDocumento_DocumentoParaTestesDeServico()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[1]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_AssuntosGerais()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[2]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Fluxograma()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[3]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_ResolucaoAlteradoRevogado()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[4]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoDeNovidades()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[5]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Manual()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[6]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoDeAutomatizacao()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[7]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Contratos()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[8]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_AssuntosConhecimento()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[9]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoAlteraRevoga()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[10]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoModeloAntigo()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[11]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_TutoriaisDicas()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[12]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Politica()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[13]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_AnexoManual()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[14]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_NormasProcedimento()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[15]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoParaInativacao()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[16]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_NormaBradesco()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[17]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_BNDES()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[18]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DiagramaDeProcesso()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[19]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Resolucao()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[20]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Anexo()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[21]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Teste()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[22]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoCliente()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[23]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_FluxoObsolescencia()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[24]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_Dependente()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[25]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoDependenteObrigatorio()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[26]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_DocumentoModelo()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[28]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_TesteDeProcesso()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[29]/label/input"));
        }

        public static IWebElement CheckboxTipoDocumento_NormasComercializacao()
        {
            return driver.FindElement(By.XPath("//*[@id='tipoDocumento']/div[30]/label/input"));
        }
        #endregion

        #region Indexadores
        public static IWebElement CheckboxIndexadores_Camada()
        {
            return driver.FindElement(By.Id("tipoIndexador-5"));
        }

        public static IWebElement CheckboxIndexadores_Camada_Negocios()
        {
            return driver.FindElement(By.Id("tipoIndexador-29"));
        }

        public static IWebElement CheckboxIndexadores_Processo()
        {
            return driver.FindElement(By.Id("tipoIndexador-7"));
        }

        public static IWebElement CheckboxIndexadores_Processo_IdentificadoA()
        {
            return driver.FindElement(By.Id("tipoIndexador-44"));
        }
        #endregion
                
        #region Situacao
        public static IWebElement CheckboxSituacao_Processo_Vigente()
        {
            return driver.FindElement(By.XPath("//*[@id='situacao']/div[1]/label/input"));
        }

        public static IWebElement CheckboxSituacao_Processo_Obsoleto()
        {
            return driver.FindElement(By.XPath("//*[@id='situacao']/div[2]/label/input"));
        }

        public static IWebElement CheckboxSituacao_Processo_Expirado()
        {
            return driver.FindElement(By.XPath("//*[@id='situacao']/div[3]/label/input"));
        }

        public static IWebElement CheckboxSituacao_Processo_VigenciaFutura()
        {
            return driver.FindElement(By.XPath("//*[@id='situacao']/div[4]/label/input"));
        }
        #endregion

        #region Categoria
        public static IWebElement CheckboxCategoria_Teste()
        {
            return driver.FindElement(By.XPath("//*[@id='categoria']/div[1]/label/input"));
        }

        public static IWebElement CheckboxCategoria_Documentacao()
        {
            return driver.FindElement(By.XPath("//*[@id='categoria']/div[2]/label/input"));
        }
        #endregion

        #region Efetivacao
        public static IWebElement TxtDataEfetivacaoInicio()
        {
            return driver.FindElement(By.XPath("//*[@id='dataEfetivacao']/span[1]/span/input"));
        }

        public static IWebElement TxtDataEfetivacaoFim()
        {
            return driver.FindElement(By.XPath("//*[@id='dataEfetivacao']/span[3]/span/input"));
        }

        public static IWebElement BtnPesquisarDataEfetivacao()
        {
            return driver.FindElement(By.XPath("//*[@id='efetivacao']/button"));
        }
        #endregion
        
        #region Validade
        public static IWebElement TxtDataValidadeInicio()
        {
            return driver.FindElement(By.XPath("//*[@id='dataEfetivacao'/span[1]/span/input"));
        }

        public static IWebElement TxtDataValidadeFim()
        {
            return driver.FindElement(By.XPath("//*[@id='dataEfetivacao']/span[3]/span/input"));
        }

        public static IWebElement BtnPesquisarDataValidade()
        {
            return driver.FindElement(By.XPath("//*[@id='efetivacao']/button"));
        }////*[@id="comValidadeIndefinida"]

        public static IWebElement CheckboxValidade_ValidadeIndefinida()
        {
            return driver.FindElement(By.Id("comValidadeIndefinida"));
        }
        #endregion

        #region Menu Lateral
        public static IWebElement BtnMenuLateral_UltimasAtualizacoes()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[2]/a"));
        }

        public static IWebElement BtnMenuLateral_MeusFavoritos()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[3]/a"));
        }

        public static IWebElement BtnMenuLateral_UltimosAcessados()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[4]/a"));
        }

        public static IWebElement BtnMenuLateral_MaisAcessados()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[5]/a"));
        }

        public static IWebElement BtnMenuLateral_DocumentosPorTipo()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[6]/a"));
        }

        public static IWebElement BtnMenuLateral_DocumentosPorArea()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[7]/a"));
        }

        public static IWebElement BtnMenuLateral_DocumentosPorIndexadores()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[8]/a"));
        }

        public static IWebElement BtnMenuLateral_DocumentosPorPasta()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[9]/a"));
        }

        public static IWebElement BtnMenuLateral_PainelGestaoDeDocumentos()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[10]/a"));
        }

        public static IWebElement BtnMenuLateral_PainelDeAtividades()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[11]/a"));
        }

        public static IWebElement BtnMenuLateral_Tutoriais()
        {
            return driver.FindElement(By.XPath("//*[@id='sidebar-wrapper']/ul/li[12]/a"));
        }
        #endregion

        #region Layout

        public static IWebElement BtnVisualizacaoEmCards()
        {
            return driver.FindElement(By.Id("btnChangeViewCards"));
        }

        public static IWebElement BtnVisualizacaoEmLista()
        {
            return driver.FindElement(By.Id("btnChangeViewCardsList"));
        }
        #endregion
    }
}

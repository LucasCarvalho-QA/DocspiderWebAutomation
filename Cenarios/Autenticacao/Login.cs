using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Cenarios.Autenticacao
{
    [TestFixture, Category("Autenticacao")]
    public class Login : Setup
    {
        [TestCase(TestName = "CT001_Acesso_usuário_senha_válido")]
        public void Autenticacao_AcessoComUsuarioSenhaValidos()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("camila", "123456");

            //Assert
            bool resultado = Page.PaginaInicialPage.VerificarPresencaNaPagina();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT002_Acesso_usuário_senha_inválido")]
        public void Autenticacao_AcessoComUsuarioSenhaInvalidos()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("abced", "00000");

            //Assert
            bool resultado = Page.LoginPage.ValidarLogin();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT003_Acesso_usuário_inválido_senha_válida")]
        public void Autenticacao_AcessoComUsuarioInvalidoSenhaValida()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("abced", "docspider");

            //Assert
            bool resultado = Page.LoginPage.ValidarLogin();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT004_Acesso_usuário_válido_senha_inválida")]
        public void Autenticacao_AcessoComUsuarioValidoSenhaInvalida()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("abced", "docspider");

            //Assert
            bool resultado = Page.LoginPage.ValidarLogin();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT005_Acesso_usuário_válido_senha_em_branco")]
        public void Autenticacao_AcessoComUsuarioValidoSenhaEmBranco()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("docspider", "");

            //Assert
            bool resultado = Page.LoginPage.ValidarLogin();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT006_Acesso_usuário_em_branco_senha_valida")]
        public void Autenticacao_AcessoComUsuarioEmBrancoSenhaValida()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("", "docspider");

            //Assert
            bool resultado = Page.LoginPage.ValidarLogin();
            Assert.IsTrue(resultado);
        }

        [TestCase(TestName = "CT008_Acesso_usuário_e_senha_em_branco")]
        public void Autenticacao_AcessoComUsuarioSenhaEmBranco()
        {
            //Arrange
            //Act
            Page.LoginPage.RealizarLogin("", "");

            //Assert
            bool resultado = Page.LoginPage.ValidarLogin();
            Assert.IsTrue(resultado);
        }
    }
}

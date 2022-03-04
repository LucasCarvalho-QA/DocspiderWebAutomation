using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DocspiderWebAutomation.SetupProject
{
    [SetUpFixture]
    public class Setup
    {
        public string Ambiente { get; set; }
        public string Navegador { get; set; }

        public static IWebDriver driver;
        private static string arquivoDeConfiguracao = Path.Combine(Path.Combine(Environment.CurrentDirectory, "SetupProject", "ConfiguracoesDeAmbiente.json"));
        public Setup configuracoes;

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            string json = Utils.StringFormatter.Json.LeitorJson(arquivoDeConfiguracao);
            configuracoes = JsonConvert.DeserializeObject<Setup>(json);

            if (configuracoes.Navegador.Equals("Chrome"))
                ChromeDriverSetup();
        }

        public void ChromeDriverSetup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalOption(CapabilityType.SupportsApplicationCache, false);      
            driver = new ChromeDriver(options);
        }

        [SetUp]
        public void SetupBeforeEachTest()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            driver.Navigate().GoToUrl(configuracoes.Ambiente);
        }        

        [TearDown]
        public void SetupAfterEachTest()
        {
            
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            driver.Close();
            //Process.Start("taskkill", "/F /IM chromedriver.exe");
        }
    }
}

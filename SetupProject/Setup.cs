using DocspiderWebAutomation.Utils.ReportManagement;
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
        public static string localRunId = string.Empty;
        private static string arquivoDeConfiguracao = Path.Combine(Path.Combine(Environment.CurrentDirectory, "SetupProject", "ConfiguracoesDeAmbiente.json"));
        public Setup configuracoes;
        readonly ReportService reportService = new ReportService();
        Report report = new Report();
        static Stopwatch stopwatch = new Stopwatch();
        public static string tempoDecorridoTotal;
        public static string outcome;

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            if (localRunId == string.Empty)
                localRunId = $"Local_Run_{DateTime.Now:HHmmss}";

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
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 15);
            driver.Navigate().GoToUrl(configuracoes.Ambiente);
        }        

        [TearDown]
        public void SetupAfterEachTest()
        {
            report.GenerateReport();
            var localReport = Report.report;

            if (TestContext.CurrentContext.Result.FailCount > 0)
                localReport.StackTrace += TestContext.CurrentContext.Result.Message ?? "";

            localReport.Outcome = TestContext.CurrentContext.Result.Outcome.ToString() == "Passed" ? "Sucesso" : "Falha";
            

            stopwatch.Stop();
            tempoDecorridoTotal = stopwatch.Elapsed.TotalSeconds.ToString("N2");
            localReport.ElapsedTime = tempoDecorridoTotal;
            reportService.SaveReport(reportService.GetReport(localReport), localReport.Outcome);
            ScreenshotUtils.PrintScreen();
            Report.ListErrors = new List<string>();
        }

        

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            driver.Close();
        }
    }
}

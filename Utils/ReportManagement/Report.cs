using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocspiderWebAutomation.Utils.ReportManagement
{
    public class Report : ReportService
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public string Headers { get; set; }
        public string CurrentRequestElapsedTime { get; set; }
        public string ElapsedTime { get; set; }
        public string TestMethodName { get; set; }
        public string AzureTestCaseName { get; set; }
        public string Datetime { get; set; }
        public string Outcome { get; set; }
        public string ExpectedOutcome { get; set; }
        public string TestCategory { get; set; }
        public string StackTrace { get; set; }
        public string ExpectedBodyRequest { get; set; }
        public static List<string> ListErrors = new List<string>();

        public static Report report = null;

        public void GenerateReport()
        {
            Report reportBody = new Report
            {
                Datetime = DateTime.Now.ToString(),
                Outcome = string.Empty,
                CurrentRequestElapsedTime = string.Empty,
                ElapsedTime = Setup.tempoDecorridoTotal,
                TestMethodName = TestContext.CurrentContext.Test.MethodName,
                AzureTestCaseName = TestContext.CurrentContext.Test.Name,
            };

            GetResultAssertions();
            report = reportBody;
        }

        public void GetResultAssertions()
        {
            foreach (var item in TestContext.CurrentContext.Result.Assertions)
                ListErrors.Add(item.Message);
        }
    }
}

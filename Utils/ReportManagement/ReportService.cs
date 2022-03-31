using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DocspiderWebAutomation.Utils.ReportManagement
{
    public class ReportService
    {
        private DirectoryInfo TestResultFolder;
        private DirectoryInfo DatetimeFolder;
        public static string timestamp = DateTime.Now.Ticks.ToString();
        private readonly string CurrentTestFolder = TestContext.CurrentContext.TestDirectory;

        public void SaveReport(string report, string outcome)
        {
            var path = GetPath();

            var name = StringFormatter.RegexCustom.NormalizeStringToSave(TestContext.CurrentContext.Test.Name);
           
            var filename = $"{outcome.Replace("Failed:Error", "Falha")}_{name}.txt";

            SaveFile(report, path, filename);
        }

        public DirectoryInfo GetPath()
        {
            TestResultFolder = Directory.CreateDirectory(@"..\..\..\Runs");

            var currentClassName = TestContext.CurrentContext.Test.ClassName;

            DatetimeFolder = Directory.CreateDirectory(Path.Combine(TestResultFolder.FullName, DateTime.Now.Date.ToString("dd-MM-yyyy")));

            return Directory.CreateDirectory(Path.Combine(DatetimeFolder.FullName, Setup.localRunId, currentClassName.Split(new[] { '.' }).Last()));
        }

        private void SaveFile(string text, DirectoryInfo path, string filename)
        {
            FileStream fs = new FileStream(Path.Combine(path.FullName, filename), FileMode.Create, FileAccess.Write);
            using var sw = new StreamWriter(fs);
            sw.WriteLine(text);
            TestContext.AddTestAttachment(Path.Combine(path.FullName, filename));
        }

        public string GetReport(Report report)
        {
            string errorList = StringFormatter.String.ListToString(Report.ListErrors).Replace("Expected", "Esperado").Replace("But was", "Encontrado");

            return $"================================================================================================== \n" +
                    $"DATA: {report.Datetime} \n" +
                    $"NOME DO MÉTODO: {report.TestMethodName} \n" +
                    $"RESULTADO: {report.Outcome} \n" +
                    $"LISTA DE ERROS: \n{errorList}\n" +
                    $"================================================================================================== \n";
        }
    }
}

using DocspiderWebAutomation.SetupProject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DocspiderWebAutomation.Utils.ReportManagement
{
    public class ScreenshotUtils : Setup
    {

        public static void PrintScreen(IWebElement element = null, string filename = null) { 
        
            ReportService reportService = new ReportService();
            string testName = TestContext.CurrentContext.Test.Name;

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            var bmpScreen = new Bitmap(new MemoryStream(screenshot.AsByteArray));

            if (element == null)
                element = Elementos.ElementosComuns.AguardarResultadosDaPesquisa();

            var cropArea = new Rectangle(element.Location, element.Size);

            var path = reportService.GetPath();
            bmpScreen.Clone(cropArea, bmpScreen.PixelFormat);
            bmpScreen.Save(Path.Combine(path.FullName, $"{outcome}_{testName}{filename}.jpg"), ImageFormat.Jpeg);
        }

        public static void PrintScreenOfWebElement(IWebElement element)
        {
            PrintScreen(element, "000");
        }

    }
}

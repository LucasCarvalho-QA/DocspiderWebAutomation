using NUnit.Framework;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DocspiderWebAutomation.Utils.ReportManagement
{
    internal class ScreenUtils
    {
        public void PrintScreen(string outcome)
        {
            ReportService reportService = new ReportService();
            string testName = TestContext.CurrentContext.Test.Name;

            using var bitmap = new Bitmap(1920, 1080);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(0, 0, 0, 0,
                bitmap.Size, CopyPixelOperation.SourceCopy);
            }
            var path = reportService.GetPath();
            bitmap.Save(Path.Combine(path.FullName, $"{outcome}_{testName}.jpg"), ImageFormat.Jpeg);
        }
    }
}

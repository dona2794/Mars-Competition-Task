using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;

        private static ExtentReports extent;

        private ExtentManager()
        {

        }

        public static ExtentReports getInstance()
        {
            if (extent == null)
            {
                //string filePath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                // filePath = Directory.GetParent(Directory(filePath).FullName).FullName;
                string reportPath = @"C:\TA Analyst\Mars-Competition-Task\MarsOboardingTask2\ExtentReports\Reports.html";
                //string reportFile = DateTime.Now.ToString().Replace("/","_").Replace(":","_");
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("Host Name", "Dona");
                extent.AddSystemInfo("Environment", "QA");

                //Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();

                string extentConfigPath = @"C:\TA Analyst\Mars-Competition-Task\MarsOboardingTask2\extent-config.xml";           
                htmlReporter.LoadConfig(extentConfigPath);
            }
            return extent;
        }
    }
}

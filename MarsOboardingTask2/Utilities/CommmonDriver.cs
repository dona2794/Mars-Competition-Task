using MarsQA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ExcelOperation;

namespace MarsQA.Utilities
{
    public class CommmonDriver
    {
        public static IWebDriver driver;
        [OneTimeSetUp]

        public void LoginFunction()
        {
            try
            {
                // open chrome browser
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                //Login page object initialization and definition
                LoginPage loginPageObj = new LoginPage();

                //Storing Excel data in to the in-memory collecation
                ExcelData.PopulateInCollection(@"C:\TA Analyst\Mars-Competition-Task\MarsOboardingTask2\ExcelDataFile\Login.xlsx");

                //Entering username and password using Column Name and Row number   

                loginPageObj.LoginSteps(driver, ExcelData.ReadData(1, "Username"), ExcelData.ReadData(1, "Password"));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message,"Login successful");
                throw;
            }
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }
}

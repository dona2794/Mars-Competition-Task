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
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();

            //Entering User information using Column Name and Row number 
            loginPageObj.LoginSteps(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }
}

using AventStack.ExtentReports;
using ExcelOperation;
using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Data;

namespace MarsQA.Tests
{
    [TestFixture]
    internal class ProfilePage_Test : CommmonDriver
    {

        [Test, Order(1)]
        public void AddDescription_Test()

        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToProfilePage(driver);

            //Profile page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();

            //Storing Excel data in to the in-memory collecation
            ExcelData.PopulateInCollection(@"C:\TA Analyst\Mars-Competition-Task\MarsOboardingTask2\ExcelDataFile\Description.xlsx");

            //Entering description using Column Name and Row number
            for (int i = 1; i <= 2; i++)
            {
                profilePageObj.AddDescription(driver, ExcelData.ReadData(i, "Description"));
            }

        }

        [Test, Order(2)]
        public void AddLanguage_Test()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToProfilePage(driver);

            //Profile page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();

            //Storing Excel data in to the in-memory collecation
            ExcelData.PopulateInCollection(@"C:\TA Analyst\Mars-Competition-Task\MarsOboardingTask2\ExcelDataFile\Language.xlsx");

            //Entering language using Column Name and Row number
            profilePageObj.AddLanguage(driver, ExcelData.ReadData(1, "Language"));

        }

        /* [Test,Order(3)]
         public void AddSkill_Test()
         {
             //Home page object initialization and definition
             HomePage homePageObj = new HomePage();
             homePageObj.GoToProfilePage(driver);

             //Profile page object initialization and definition
             ProfilePage profilePageObj = new ProfilePage();
             profilePageObj.AddSkill(driver);

         }*/

    }
}

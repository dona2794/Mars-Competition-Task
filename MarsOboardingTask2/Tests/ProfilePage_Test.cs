using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsQA.Tests
{
    [TestFixture]
    internal class ProfilePage_Test : CommmonDriver
    {     
       
        [Test,Order(1)]
        public void AddDescription_Test()

        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToProfilePage(driver);

            //Profile page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver, "Test Analyst");

        }

        [Test,Order(2)]
        public void AddLanguage_Test()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToProfilePage(driver);

            //Profile page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguage(driver);

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

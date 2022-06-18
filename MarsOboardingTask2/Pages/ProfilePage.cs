using AventStack.ExtentReports;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    internal class ProfilePage
    {
        ExtentReports rep = ExtentManager.getInstance();
        ExtentTest test;

        public void AddDescription(IWebDriver driver, string description)
        {

            test = rep.CreateTest("Add Description");
            test.Log(Status.Info, "Test started");

            // Identify description edit button and click on it
            IWebElement descriptionEditButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));
            descriptionEditButton.Click();

            Thread.Sleep(2000);

            // Identify description textarea and enter valid details
            IWebElement descriptionTextarea = driver.FindElement(By.Name("value"));
            descriptionTextarea.Clear();
            test.Log(Status.Info, "Description area cleared");

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 2);

            descriptionTextarea.SendKeys(description);
            test.Log(Status.Info, "Description entered");

            //Click on save Button
            driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
            Thread.Sleep(2000);
            test.Log(Status.Info, "Description saved");

            //Check if description is present in page
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Thread.Sleep(1000);

            rep.Flush();
        }

        public string GetProfileDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return createdDescription.Text;
        }

        public void AddLanguage(IWebDriver driver)
        {

            test = rep.CreateTest("Add Language");
            test.Log(Status.Info, "Test started");

            //Identify language tab and click on it
            IWebElement languageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            test.Log(Status.Info, "Language section launched");

            // click on add new button 
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            //Identify language and enter valid details
            IWebElement addLanguageTextbox = driver.FindElement(By.Name("name"));
            addLanguageTextbox.SendKeys("English");
            test.Log(Status.Info, "Language entered");


            //Identify language level dropdown and choose one
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropdown.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]", 3);

            IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            fluentOption.Click();
            test.Log(Status.Info, "Fluent option entered");

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 3);

            // Click on add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            test.Log(Status.Info, "Language saved");
            test.Log(Status.Info, "Test passed");

            rep.Flush();
        }

        public string GetActualLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newLanguage.Text;
        }

        /* public void AddSkill(IWebDriver driver)
         {
             //Identify skill tab and click on it
             IWebElement skillTab=driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
             skillTab.Click();

             // click on add new button 
             IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
             addSkillButton.Click();

             //Identify Skill tab and enter valid details
             IWebElement addSkillTextbox= driver.FindElement(By.Name("name"));
             addSkillTextbox.SendKeys("Selenium");

             //Identify language level dropdown and choose one
             IWebElement skillLevelDropdown = driver.FindElement(By.Name("level"));
             skillLevelDropdown.Click();

             Thread.Sleep(1000);
             IWebElement skillOption = driver.FindElement(By.XPath("//*[@id='account-profile-section]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
             skillOption.Click();

             Thread.Sleep(1000);

             IWebElement addSkill =driver.FindElement(By.Id("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
             addSkill.Click();

         }         */


        public void AddEducation(IWebDriver driver)
        {

        }

        public void AddCertification(IWebDriver driver)
        {

        }

        public void EditDescription(IWebDriver driver)
        {

        }

    }
}

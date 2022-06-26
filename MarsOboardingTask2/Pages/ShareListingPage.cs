using AventStack.ExtentReports;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    internal class ShareListingPage
    {
          public void ShareSkillsSteps(IWebDriver driver)
         {

            ExtentReports rep = ExtentManager.getInstance();
            ExtentTest test;

            try
            {

                test = rep.CreateTest("Share Skill");
                test.Log(Status.Info,"Test started");

                //Identify share skill button and click on it
                IWebElement shareSkillButton= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
                shareSkillButton.Click();;
                test.Log(Status.Info,"Share skill page launched");

                Wait.WaitToBeVisible(driver,"Name","title",2 );

                //Identify title textbox and enter valid details
                IWebElement titleTextbox = driver.FindElement(By.Name("title"));
                titleTextbox.SendKeys("Test Analyst");
                test.Log(Status.Info,"Title entered");

                //Identify description textarea and enter valid details
                IWebElement descriptionTextarea = driver.FindElement(By.Name("description"));
                descriptionTextarea.SendKeys("I am a wizard! Not like Harry Potter, but I do have some magic tricks up my sleeve");
                test.Log(Status.Info,"Description entered");


                //Identify category dropdown and enter valid category
                IWebElement categoryDropdown = driver.FindElement(By.Name("categoryId"));
                categoryDropdown.Click();

                IWebElement selectCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
                selectCategory.Click();
                test.Log(Status.Info,"Category chosen");


                //Identify sub-category dropdown and enter valid category
                IWebElement subCategoryDropdown = driver.FindElement(By.Name("subcategoryId"));
                subCategoryDropdown.Click();

                IWebElement selectSubCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]"));
                selectSubCategory.Click();
                test.Log(Status.Info,"Sub-category chosen");

                //Identify tag texbox and enter valid details
                IWebElement tagTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
                tagTextbox.SendKeys("Selenium"); 
                tagTextbox.SendKeys(Keys.Return);
                test.Log(Status.Info,"Tags entered");

                //Identify  service type radio button and select valid credential
                IWebElement serviceTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
                serviceTypeRadio.Click();
                test.Log(Status.Info,"Servic type selected");

                //Identify location type radio button and select valid credential
                IWebElement locationTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
                locationTypeRadio.Click();
                test.Log(Status.Info,"Location type selected");

                //Identify available day and enter valid credential
                IWebElement availableDay1Select = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
                availableDay1Select.Click();

                IWebElement availableDay1Start = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
                availableDay1Start.SendKeys("08.00AM");

                IWebElement availableDay1Finish = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
                availableDay1Finish.SendKeys("05:00PM");

                IWebElement availableDay2Select = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[1]/div/input"));
                availableDay2Select.Click();

                IWebElement availableDay2Start = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input"));
                availableDay2Start.SendKeys("03.00PM");

                IWebElement availableDay2Finish = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input"));
                availableDay2Finish.SendKeys("11.00PM");
                test.Log(Status.Info,"Available day and time selected");

                //Identify SKill trade radio button and select valid credential
                IWebElement skillTradeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
                skillTradeRadio.Click();
                test.Log(Status.Info,"Skill trade chosen");

                //Identify SKill Exchange textbox and enter valid credential
                IWebElement skillCreditTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
                skillCreditTextbox.SendKeys("C#");
                skillCreditTextbox.SendKeys(Keys.Return);
                test.Log(Status.Info," Skill credit entered");

                //Identify active radio button and select valid credential
                IWebElement activeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
                activeRadio.Click();

                //Identify save button and click on it
                IWebElement saveSkillButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
                saveSkillButton.Click();
                test.Log(Status.Info,"Skill saved");
                test.Log(Status.Info,"Test passed");

                rep.Flush();

            }

            catch(Exception ex)
            {
             Assert.Fail("Mars Portal Share Skill page did not lanuch", ex.Message);
             throw;
                
            }
         }
    }
}
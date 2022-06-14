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
    internal class SellerListingPage
    {
        
    ExtentReports rep = ExtentManager.getInstance();
    ExtentTest test;

        public void ViewListing(IWebDriver driver)
        {
            try
            {

                Thread.Sleep(500);

                test = rep.CreateTest("View Listing");
                test.Log(Status.Info,"Test started");

                //Identify manage listing tab and click on it
                IWebElement manageListingTab = driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));
                manageListingTab.Click();
                test.Log(Status.Info,"Test started");

                Thread.Sleep(1000);
                                
                //Identify view button and click on it
                IWebElement viewProfileButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));
                viewProfileButton.Click();
                Thread.Sleep(1000);
                test.Log(Status.Info,"View skill page launched");
                test.Log(Status.Info,"Test passed");

                rep.Flush();
            }

            catch(Exception ex)
            {
             Assert.Fail("Mars Portal View home page did not lanuch", ex.Message);
             throw;
                
            }
        }       

        public string GetActualSkill(IWebDriver driver)
        {
            IWebElement actualSkill= driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[3]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));
            return actualSkill.Text;
        }


         public void EditListing(IWebDriver driver)

         {
            try
            {
                
                test = rep.CreateTest("Edit Listing");
                test.Log(Status.Info,"Test started");

                Thread.Sleep(1000);

                //Identify manage listing tab and click on it
                IWebElement manageListingTab = driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));
                manageListingTab.Click();

                Thread.Sleep(1000);

                //Identify edit button and click on it
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
                editButton.Click();
                Thread.Sleep(1000);
                test.Log(Status.Info,"Editing page launched");


                //Identify title textbox and enter valid details
                IWebElement editTitleTextbox = driver.FindElement(By.Name("title"));
                editTitleTextbox.Clear();
                editTitleTextbox.SendKeys("Junior Test Analyst");
                test.Log(Status.Info,"Updated Title");

                Thread.Sleep(1000);

                //Identify  service type radio button and select valid credential
                IWebElement editServiceTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
                editServiceTypeRadio.Click();
                test.Log(Status.Info,"Updated service type");

                //Identify location type radio button and select valid credential
                IWebElement editLocationTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
                editLocationTypeRadio.Click();
                Thread.Sleep(1000);
                test.Log(Status.Info,"Updated location type");


                //Identify SKill trade radio button and select valid credential
                IWebElement editSkillTradeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
                editSkillTradeRadio.Click();

                 Thread.Sleep(1000);

                IWebElement creditTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
                creditTextbox.SendKeys("10");
                test.Log(Status.Info,"Updated skill trade");

               //Identify active radio button and select valid credential
                IWebElement activeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
                activeRadio.Click();
                Thread.Sleep(1000);

                //Identify save button and click on it
                IWebElement saveUpdateButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
                saveUpdateButton.Click();
                test.Log(Status.Info,"Updated data saved succesfully");
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

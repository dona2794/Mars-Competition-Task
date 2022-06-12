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
         public void ShareSkillsSteps(IWebDriver driver)
         {
            try
            {
                //Identify share skill button and click on it
                IWebElement shareSkillButton= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
                shareSkillButton.Click();;

                Wait.WaitToBeVisible(driver,"Name","title",2 );

                //Identify title textbox and enter valid details
                IWebElement titleTextbox = driver.FindElement(By.Name("title"));
                titleTextbox.SendKeys("Test Analyst");

                //Identify description textarea and enter valid details
                IWebElement descriptionTextarea = driver.FindElement(By.Name("description"));
                descriptionTextarea.SendKeys("I am a wizard! Not like Harry Potter, but I do have some magic tricks up my sleeve");


                //Identify category dropdown and enter valid category
                IWebElement categoryDropdown = driver.FindElement(By.Name("categoryId"));
                categoryDropdown.Click();

                IWebElement selectCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
                selectCategory.Click();


                //Identify sub-category dropdown and enter valid category
                IWebElement subCategoryDropdown = driver.FindElement(By.Name("subcategoryId"));
                subCategoryDropdown.Click();

                IWebElement selectSubCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]"));
                selectSubCategory.Click();

                //Identify tag texbox and enter valid details
                IWebElement tagTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
                tagTextbox.SendKeys("Selenium"); 
                tagTextbox.SendKeys(Keys.Return);

                //Identify  service type radio button and select valid credential
                IWebElement serviceTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
                serviceTypeRadio.Click();

                //Identify location type radio button and select valid credential
                IWebElement locationTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
                locationTypeRadio.Click();

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

                //Identify SKill trade radio button and select valid credential
                IWebElement skillTradeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
                skillTradeRadio.Click();

                //Identify SKill Exchange textbox and enter valid credential
                IWebElement skillCreditTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
                skillCreditTextbox.SendKeys("C#");
                skillCreditTextbox.SendKeys(Keys.Return);

                //Identify active radio button and select valid credential
                IWebElement activeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
                activeRadio.Click();

                //Identify save button and click on it
                IWebElement saveSkillButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
                saveSkillButton.Click();

            }

            catch(Exception ex)
            {
             Assert.Fail("Mars Portal Share Skill page did not lanuch", ex.Message);
             throw;
                
            }
         }

        public void ViewListing(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(1000);

                //Identify manage listing tab and click on it
                IWebElement manageListingTab = driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));
                manageListingTab.Click();

                Thread.Sleep(1000);
                                
                //Identify view button and click on it
                IWebElement viewProfileButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));
                viewProfileButton.Click();
                Thread.Sleep(1000);
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
                Thread.Sleep(1000);

                //Identify manage listing tab and click on it
                IWebElement manageListingTab = driver.FindElement(By.XPath("//*[@id='listing-management-section']/section[1]/div/a[3]"));
                manageListingTab.Click();

                Thread.Sleep(1000);

                //Identify edit button and click on it
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
                editButton.Click();
                Thread.Sleep(1000);

                //Identify title textbox and enter valid details
                IWebElement editTitleTextbox = driver.FindElement(By.Name("title"));
                editTitleTextbox.Clear();
                editTitleTextbox.SendKeys("Junior Test Analyst");

                Thread.Sleep(1000);

                //Identify  service type radio button and select valid credential
                IWebElement editServiceTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
                editServiceTypeRadio.Click();

                //Identify location type radio button and select valid credential
                IWebElement editLocationTypeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
                editLocationTypeRadio.Click();
                Thread.Sleep(1000);

                //Identify SKill trade radio button and select valid credential
                IWebElement editSkillTradeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
                editSkillTradeRadio.Click();

                 Thread.Sleep(1000);

                IWebElement creditTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
                creditTextbox.SendKeys("10");

               //Identify active radio button and select valid credential
                IWebElement activeRadio = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
                activeRadio.Click();
                Thread.Sleep(1000);

                //Identify save button and click on it
                IWebElement saveUpdateButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
                saveUpdateButton.Click();

            }

            catch(Exception ex)
            {
             Assert.Fail("Mars Portal Share Skill page did not lanuch", ex.Message);
             throw;
                
            }
         }

    } 
}

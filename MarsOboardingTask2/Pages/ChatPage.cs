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
    internal class ChatPage
    {
       public void ViewChatRoom(IWebDriver driver)
        {
            try
            {
                Thread.Sleep(1000);

                //Identify manage listing tab and click on it
                IWebElement manageListingTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
                manageListingTab.Click();

                Thread.Sleep(1000);
                                
                //Identify view button and click on it
                IWebElement viewProfileButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));
                viewProfileButton.Click();
                Thread.Sleep(1000);

                //Identify chat button and click on it
                IWebElement chatButton = driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a"));
                chatButton.Click();

                Thread.Sleep(2000);

            }

            catch(Exception ex)
            {
                Assert.Fail("Mars ChatRoom page did not lanuch", ex.Message);
                throw;
            }
       }  
        public void SendMessage(IWebDriver driver, string message)
        {
            try
            {
                Thread.Sleep(1000);

                //Identify manage listing tab and click on it
                IWebElement manageListingTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
                manageListingTab.Click();

                Thread.Sleep(1000);
                                
                //Identify view button and click on it
                IWebElement viewProfileButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));
                viewProfileButton.Click();
                Thread.Sleep(1000);

                //Identify chat button and click on it
                IWebElement chatButton = driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/div/a"));
                chatButton.Click();

                Thread.Sleep(2000);

                //Identify message textbox and enter valid data
                IWebElement messageTextbox = driver.FindElement(By.XPath("//*[@id='chatTextBox']"));
                messageTextbox.Click();

                Thread.Sleep(1000);

                messageTextbox.SendKeys(message);

                //Identify send button and click on it
                IWebElement sendButton = driver.FindElement(By.XPath("//*[@id='btnSend']"));
                sendButton.Click();
                Thread.Sleep(1000);

            }

            catch(Exception ex)
            {
                Assert.Fail("Sending message failed", ex.Message);
                throw;
                
            }
        }   
    }
}

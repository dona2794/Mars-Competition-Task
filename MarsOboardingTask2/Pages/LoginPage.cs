using AventStack.ExtentReports;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver, string username, string password)

        {
            ExtentReports rep = ExtentManager.getInstance();
            ExtentTest test;

            try
            {
                test = rep.CreateTest("Login Page");

                // launch Turnup portal
                driver.Navigate().GoToUrl("http://localhost:5000/Home");
                test.Log(Status.Info,"Mars portal Launched");

                // click on "Sign In" link
                driver.FindElement(By.LinkText("Sign In")).Click();
                test.Log(Status.Info,"Navigated to Sign In Page");

                // identify username  textbox and enter valid email address
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys(username);
                test.Log(Status.Info,"Username entered");

                // identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys(password);
                test.Log(Status.Info,"Password entered");

                // click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                test.Log(Status.Info,"Sign in successful");
                
                Thread.Sleep(1000); 

                rep.Flush();
            }

            catch (Exception ex)
            {
             Assert.Fail("Mars Portal login page did not lanuch", ex.Message);
             throw;
            }
          
        }     

    }
}

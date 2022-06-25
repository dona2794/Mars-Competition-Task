﻿using ExcelOperation;
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
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            try
            {
                // launch Turnup portal
                driver.Navigate().GoToUrl("http://localhost:5000/Home");

                // click on "Sign In" link
                driver.FindElement(By.LinkText("Sign In")).Click();


                // identify username  textbox and enter valid email address
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("donapathikunnel@gmail.com");

                // identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("Testing!");

                // click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();

                Thread.Sleep(1000);
            }

            catch (Exception ex)
            {
                Assert.Fail("Mars Portal login page did not lanuch", ex.Message);
                throw;
            }

        }

    }
}
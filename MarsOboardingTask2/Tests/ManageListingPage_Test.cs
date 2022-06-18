using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Xml.Linq;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace MarsQA.Tests
{
    [TestFixture]
    internal class ManageListingPage_Test : CommmonDriver
    {       

        [Test,Order(1)]
        public void ShareSkill_Test()
        {
            ShareListingPage shareListingPageObj = new ShareListingPage();
            shareListingPageObj.ShareSkillsSteps(driver);
        }


        [Test,Order(2)]
        public void EditListing_Test()
        {;     
            
            SellerListingPage sellerListingPageObj= new SellerListingPage();
            sellerListingPageObj.EditListing(driver);           
        }


        [Test,Order(3)]
        public void ViewProfile_Test()
        {
            
            SellerListingPage sellerListingPageObj= new SellerListingPage();
            sellerListingPageObj.ViewListing(driver);
        }
    }
}

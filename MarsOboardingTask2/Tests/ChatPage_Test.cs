using AventStack.ExtentReports;
using MarsQA.Pages;
using MarsQA.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Tests
{
    [TestFixture]
    internal class ChatPage_Test : CommmonDriver
    {
               
        [Test,Order(1)]
        public void ViewProfile_Test()
        {
            ChatPage chatPageObj = new ChatPage();
            chatPageObj.ViewChatRoom(driver);
        }

        [Test,Order(2)]
        public void SendMessage_Test()
        {
            ChatPage chatPageObj = new ChatPage();
            chatPageObj.SendMessage(driver,"Hello");
        }
    }
}

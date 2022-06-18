using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Utilities
{
    public class GetScreenShot
    {
    
    /*internal class GetScreenShot
    {
        public static string SavePath = "C://TA Analyst/Mars-Competition-Task/Screenshots/";
        public static string[] Prints = new string[30];

        public static int cnt = 0, cntPrint = 0;

        public static string GetPath()
        {
            return SavePath;

        }

        public static void TakePrint(IWebDriver driver, string fileN)
        {

            cntPrint++;
            string screenPath = SavePath + fileN + cntPrint.ToString() + ".png";
            Screenshot screenPrint = ((ITakesScreenshot)driver).GetScreenshot();
            screenPrint.SaveAsFile(screenPath, ScreenshotImageFormat.Png);
            Prints[cntPrint] = (screenPath);


        }

        public static string GetPrintPath()
        {
            cnt++;
            return Prints[cnt];
        }

    }*/
} }


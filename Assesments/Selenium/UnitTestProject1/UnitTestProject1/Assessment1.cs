using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class Assessment1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver("C:\\Selenium");
            String requestedUrl = "https://www.google.com/";
            driver.Url= requestedUrl;
            String searchText = "DXC Technology";
            driver.FindElement(By.Name("q")).SendKeys(searchText);
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            String title = driver.Title;
            Console.WriteLine(title);
            String resultStats = driver.FindElement(By.Id("resultStats")).Text;
            Console.WriteLine(resultStats);
            Thread.Sleep(2000);
            driver.Close();

            if (title.Equals(searchText+" - Google Search"))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }

        }

       
    }
}

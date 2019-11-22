using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class Assessment2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"‪C:\Selenium", "geckodriver.exe");
            //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            //IWebDriver driver = new FirefoxDriver(service);
            IWebDriver driver = new ChromeDriver("C:\\Selenium");
            String requestedUrl = "http://www.youcandealwithit.com/";
            driver.Url = requestedUrl;
            driver.Manage().Window.Maximize();
            IWebElement toHover=  driver.FindElement(By.XPath("/html/body/div[1]/ul[2]/li[1]/a"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(toHover).Build().Perform();
                        
            String[] Clicks = new String[] { "Calculators & Resources", "Calculators", "Budget Calculator" };
            String[] Titles = new String[Clicks.Length];

            for (int i = 0; i < Clicks.Length; i++)
            {
                driver.FindElement(By.LinkText(Clicks[i])).Click();
                Titles[i] = driver.Title;
                Thread.Sleep(2000);
            }

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.Id("food")).SendKeys("5000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("clothing")).SendKeys("2000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("shelter")).SendKeys("10000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("monthlyPay")).SendKeys("4000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("monthlyOther")).SendKeys("5000");
            Thread.Sleep(5000);
            String MIncome = driver.FindElement(By.Id("totalMonthlyIncome")).GetAttribute("value");
            String MExpense = driver.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value");
            driver.Close(); 

            for (int i = 0; i < Clicks.Length; i++)
            {
                if (Titles[i].Equals(Clicks[i]+ " - YouCanDealWithIt"))
                {
                    Console.WriteLine($"{Clicks[i]} link : PASS");
                }
                else
                {
                    Console.WriteLine($"{Clicks[i]} link : FAIL");
                }
            }

            
            if(Convert.ToDouble(MIncome) >= Convert.ToDouble((MExpense)))
            {
                Console.WriteLine("OverBudget!");
            }
            else
            {
                Console.WriteLine("Underbudget!");
            }


            
        }
    }
}

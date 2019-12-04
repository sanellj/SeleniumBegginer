using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests1
{
    class Class1
    {
        IWebDriver driver;

        [Test]
        public void TestGoogleSearch()
        {
            System.Threading.Thread.Sleep(1500);
            driver.Navigate().GoToUrl("https://wwww.google.com/");
            System.Threading.Thread.Sleep(1000);
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys("C# selenium tests");
            System.Threading.Thread.Sleep(2000);
            searchField.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);
        }

        [SetUp]
        public void Init()
        {
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void Destroy()
        {
            driver.Close();
        }

    }
}

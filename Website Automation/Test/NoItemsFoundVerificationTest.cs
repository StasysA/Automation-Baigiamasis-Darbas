using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Automation.Test
{
    internal class NoItemsFoundVericationTest
    {
        [Test]

        public static void NoSearchResultTest()
        {
            string pepe = "pepe";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.vienpliusai.lt/";

            IWebElement selectorSearchBar = driver.FindElement(By.Id("main-search-input"));
            selectorSearchBar.Clear();
            selectorSearchBar.SendKeys(pepe);

            IWebElement selectorSearchbutton = driver.FindElement(By.Id("main-search-submit"));
            selectorSearchbutton.Click();

            IWebElement resultNoItemsFound = driver.FindElement(By.CssSelector("#middle_blocks > li > div"));
            Assert.AreEqual("Pagal Jūsų paieškos frazę prekių nerasta. Pabandykite ją patikslinti ir ieškoti dar kartą.", resultNoItemsFound.Text, "Wrong");





        }
    }
}

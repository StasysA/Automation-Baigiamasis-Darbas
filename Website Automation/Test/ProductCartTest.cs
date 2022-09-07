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
    internal class ProductCartTest
    {
        [Test]

        public static void CartTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.vienpliusai.lt/";

            IWebElement selectorTelefonams = driver.FindElement(By.CssSelector("#top_menu_link_1684 > span > a"));
            selectorTelefonams.Click();

            IWebElement selectorKrovikliai = driver.FindElement(By.ClassName("item_image_1770"));
            selectorKrovikliai.Click();

            IWebElement selectorTinkliniai = driver.FindElement(By.CssSelector("#block_catalogmenu_body > ul > li.item-id-1770.active > ul > li.item-id-1957.side-menu-last > a"));
            selectorTinkliniai.Click();

        }
    }
}

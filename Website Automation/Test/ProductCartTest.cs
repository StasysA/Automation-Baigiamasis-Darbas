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
            string quantity = "2";

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

            IWebElement selectorSamsung = driver.FindElement(By.Id("attr_216"));
            selectorSamsung.Click();

            IWebElement selectorApple = driver.FindElement(By.Id("attr_180"));
            selectorApple.Click();

            IWebElement selectorKroviklis = driver.FindElement(By.CssSelector("#middle_blocks > li > div.product-list.flex > div.grid_12.flex-item.product.product-simple.product-1945.item_hover_wrap_1945.alpha.item-line-first.hover-item.cp.mb10.item.zi1.product-item.item-list > div > div > div.item-info-container > a"));
            selectorKroviklis.Click();

            IWebElement selectorCartQTY = driver.FindElement(By.Id("add_to_cart_qty_1945"));
            selectorCartQTY.Clear();
            selectorCartQTY.SendKeys(quantity);

            IWebElement selectorAddToCartBtn = driver.FindElement(By.CssSelector("#addButton1945 > form > a"));
            selectorAddToCartBtn.Click();

            IWebElement selectorCartBtn = driver.FindElement(By.Id("cart-link"));
            selectorCartBtn.Click();

            IWebElement resultItem = driver.FindElement(By.CssSelector("#cart_form > div > table > tbody > tr:nth-child(4) > td.grid-29.prefix_1.pt5.pb5.hidden-xs > a"));
            Assert.AreEqual("Kroviklis USB Type-C: 220V, 45W Super Fast Samsung +++ TOP Kokybė", resultItem.Text, "Wrong Item");

            //IWebElement resultItemQTY = driver.FindElement(By.CssSelector("#cart_form > div > table > tbody > tr:nth-child(4) > td:nth-child(5) > div.fr.mr4 > input"));
            //Assert.AreEqual("2", resultItemQTY.Text, "Wrong Quantity");
            



        }
    }
}

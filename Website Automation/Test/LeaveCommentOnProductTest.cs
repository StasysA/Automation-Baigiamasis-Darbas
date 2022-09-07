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
    internal class LeaveCommentOnProductTest
    {
        [Test]

        public static void CommentTest()
        {
            string name = "Stasys";
            string email = "ugabuga@gmail.com";
            string comment = "Very Good!";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.vienpliusai.lt/";

            IWebElement selectorKompiuteriams = driver.FindElement(By.CssSelector("#top_menu_link_1683 > span > a"));
            selectorKompiuteriams.Click();

            IWebElement selectorPeles = driver.FindElement(By.ClassName("item_image_1806"));
            selectorPeles.Click();

            IWebElement selectorB100 = driver.FindElement(By.CssSelector("#middle_blocks > li > div.product-list.flex > div.grid_12.flex-item.product.product-simple.product-1017.item_hover_wrap_1017.omega.item-line-last.hover-item.cp.mb10.item.zi1.product-item.item-list > div > div > div.vv > div > a > span"));
            selectorB100.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            IWebElement selectorAtsiliepimas = driver.FindElement(By.CssSelector("#tab_comments > a > strong"));
            selectorAtsiliepimas.Click();

            IWebElement selectorSubmitComment = driver.FindElement(By.CssSelector("#comment_textarea_holder > div.submit-container.mt10 > a > strong"));
            selectorSubmitComment.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement resultPrivalomasVardas = driver.FindElement(By.CssSelector("#comment_textarea_holder > div:nth-child(2) > em"));
            Assert.AreEqual("Laukelis privalomas.", resultPrivalomasVardas.Text, "Answer is wrong");

            IWebElement resultPrivalomasEmail = driver.FindElement(By.CssSelector("#comment_textarea_holder > div:nth-child(3) > em"));
            Assert.AreEqual("Laukelis privalomas.", resultPrivalomasEmail.Text, "Answer is wrong");

            IWebElement resultPrivalomasTekstas = driver.FindElement(By.CssSelector("#comment_textarea_holder > div:nth-child(4) > em"));
            Assert.AreEqual("Laukelis privalomas.", resultPrivalomasTekstas.Text, "Answer is wrong");

            IWebElement inputName = driver.FindElement(By.Name("name"));
            inputName.SendKeys(name);

            IWebElement inputEmail = driver.FindElement(By.Name("email"));
            inputEmail.SendKeys(email);

            IWebElement inputComment = driver.FindElement(By.Id("comment_textarea"));
            inputComment.SendKeys(comment);

            IWebElement inputRate = driver.FindElement(By.CssSelector("#comment_form > div.mb10 > div.grid_32 > ul > li:nth-child(5)"));
            inputRate.Click();
        }
    }
}

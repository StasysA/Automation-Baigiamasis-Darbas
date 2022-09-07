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
    internal class RegistrationTestPasswordNotMatch
    {
        [Test]

        public static void RegTest()
        {
            string email = "pepega@gmail.com";
            string name = "Pepe";
            string pass = "pepega";
            string notPass = "notPepea";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            driver.Url = "https://www.vienpliusai.lt/";

            IWebElement selectorRegButton = driver.FindElement(By.Id("login_fly_on"));
            selectorRegButton.Click();

            IWebElement selectorNewRegButton = driver.FindElement(By.CssSelector("#login_form_modal > div > div > a.register-now-btn.fl.a0.mt20"));
            selectorNewRegButton.Click();

            IWebElement selectorEmail = driver.FindElement(By.Id("physical_email"));
            selectorEmail.SendKeys(email);

            IWebElement selectorName = driver.FindElement(By.Id("physical_name"));
            selectorName.SendKeys(name);

            IWebElement selectorPassword = driver.FindElement(By.Id("physical_password"));
            selectorPassword.SendKeys(pass);

            IWebElement selectorPasswordRepeat = driver.FindElement(By.Id("physical_repeat_password"));
            selectorPasswordRepeat.SendKeys(notPass);

            IWebElement selectorAgree = driver.FindElement(By.CssSelector("#physical_register_form > div.mt10.grid_28.alpha.omega > a > strong"));
            selectorAgree.Click();

            IWebElement resultPasswordDoesNotMatch = driver.FindElement(By.CssSelector("#physical_register_form > div.grid_58.alpha.omega.bc > div > div.grid_14.omega.mt15 > em"));
            Assert.AreEqual("Įveskite tą pačią reikšmę dar kartą.", resultPasswordDoesNotMatch.Text, "Wrong Message");

        }
    }
}

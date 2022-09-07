using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.Page
{
    public class VieniPliusaiMain : BasePage
    {
        private const string PageAddress = "https://www.vienpliusai.lt/";

        private IWebElement _searchBar => Driver.FindElement(By.Id("main-search-input"));
        private IWebElement _searchSubmit => Driver.FindElement(By.Id("main-search-submit"));
        private IWebElement _searchResult => Driver.FindElement(By.ClassName("fwb"));

        public VieniPliusaiMain(IWebDriver webdriver) : base(webdriver) { }

        public VieniPliusaiMain NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }

            return this;
        }

        public VieniPliusaiMain SearchBar(string searchValue)
        {
            _searchBar.Clear();
            _searchBar.SendKeys(searchValue);

            return this;
        }

        public VieniPliusaiMain ClickSearchSubmit()
        {
            _searchSubmit.Click(); 
            

            return this;
        }


        

        public VieniPliusaiMain VerifyResult(string result)
        {
            Assert.AreEqual(result, _searchResult, "ERROR");

            return this;
        }
    }
}
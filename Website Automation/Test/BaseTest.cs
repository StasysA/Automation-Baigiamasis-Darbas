


using draft.Drivers;
using draft.Page;
using draft.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace draft.Test
{
    public class BaseTest
    {
        protected static IWebDriver Driver;

        public static VieniPliusaiMain vieniPliusaiMain;

        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            vieniPliusaiMain = new VieniPliusaiMain(Driver);
        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(Driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Quit();
        }
    }
}
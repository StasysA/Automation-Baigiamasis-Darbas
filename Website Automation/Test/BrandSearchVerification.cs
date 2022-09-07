
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.Test
{
    class BrandSearchVerification : BaseTest
    {
        [TestCase("Acer", "Acer", TestName = "Acer")]
        [TestCase("Nell", "Dell", TestName = "Nell")]
        [TestCase("Dell", "Dell", TestName = "Dell")]
        [TestCase("Toshiba", "Toshiba", TestName = "Toshiba")]




        public static void TestBrand(string searchValue, string result)
        {
            


            vieniPliusaiMain.NavigateToDefaultPage()
                .SearchBar(searchValue)
                .ClickSearchSubmit()
                .VerifyResult(result);




        }

    }
}
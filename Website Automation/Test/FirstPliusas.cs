
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.Test
{
    class FirstPliusas : BaseTest
    {
        [TestCase("Acer", TestName = "Acer")]
        [TestCase("Dell", TestName = "Dell")]



        public static void TestBrand(string searchValue, string result)
        {
            


            vieniPliusaiMain.NavigateToDefaultPage()
                .SearchBar(searchValue)
                .ClickSearchSubmit()
                .VerifyResult(result);




        }

    }
}
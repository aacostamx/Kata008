using System;
using Xunit;
using Kata008;
using System.Threading.Tasks;

namespace Kata008.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Get_URL_from_App_Settings()
        {
            string url = Program.GetURL();

            Assert.NotNull(url);
        }


        [Fact]
        public void Get_Call_Async()
        {
            string url = "https://www.google.com";

            Task result = Program.GetCallAsync(url);

            Assert.NotNull(result);
        }
    }
}

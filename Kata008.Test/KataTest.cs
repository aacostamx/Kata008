using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Kata008.Test
{
    public class KataTest
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
            string url = "http://aacosta.com.mx/";

            Task<HttpStatusCode> task = Program.GetCallAsync(url);

            Assert.NotNull(task);
            Assert.Equal(HttpStatusCode.OK, task.Result);
        }
    }
}

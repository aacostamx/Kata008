using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kata008
{
    class Program
    {
        private static HttpClient _client = new HttpClient();
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            try
            {
                var result = await _client.GetAsync("https://www.google.com");
                Console.WriteLine(result.StatusCode);
            } catch
            {
                throw;
            }
           
        }
    }
}

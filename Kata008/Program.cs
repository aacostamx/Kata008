using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Kata008
{
    public static class Program
    {
        private static readonly HttpClient _client = new HttpClient();
        static async Task Main(string[] args)
        {
            try
            {
                string url = GetURL();
                await GetCallAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static string GetURL()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            IConfigurationRoot config = builder.Build();

            return config.GetSection("AppConfig").GetSection("url").Value;
        }

        public static async Task GetCallAsync(string url)
        {
            HttpResponseMessage result = await _client.GetAsync(url);
            Console.WriteLine(result.StatusCode);
        }
    }
}

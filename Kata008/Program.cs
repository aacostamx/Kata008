using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
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
                HttpStatusCode result = await GetCallAsync(url);
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine($"Error calling web service");
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

        public static async Task<HttpStatusCode> GetCallAsync(string url)
        {
            HttpResponseMessage result = await _client.GetAsync(url);
            return result.StatusCode;
        }
    }
}

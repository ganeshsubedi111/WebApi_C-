using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestWebApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://fakestoreapi.com/products");

            if (response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Message from Web API: " + message);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }

            Console.ReadLine();
        }
    }
}
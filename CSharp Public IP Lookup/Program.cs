using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("--- Public IP Lookup ---\n");

        using var client = new HttpClient();

        try
        {
            var endpoint = "https://api.ipify.org?format=json";
            var response = await client.GetAsync(endpoint);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Request failed: " + response.StatusCode);
                return;
            }

            var body = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response:");
            Console.WriteLine(body);
            Console.WriteLine("\nCompleted at: " + DateTime.Now);
        }
        catch (Exception err)
        {
            Console.WriteLine("Error: " + err.Message);
        }
    }
}

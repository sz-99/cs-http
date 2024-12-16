using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cs_http
{
    public class APICalls
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static string url = "https://fakerapi.it/api/v1/books";
        public static async Task<Response> GetBooksAsync()
        {
            try
            {
                using HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(responseBody))
                {
                    return JsonSerializer.Deserialize<Response>(responseBody);
                }
                else
                {
                    Console.WriteLine("Could not be deserialized");
                    return null;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

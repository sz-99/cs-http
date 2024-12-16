using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cs_http
{
    public class APICallsFlight
    {
        public static readonly HttpClient httpClient = new HttpClient();
        public static string url = "https://api.schiphol.nl/public-flights/flights";
        private static readonly string appId = "126c8617";
        private static readonly string appKey = "0100a4eba0cc93caa1460b58049531d4";

        public static async Task<ResponseFlight> GetFlightAsync()
        {

            try
            {
                httpClient.DefaultRequestHeaders.Add("app_id", appId);
                httpClient.DefaultRequestHeaders.Add("app_key", appKey);
                    httpClient.DefaultRequestHeaders.Add("ResourceVersion", "v4");
                using HttpResponseMessage response = await httpClient.GetAsync(url);
               
                //httpClient.DefaultRequestHeaders.Add("ResourceVersion", "v4");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(responseBody))
                {
                    return JsonSerializer.Deserialize<ResponseFlight>(responseBody);
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

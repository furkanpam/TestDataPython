using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Vanguard.WebApi
{

        public class ApiTestService
    {
            private readonly HttpClient _httpClient;
            private readonly string _apiKey;

            public ApiTestService(HttpClient httpClient, IConfiguration configuration)
            {
                _httpClient = httpClient;
                _apiKey = configuration["ApiTestServiceApiKey"]; // API anahtarını appsettings.json'dan alacağız
            }

            public async Task<decimal> GetAccountAsync(string channel, string language)
            {
                string url = $"https://v6.exchangerate-api.com/v6/{_apiKey}//{channel}";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(jsonResponse);
                    var rates = data["conversion_rates"];
                    //decimal rate = rates[accountData].Value<decimal>();
                    return 0;
                }
                else
                {
                    throw new Exception("API isteği başarısız oldu.");
                }
            }
        }
    }




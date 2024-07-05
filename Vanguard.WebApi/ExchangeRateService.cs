using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Vanguard.WebApi
{

        public class ExchangeRateService
        {
            private readonly HttpClient _httpClient;
            private readonly string _apiKey;

            public ExchangeRateService(HttpClient httpClient, IConfiguration configuration)
            {
                _httpClient = httpClient;
                _apiKey = configuration["ExchangeRateApiKey"]; // API anahtarınızı appsettings.json'dan alacağız
            }

            public async Task<decimal> GetExchangeRateAsync(string baseCurrency, string targetCurrency)
            {
                string url = $"https://v6.exchangerate-api.com/v6/{_apiKey}/latest/{baseCurrency}";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(jsonResponse);
                    var rates = data["conversion_rates"];
                    decimal rate = rates[targetCurrency].Value<decimal>();
                    return rate;
                }
                else
                {
                    throw new Exception("API isteği başarısız oldu.");
                }
            }
        }
    }




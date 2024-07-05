    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;

namespace Vanguard.WebApi
{

        public class WeatherService
        {
            private readonly HttpClient _httpClient;
            private readonly string _apiKey = "c9a52c7be5dcb7d853948295553a4bd6"; 

            public WeatherService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<JObject> GetWeatherAsync(string city)
            {
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(jsonResponse);
                    return data;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API isteği başarısız oldu. Status Code: {response.StatusCode}, Response: {errorResponse}");
                }
            }
        }
    }



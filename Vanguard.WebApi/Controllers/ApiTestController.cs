using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Vanguard.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTestController : ControllerBase
    {
        private readonly HttpClient httpClient;

        public ApiTestController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetExternalData()
        {
            var response = await httpClient.GetAsync("https://apitest.albarakaturk.com.tr/api");

            if (response is not null)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(data);
            }
            return BadRequest();
        }
    }
}
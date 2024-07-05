using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Vanguard.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        public class ExchangeRateController : ControllerBase
        {
            private readonly ExchangeRateService _exchangeRateService;

            public ExchangeRateController(ExchangeRateService exchangeRateService)
            {
                _exchangeRateService = exchangeRateService;
            }

            [HttpGet("{baseCurrency}/{targetCurrency}")]
            public async Task<IActionResult> GetExchangeRate(string baseCurrency, string targetCurrency)
            {
                try
                {
                    decimal rate = await _exchangeRateService.GetExchangeRateAsync(baseCurrency, targetCurrency);
                    return Ok(new { BaseCurrency = baseCurrency, TargetCurrency = targetCurrency, Rate = rate });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = ex.Message });
                }
            }
        }
    }



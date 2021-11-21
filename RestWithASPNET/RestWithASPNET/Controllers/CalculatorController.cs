using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET.Service;
using RestWithASPNET.Service.Helper;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{operation}/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string operation, string firstNumber, string secondNumber)
        {
            var calculatorService = new CalculatorService();

            var result = calculatorService.Calculate(operation, firstNumber, secondNumber);

            if (CalculatorHelper.IsNumeric(result))
            {
                return Ok(result.ToString());
            }

            return BadRequest(result);
        }
    }
}

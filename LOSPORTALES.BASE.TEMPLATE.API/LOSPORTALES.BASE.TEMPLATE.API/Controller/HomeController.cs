
using Microsoft.AspNetCore.Mvc;

namespace LOSPORTALES.BASE.TEMPLATE.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("GetString")]
        public string Get() 
        {
            _logger.LogDebug( "Mensaje de Debug");
            _logger.LogInformation(message: "Mensaje de Informacion");
            _logger.LogWarning(message: "Mensaje de Warnig");
            _logger.LogError(message: "Mensaje de Error");


            return "Demo Application";
        }
    }
}

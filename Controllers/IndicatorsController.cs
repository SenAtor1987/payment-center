using Microsoft.AspNetCore.Mvc;


namespace payment_center_3.Controllers
{
    public class IndicatorsController : Controller
    {
        private readonly ILogger<IndicatorsController> _logger;

        public IndicatorsController(ILogger<IndicatorsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Water()
        {
            return View();
        }

        public IActionResult Ligth()
        {
            return View();
        }

        public IActionResult Gas()
        {
            return View();
        }
    }
}
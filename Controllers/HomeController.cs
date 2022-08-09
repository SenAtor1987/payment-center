using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace payment_center_3.Controllers
{
    [Authorize(Roles = "User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using project.Models;
using project.Repository;
using System.Diagnostics;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _iuserRepository;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, IUserRepository iuserRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _iuserRepository = iuserRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserAccount model)
        {
            var result = _iuserRepository.UserRegi(model);
            if (result > 0)
            {
                ViewBag.Message = "Data saved successfully";
            }
            else
            {
                ViewBag.Message = "Something went wrong";
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
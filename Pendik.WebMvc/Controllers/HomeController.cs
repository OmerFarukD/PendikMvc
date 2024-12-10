using Microsoft.AspNetCore.Mvc;
using Pendik.WebMvc.Models;
using System.Diagnostics;

namespace Pendik.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            TempData["deðer1"] = "deðer1";
            ViewData["deðer2"] = "deðer2";
           
            return View();
        }

        public IActionResult Temp()
        {

            List<User> users = new List<User>
            {
                new User {Age=25,Name="Umut",Surname="Özgenç"},
                  new User {Age=25,Name="Umut 1",Surname="Özgenç"},
                    new User {Age=25,Name="Umut 2",Surname="Özgenç"},
            };
            return View(users);
        }


        public IActionResult Deneme()
        {
            var value1 = TempData["deðer1"];
            var value2 = ViewData["deðer2"];


            ViewBag.Value1 = value1;
            ViewBag.Value2 = value2;


            return View();
        }


        public IActionResult Example()
        {
            User user = new User
            {
                Name = "Mehmet Nuri",
                Surname = "Hakký Abi",
                Age = 25
            };


            // ViewData Yöntemi ile görünüme veri aktarma yöntemi.
            ViewData["user"] = user;

            ViewBag.Email = "mehmet_baba_55_cezaevi@gmail.com";

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

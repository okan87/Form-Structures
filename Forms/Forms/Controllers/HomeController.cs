using Forms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public string course = "Software development with Asp.Net";
        public String instructor = "Okan Kaplan";
        public string location = "Hoorn";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //string course = "Software development with Asp.Net";
            //ViewBag.Course = course;
            ViewBag.Course = "Software development with Asp.Net";
            ///* Bu sekilde de kullanim mevcuttur.*/
            //string location = "Hoorn";
            //Using TempData
            TempData["Location"] = location;
            ViewData["Instructor"] = instructor;

            return View();
        }

        public IActionResult Privacy()
        {
            //String instructor = "Okan Kaplan";
            ViewData["Instructor"] = instructor;
            /*ViewData["Instructor"] = "Okan Kaplan";*/
            /* Bu sekilde de kullanim mevcuttur.*/
            return View();
        }

        [HttpGet]//Default
        public IActionResult GetData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetData(ReceievedData receievedData)
        {
            if(ModelState.IsValid)
            {
                ViewBag.data = receievedData.Yazi;
            }
            else
            {
                ViewBag.Error = "Please fill up the text";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
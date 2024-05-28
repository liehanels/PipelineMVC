using Microsoft.AspNetCore.Mvc;
using PipelineMVC.Models;
using System.Diagnostics;

namespace PipelineMVC.Controllers
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
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number one : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number two : ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(addition(num1, num2));
            }
            static string addition(int num1, int num2)
            {
                int answer = num1 + num2;
                return "The answer is " + num1 + " + " + num2 + " = " + answer;
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

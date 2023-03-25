using IntegrateAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace IntegrateAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //List<Employee>? employees = new List<Employee>();    
            //HttpClient client = new HttpClient();
            //Employee employee = new Employee();
            //HttpResponseMessage response = await client.GetAsync("https://localhost:7146/api/contact/getall");
            //if (response.IsSuccessStatusCode)
            //{
            //    var responseAsString = await response.Content.ReadAsStringAsync();
            //    employees = JsonConvert.DeserializeObject<List<Employee>>(responseAsString);
            //}
            //return View(employees);
            return View(new List<Employee>());
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
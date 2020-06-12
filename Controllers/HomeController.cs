using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string message = new string("Enjoy the journey, and take it easy, Kim");          
            // string message = "Enjoy the journey, and take it easy, Kim";          
            
            return View("Index",message);
        }
        
        [HttpGet("numbers")]
        public IActionResult numbers()
        {
            int[] numbers = {1,89,6,9,2,6,5,62,6,3};

            return View(numbers);
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


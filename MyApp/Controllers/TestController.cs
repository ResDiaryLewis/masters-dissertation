using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class TestController : Controller
    {
        private int counter = 0;

        public IActionResult Index()
        {
            return View();
        }

        [ActionName("Find")]
        public IActionResult Find()
        {
            return View();
        }

        [ActionName("Click")]
        public void Click()
        {
            counter += 1;
            Debug.WriteLine("Counter: " + counter);
        }
    }
}

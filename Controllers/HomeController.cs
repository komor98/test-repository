using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestGit1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // first change
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}

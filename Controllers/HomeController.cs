using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DinucMVC.Models;

namespace DinucMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnterSeq()
        {
            return View();
        }

        public IActionResult EnterGBSeq()
        {
            Sequence sequence = new Sequence();
            sequence.Seq = "aaacagatcacccgctgagcgggttatctgtt";
            ViewBag.Seq = sequence.Seq;

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

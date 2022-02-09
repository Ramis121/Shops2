using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shops2.Data;
using Shops2.Model;
using Shops2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shops2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.phone.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id) 
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.phoneid = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order order)
        {
            context.companie.Add(order);
            context.SaveChanges();
            return $"Спасибо {order.user}, за покупку";
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

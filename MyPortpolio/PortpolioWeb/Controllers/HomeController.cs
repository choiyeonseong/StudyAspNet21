using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortpolioWeb.Data;
using PortpolioWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortpolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PortpolioWebContext _context;

        public HomeController(ILogger<HomeController> logger, PortpolioWebContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var profile = _context.Manage.FirstOrDefault(p => p.Cate.Equals("Profile"));   // 2건 이상이라도 처음것만

            return View(profile);
        }

        public IActionResult Portpolio()
        {
            var portpolio = _context.Manage.FirstOrDefault(p => p.Cate.Equals("Portpolio"));   // 2건 이상이라도 처음것만

            return View(portpolio);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Board()
        {
            return View();
        }

        public IActionResult Login()
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

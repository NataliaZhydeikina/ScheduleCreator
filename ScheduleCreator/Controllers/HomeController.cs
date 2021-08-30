using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScheduleCreator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleCreator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ScheduleContext _context;
        public HomeController(ILogger<HomeController> logger, ScheduleContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Schedules"] = _context.Schedules.ToList<Schedule>();
            return View(_context.Lessons.ToList<Lesson>());
        }

        public IActionResult Contacts()
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

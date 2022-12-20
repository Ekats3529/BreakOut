using Interfaces;
using LessonApplication.Models;
using Entities;
using LessonApplication.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LessonApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUsersBL _usersBL;
        private IGamesBL _gamesBL;

        public HomeController(ILogger<HomeController> logger, IUsersBL usersBL, IGamesBL gamesBL)
        {
            _logger = logger;
            _usersBL = usersBL;
            _gamesBL = gamesBL;
        }

        [Authorize]
        public IActionResult Index(int id, string name)
        {
            TempData["Success"] = "Success";

            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
            }

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return Json(new { Id = 3529, Name = "Ekaterina" });
        }

        public IActionResult Scoreboard()
        {
            return View("Scoreboard");
        }

        public IActionResult Info() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Game()
        {

            return View("Game");

        }  

    }
}

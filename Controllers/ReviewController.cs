using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreExample3.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreExample3.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public IActionResult Create(string gameName)
        {
            ViewData["game"] = gameName;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review, string gameName)
        {
            var game = Game.Read(gameName);
            game.AddReviewToGame(review);
            return RedirectToAction("Index", "Game");
        }
    }
}

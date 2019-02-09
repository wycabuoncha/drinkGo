using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using drinkGo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using drinkGo.Models;

namespace drinkGo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _iDrinkRepository;
        private readonly ICategoryRepository _iCategoryRepository;

        public HomeController(IDrinkRepository iDrinkRepository, ICategoryRepository iCategoryRepository)
        {
            _iDrinkRepository = iDrinkRepository;
            _iCategoryRepository = iCategoryRepository;
        }


        public IActionResult Index()
        {
            var drinks = _iDrinkRepository.Drinks;
            return View(drinks);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

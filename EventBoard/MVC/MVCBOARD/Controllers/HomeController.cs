using BussinesLayer.Interfaces;
using BussinesLayer.Models;
using EventBoardDataAccess.DataBase;
using EventBoardDataAccess.DataBase.Models;
using Microsoft.AspNetCore.Mvc;
using MVCBOARD.Models;
using System.Diagnostics;

namespace MVCBOARD.Controllers
{
    public class HomeController : Controller
    {

      
        private readonly ILogger<HomeController> _logger;
      

        public IActionResult Index()
        {
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
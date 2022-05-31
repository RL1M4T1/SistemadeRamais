using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemadeRamais.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemadeRamais.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.colaborador = "Rodrigo Lima";
            home.setor = "DEPIN";

            return View(home);
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

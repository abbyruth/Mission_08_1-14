using Microsoft.AspNetCore.Mvc;
using Mission_08_1_14.Models;
using System.Diagnostics;

namespace Mission_08_1_14.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }

}

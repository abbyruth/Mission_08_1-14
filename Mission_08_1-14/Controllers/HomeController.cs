using Microsoft.AspNetCore.Mvc;
using Mission_08_1_14.Models;
using System.Diagnostics;

namespace Mission_08_1_14.Controllers
{
    public class HomeController : Controller
    {
        private ITaskListRepository _repo;
        public HomeController(ITaskListRepository temp) => _repo = temp;

        public IActionResult Index()
        {
            return View();
        }
    }

}

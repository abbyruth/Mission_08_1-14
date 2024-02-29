using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var records = _repo.Tasks
               .Include("Category") // Include the table "Category" in our results (to get the CategoryName to display)
               .ToList();

            return View(records);
        }

        [HttpGet]
        public IActionResult DbTest() {
            var records = _repo.Tasks
                .Include("Category") // Include the table "Category" in our results (to get the CategoryName to display)
                .ToList();

            return View(records); 
        }
    }

}

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

        
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskItem t)
        {
            
            var taskToDelete = _repo.Tasks.SingleOrDefault(x => x.TaskId == t.TaskId);

            if (taskToDelete == null)
            {
                return NotFound(); // Or handle the case where the task is not found
            }

            if (ModelState.IsValid)
            {
                _repo.RemoveTask(taskToDelete);
                return RedirectToAction("Index");
            }

            return View("Index");
        }
    }

}

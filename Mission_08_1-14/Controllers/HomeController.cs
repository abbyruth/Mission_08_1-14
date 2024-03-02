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
            
            // var taskToDelete = _repo.Tasks.SingleOrDefault(x => x.TaskId == t.TaskId);
            
             _repo.RemoveTask(t);
             return RedirectToAction("Index");
            

            //return View("Index");
        }

        [HttpGet]
        public IActionResult TaskAddEdit(int? id)
        {
            if (id.HasValue)
            {
                var task = _repo.Tasks.SingleOrDefault(x => x.TaskId == id.Value);
                if (task == null)
                {
                    return NotFound(); // Or handle the case when the task is not found
                }

                var categories = _repo.Categories.ToList(); // Fetch categories from the database
                ViewBag.Categories = categories;
                return View(task); // Pass the task item to the view to populate the form
            }
            else
            {
                var categories = _repo.Categories.ToList();
                ViewBag.Categories = categories;
                return View(new TaskItem());
            }
        }


        [HttpPost]
        public IActionResult TaskAddEdit(TaskItem t)
        {
            if (ModelState.IsValid) 
            {
                if (t.TaskId == null)
                {
                    // Add new task
                    _repo.AddTask(t);
                }
                else
                {
                    // Update existing task

                    _repo.UpdateTask(t);
                }
                return RedirectToAction("Index");
            }
            else 
            {
                var categories = _repo.Categories.ToList(); // Fetch categories from the database
                ViewBag.Categories = categories;
                return View(t);
            }
            
           
        }

    }

}

using System.Threading.Tasks;

namespace Mission_08_1_14.Models {
    public class EFTaskListRepository : ITaskListRepository
    {
        private TaskListContext _taskListContext;

        public EFTaskListRepository(TaskListContext tempContext) => _taskListContext = tempContext;


        // Task Methods
        public IQueryable<TaskItem> Tasks => _taskListContext.Tasks;
        public void AddTask(TaskItem task) { 
            _taskListContext.Add(task); 
            _taskListContext.SaveChanges(); 
        }
        public void UpdateTask(TaskItem task) { 
            _taskListContext.Update(task); 
            _taskListContext.SaveChanges(); 
        }
        public void RemoveTask(TaskItem task) { 
            _taskListContext.Remove(task); 
            _taskListContext.SaveChanges(); 
        }

        // Category Methods
        public IQueryable<Category> Categories => _taskListContext.Categories;
        public void AddCategory(Category category) { 
            _taskListContext.Add(category); 
            _taskListContext.SaveChanges(); 
        }
        public void UpdateCategory(Category category) { 
            _taskListContext.Update(category); 
            _taskListContext.SaveChanges(); 
        }
        public void RemoveCategory(Category category) { 
            _taskListContext.Remove(category); 
            _taskListContext.SaveChanges(); 
        }
    }
}

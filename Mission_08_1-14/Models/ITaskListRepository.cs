namespace Mission_08_1_14.Models {
    public interface ITaskListRepository {
        // Task Methods
        IQueryable<TaskItem> Tasks { get; }
        public void AddTask(TaskItem task);
        public void UpdateTask(TaskItem task);
        public void RemoveTask(TaskItem task);

        // Category Methods
        IQueryable<Category> Categories { get; }
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void RemoveCategory(Category category);

    }
}

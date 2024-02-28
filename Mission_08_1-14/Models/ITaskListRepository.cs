namespace Mission_08_1_14.Models {
    public interface ITaskListRepository {
        // Task Methods
        IQueryable<Task> Tasks { get; }
        public void AddTask(Task task);
        public void UpdateTask(Task task);
        public void RemoveTask(Task task);

        // Category Methods
        IQueryable<Category> Categories { get; }
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);
        public void RemoveCategory(Category category);

    }
}

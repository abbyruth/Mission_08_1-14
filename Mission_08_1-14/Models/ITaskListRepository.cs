namespace Mission_08_1_14.Models {
    public interface ITaskListRepository {
        // Task Methods
        public void AddTask(Task task);
        public void RemoveTask(Task task);

        // Category Methods
        public void AddCategory(Category category);
        public void RemoveCategory(Category category);

    }
}

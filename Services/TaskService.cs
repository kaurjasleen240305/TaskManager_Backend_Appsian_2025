using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new();

        public IEnumerable<TaskItem> GetAll() => _tasks;

        public TaskItem? GetById(Guid id) => _tasks.FirstOrDefault(t => t.Id == id);

        public TaskItem Add(CreateTaskRequest request)
        {
            var newTask = new TaskItem
            {
                Description = request.Description,
                IsCompleted = request.IsCompleted
            };
            newTask.GenerateId();

            _tasks.Add(newTask);
            return newTask;
        }

        public TaskItem? Update(Guid id, TaskItem updated)
        {
            var existing = GetById(id);
            if (existing is null) return null;

            existing.Description = updated.Description;
            existing.IsCompleted = updated.IsCompleted;
            return existing;
        }

        public bool Delete(Guid id)
        {
            var task = GetById(id);
            if (task is null) return false;
            _tasks.Remove(task);
            return true;
        }
    }
}

namespace TaskManager.Models
{
    public class CreateTaskRequest
    {
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
    }
}
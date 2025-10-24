namespace TaskManager.Models
{
    public class TaskItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;

        // Allow manual Id generation on creation
        public void GenerateId()
        {
            Id = Guid.NewGuid();
        }
    }
}
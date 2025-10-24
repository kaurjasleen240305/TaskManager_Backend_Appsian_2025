using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Endpoints
{
    public static class TaskEndpoints
    {
        public static void MapTaskEndpoints(this WebApplication app)
        {
            app.MapGet("/api/tasks", (TaskService service) =>
            {
                return Results.Ok(service.GetAll());
            });

            app.MapPost("/api/tasks", (CreateTaskRequest request, TaskService service) =>
            {
                var newTask = service.Add(request);
                return Results.Created($"/api/tasks/{newTask.Id}", newTask);
            });

            app.MapPut("/api/tasks/{id}", (Guid id, TaskItem updatedTask, TaskService service) =>
            {
                var updated = service.Update(id, updatedTask);
                return updated is not null ? Results.Ok(updated) : Results.NotFound();
            });

            app.MapDelete("/api/tasks/{id}", (Guid id, TaskService service) =>
            {
                return service.Delete(id) ? Results.NoContent() : Results.NotFound();
            });
        }
    }
}

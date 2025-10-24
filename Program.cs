using TaskManager.Services;
using TaskManager.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<TaskService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Register the endpoints
app.MapTaskEndpoints();

app.Run();

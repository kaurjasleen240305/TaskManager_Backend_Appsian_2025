using TaskManager.Services;
using TaskManager.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<TaskService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy => {
        policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");

app.MapTaskEndpoints();

app.Urls.Add("http://0.0.0.0:" + Environment.GetEnvironmentVariable("PORT"));

app.Run();

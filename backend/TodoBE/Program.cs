using System.IO;
using System.Text.Json;
using TodoBE;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAllOrigins");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

string filePath = Path.Combine(Directory.GetCurrentDirectory(), "todolist.json");

List<TodoItem> ReadTodosFromFile()
{
    if (!File.Exists(filePath))
    {
        return new List<TodoItem>();
    }

    var jsonString = File.ReadAllText(filePath);
    Console.WriteLine(jsonString);
    var todoItems = JsonSerializer.Deserialize<List<TodoItem>>(jsonString) ?? new List<TodoItem>();
    for (int i = 0; i < todoItems.Count; i++)
    {
        todoItems[i].id = i;
    }
    return todoItems;
}

void WriteTodosToFile(List<TodoItem> todoItems)
{
    var jsonString = JsonSerializer.Serialize(todoItems, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filePath, jsonString);
}


List<TodoItem> todoItems = ReadTodosFromFile();

app.MapGet("/todos/{list?}", (string? list) =>
{
    var filteredItems = string.IsNullOrEmpty(list)
        ? todoItems
        : todoItems.Where(item => item.List == list).ToList();
    return Results.Ok(filteredItems);
}).WithName("GetTodoItems").WithOpenApi();

app.MapPost("/todos", (TodoItem newTodoItem) =>
{
    newTodoItem.id = todoItems.Count;
    todoItems.Add(newTodoItem);
    WriteTodosToFile(todoItems);
    return Results.Created($"/todos/{newTodoItem.id}", newTodoItem);
}).WithName("PostTodoItems").WithOpenApi();



app.MapPut("/todos/{id}", (int id, TodoItem updatedTodoItem) =>
{
    var todoIndex = todoItems.FindIndex(t => t.id == id);
    
    if (todoIndex == -1)
    {
        return Results.NotFound();
    }

    var existingTodo = todoItems[todoIndex];
    existingTodo.Title = updatedTodoItem.Title;
    existingTodo.Description = updatedTodoItem.Description;
    existingTodo.DueDate = updatedTodoItem.DueDate;
    existingTodo.List = updatedTodoItem.List;

    WriteTodosToFile(todoItems);
    return Results.Ok(existingTodo);
}).WithName("PutTodoItems").WithOpenApi();



app.Run();

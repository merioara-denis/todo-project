var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1",
        new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Title = "Todo",
            Version = "v1"
        }
     );
    options.EnableAnnotations();

    string filePath = Path.Combine(System.AppContext.BaseDirectory, "Todo.xml");
    options.IncludeXmlComments(filePath);

    options.UseOneOfForPolymorphism();
});

builder.Services.AddTransient<Services.ITodo, Services.Todo>();
builder.Services.AddSingleton<Database.ITableTodo, Database.TableTodo>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

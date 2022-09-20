using System.Reflection;
using System.Runtime.Intrinsics;
using FigureAreaCalc.Lib.Service;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo()
    {
        Version = "v1",
        Title = "Api расчета площадей фигур",
        Description = "Данный Api представляет собой реализацию тестового задания",
        Contact = new OpenApiContact()
        {
            Name = "Тестовое задание",
            Url = new Uri("https://github.com/chuvakov/FigureAreaCalc")
        }
    });
    
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

#region DI
builder.Services.AddTransient<ICalcService, CalcService>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
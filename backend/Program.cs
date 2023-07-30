using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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


[Route("api/anar")]
[ApiController]
public class DataController : ControllerBase
{
    [HttpGet]
    public IActionResult GetData()
    {
        // Replace this with your actual data that you want to send to Unity
        var dataToSend = new {
            message = "Hello Unity!",
            value = 42
        };

        // Return the data in JSON format
        return Ok(dataToSend);
    }
}

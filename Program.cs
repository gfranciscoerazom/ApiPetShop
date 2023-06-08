using ApiPetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<AppEFContext>(p => p.UseInMemoryDatabase("AppEfDb"));
// builder.Services.AddSqlServer<AppEFContext>("Data Source=GFRANCISCOERAZO; Initial Catalog = AppEfDb;Trusted_Connection=True; Integrated Security=True;TrustServerCertificate=True");
// builder.Services.AddSqlServer<AppEFContext>(builder.Configuration.GetConnectionString("cnAppEf"));
builder.Services.AddNpgsql<AppEFContext>(builder.Configuration.GetConnectionString("cnAppEf"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.MapGet("/dbconexion", async ([FromServices] AppEFContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.MapPost("/dbconexion/cliente", async([FromServices] AppEFContext dbContext, [FromBody] Cliente cliente) =>
{
    dbContext.Clientes.Add(cliente);
    dbContext.SaveChanges();
    return Results.Ok("Cliente agregado");
});

app.Run();

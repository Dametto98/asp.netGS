using Microsoft.EntityFrameworkCore;
using ExtremeHelp.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicionar a string de conexão e o DbContextDefaultConnection
var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ExtremeHelpDB;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connectionString));

// Adicionar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWebApp", policy =>
    {
        policy.WithOrigins("http://localhost:5000", "https://localhost:5001", "http://localhost:7153", "https://localhost:7153") // Adicione a porta da sua WebApp
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowWebApp"); // Usar o CORS
app.UseAuthorization();
app.MapControllers();
app.Run();
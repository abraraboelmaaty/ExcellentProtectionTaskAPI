using ExcellentProtectionTaskAPI.Data;
using ExcellentProtectionTaskAPI.Models;
using ExcellentProtectionTaskAPI.Repositories;
using Microsoft.EntityFrameworkCore;

/* API and web clients will share data through this variable */
string txt = "";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<Entites>(e => e
                .UseSqlServer(builder.Configuration.GetConnectionString("EXPConn"))
                .UseEnumCheckConstraints());
builder.Services.AddScoped<IRepository<Payment>, PaymentRepo>();
builder.Services.AddScoped<IRepository<Order>, OrderRepo>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/* Registering CORS service */
builder.Services.AddCors(options =>
{
    options.AddPolicy(txt,
    builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/* Using CORS */
app.UseCors(txt);

app.UseAuthorization();

app.MapControllers();

app.Run();

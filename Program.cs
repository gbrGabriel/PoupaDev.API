using PoupaDev.API.Persistence;
using Microsoft.EntityFrameworkCore;
using PoupaDev.API.Jobs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("PoupaDevCs");
builder.Services.AddDbContext<PoupaDevDbContext>(e =>
    e.UseSqlServer(connectionString)
);

builder.Services.AddHostedService<RendimentoAutomaticoJob>();
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

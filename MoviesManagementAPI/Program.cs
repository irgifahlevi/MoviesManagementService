using Microsoft.EntityFrameworkCore;
using MoviesManagement.DataAccess.Context;
using MoviesManagement.DataAccess.Implementation;
using MoviesManagement.Domain.Repository;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("DB");
builder.Services.AddDbContext<MovieDbContext>(o => o.UseSqlServer(connection));

// depedncy injection
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddMvc().AddJsonOptions(a => a.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

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

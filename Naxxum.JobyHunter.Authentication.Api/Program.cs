using Microsoft.EntityFrameworkCore;
using Naxxum.JobyHunter.Authentication.Infrastructure.Data;
using Naxxum.JobyHunter.Authentication.Application;
using Naxxum.JobyHunter.Authentication.Infrastructure;
using Microsoft.Extensions.Configuration;
using Naxxum.JobyHunter.Authentication.Domain.Entities;
using Naxxum.JobyHunter.Authentication.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);


// add layar dependecny 
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration); 


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

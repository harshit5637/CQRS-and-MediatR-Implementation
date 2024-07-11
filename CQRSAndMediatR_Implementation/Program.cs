using CQRSAndMediatR_Implementation.Data;
using CQRSAndMediatR_Implementation.Repositories;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System;
using Microsoft.EntityFrameworkCore;
using CQRSAndMediatR_Implementation;

var builder = WebApplication.CreateBuilder(args);

// Load configuration from appsettings.json
builder.Configuration.AddJsonFile("appsettings.json");

// Add services to the container.
builder.Services.AddDbContext<DbContextClass>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("StudentData")));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.MediatorService(builder.Configuration);

builder.Services.AddControllers();
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

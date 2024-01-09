using Consultorio_Legal.API.Configuration;
using Consultorio_Legal.CORE.SHARED.ModelViews;
using Consultorio_Legal.DATA.Context;
using Consultorio_Legal.DATA.Repository;
using Consultorio_Legal.MANAGER.Implementation;
using Consultorio_Legal.MANAGER.Interfaces;
using Consultorio_Legal.MANAGER.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.UseAutoMapperConfiguration();

builder.Services.AddDbContext<ConsultorioLegalContext>(options => options.UseSqlServer("Server=localhost; Database=DB_Consultorio_Legal; Integrated Security=True; trustServerCertificate=true"));

builder.Services.UseDependencyInjectionConfiguration();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwaggerConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

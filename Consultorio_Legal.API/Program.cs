using Consultorio_Legal.API.Configuration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.UseAutoMapperConfiguration();

builder.Services.AddDataBaseConfiguration();

builder.Services.UseDependencyInjectionConfiguration();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerConfiguration();

Log.Logger = new LoggerConfiguration()
.Enrich.FromLogContext()
.MinimumLevel.Debug()
.CreateLogger();

// try
// {
//     Log.Information("Iniciando o WebApi");
// }
// catch (Exception ex)
// {
//     Log.Fatal(ex, "Erro catastrofico");
//     throw;
// }
// finally
// {
//     Log.CloseAndFlush();
// }

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseExceptionHandler("/error");

app.UseSwaggerConfiguration();

app.UseDataBaseConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

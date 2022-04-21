using Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASPNETCore_WebAPI.Data;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ShipDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("ShipDbContext") ?? throw new InvalidOperationException("Connection string 'ShipDbContext' not found.")));

// Add services to the container.

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration((builder.Configuration))
    .CreateLogger();

//AddController f�gt weitere Dienste noch hinzu 
builder.Services.AddControllers(); //WebAPI 

//Neu in .NET 6 via Host 
builder.Host.UseSerilog();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //Documentation + Funktionstest 

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //Nur f�r Entwickler zug�nglich
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); //Request-URL wird an den richtigen Controller weitergleitet


try
{
    Log.Information("Starting web host");
    app.Run();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}

using Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASPNETCore_WebAPI.Data;
using System.Reflection;
using ASPNETCore_WebAPI.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


//AddController f�gt weitere Dienste noch hinzu 
builder.Services.AddControllers(); //WebAPI 

//jetzt können wir im Video-Service mit Konstruktor-Injection eine Http-Client-Instanz erhalten 
builder.Services.AddTransient<IFileService, FileService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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

app.Run();

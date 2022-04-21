//using Serilog;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using ASPNETCore_WebAPI.Data;
//using System.Reflection;

//WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


//#region Entity Framework - Anbindung -> ShipController
//builder.Services.AddDbContext<ShipDbContext>(options =>

//    options.UseSqlServer(builder.Configuration.GetConnectionString("ShipDbContext") ?? throw new InvalidOperationException("Connection string 'ShipDbContext' not found.")));
//#endregion
//// Add services to the container.


//#region Serilog-Configuration werden ausgelesen
//Log.Logger = new LoggerConfiguration()
//    .ReadFrom.Configuration((builder.Configuration))
//    .CreateLogger();
//#endregion

////AddController f�gt weitere Dienste noch hinzu 
//builder.Services.AddControllers(); //WebAPI 


//#region Serilog-Einbindung
////Neu in .NET 6 via Host 
//builder.Host.UseSerilog();
//#endregion

//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

//#region Swagger-Documentation -> Generated XML-File wird lokaolisiert und in Swagger ausgewertet 
////!!! Bitte Projekt->Properties->Tab (Build->General) wechseln -> Suche Option -> aktiviere 'Containing a file for API Documentation' 
//builder.Services.AddSwaggerGen(options=>
//{
//    // using System.Reflection;
//    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
//}); //Documentation + Funktionstest 
//#endregion




//WebApplication app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    //Nur f�r Entwickler zug�nglich
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers(); //Request-URL wird an den richtigen Controller weitergleitet

//#region Serilog stützt app.Run 
//try
//{
//    Log.Information("Starting web host");
//    app.Run();
//    return 0;
//}
//catch (Exception ex)
//{
//    Log.Fatal(ex, "Host terminated unexpectedly");
//    return 1;
//}
//finally
//{
//    Log.CloseAndFlush();
//}
//#endregion

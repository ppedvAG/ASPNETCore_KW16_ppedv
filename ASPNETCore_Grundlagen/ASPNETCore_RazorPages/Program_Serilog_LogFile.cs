//using ASPNETCore_RazorPages.Services;
//using Serilog;

//WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

////Logger wird als erstes eingebunden

////
//Log.Logger = new LoggerConfiguration()
//    .ReadFrom.Configuration((builder.Configuration))
//    .CreateLogger();

//builder.Services.AddRazorPages();

////Neu in .NET 6 via Host 
//builder.Host.UseSerilog();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();


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


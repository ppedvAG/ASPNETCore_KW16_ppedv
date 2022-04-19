
//using ASPNETCore_RazorPages.Configurations;
//using ASPNETCore_RazorPages.Services;

//WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zurück



//builder.Services.AddRazorPages();

////IConfiguration wird auch in den IOC Container gesetzt -> also vor Build 

////Einlesen einer weiteren JSON - Datei 
//builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
//{
//    config.AddJsonFile("GameSettings.json", optional:true, reloadOnChange: true);
//});

////Lese Sektion 'GameSettings' aus GameSettings.json aus und übertrage (mappe) die Struktur in die GameSettings-Klasse! Daher müssen die Properties der GameSettings-Klasse die selben Namen
////wie in den JSON verwendet werden
//builder.Services.Configure<GameSettings>(builder.Configuration.GetSection("GameSettings"));

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

//app.Run();

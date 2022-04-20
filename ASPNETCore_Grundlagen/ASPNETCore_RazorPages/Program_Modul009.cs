////WebApplicationBuilder kümmert sich um das Initaliseren der WebApp 
//using ASPNETCore_RazorPages.Services;

//WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zurück

//// in .NET 5 public void ConfigureServices(IServiceCollection services)
//builder.Services.AddRazorPages(options=> {
//    options.Conventions.AddPageRoute("/Modul009/FriendlyRouteSample", "Post/{year}/{month}/{day}/{title}");
//}); //Wir fürgen das RazorPage UI-Framework hinzu

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

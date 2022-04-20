////WebApplicationBuilder kümmert sich um das Initaliseren der WebApp 
//using ASPNETCore_RazorPages.Services;

//WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zurück

//builder.Services.AddRazorPages(); //Wir fürgen das RazorPage UI-Framework hinzu

////Session muss freigeschaltet werden
//builder.Services.AddSession(options=>
//{
//    //options.IOTimeout = new TimeSpan(1, 0, 0);
//    options.IdleTimeout = new TimeSpan(1, 0, 0);
    
//    //options.Cookie.HttpOnly = true;
//    //options.Cookie.IsEssential = true;
//});

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

//app.UseSession();
//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
